using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Timers;
using System.Windows.Forms;
namespace Observatory
{
    class GateControl
    {
        static int baudRate = 2400;
        static int dataBits = 8;
        static StopBits stopBit = StopBits.One;
        static Parity parity = Parity.None;

        static float MINIMAL_DEGREE = 3.5f;
        static int MAX_STEP = 25;
        static int MINIMAL_STEP = 1;
        static int PER_STEP_DELAY = 500;//ms

        Action<string> Log;
        Action onOpen, onClose, onStart, onStop;

        SerialPort sp = new SerialPort();
        Form form;
        bool serialPortStatus = false;

        bool isLisening = false;
        bool isClosing = false;

        StringBuilder stringBuilder = new StringBuilder();
        public GateControl(Form form, Action onOpen, Action onClose, Action<string> log, Action onStart, Action onStop)
        {
            sp.BaudRate = baudRate;
            sp.DataBits = dataBits;
            sp.Parity = parity;
            sp.StopBits = stopBit;
            sp.DataReceived += Sp_DataReceived;

            Log = log;
            this.onOpen = () =>
            {
                onOpen();
                Log("connect success");
            };
            this.onClose = () =>
            {
                onClose();
                Log("disconnect success");
            };
            this.onStart = onStart;
            this.onStop = onStop;
            this.form = form;

        }

        public void Dispose()
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
        }

        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (isClosing)
                return;
            try
            {
                isLisening = true;
                int n = sp.BytesToRead;
                byte[] buf = new byte[n];
                sp.Read(buf, 0, n);
                stringBuilder.Clear();
                this.form.Invoke((EventHandler)delegate
                {
                    stringBuilder.Append(Encoding.ASCII.GetString(buf));
                    receiveHandler(stringBuilder.ToString());
                });
            }
            finally
            {
                isLisening = false;
            }
        }
        void receiveHandler(string data)
        {
            char[] spter = new char[1] { '-' };
            string[] arr = data.Split(spter);
            switch (arr[0])
            {
                case "hall":
                    spter = new char[1] { ' ' };
                    string[] hallStatus = arr[1].Split(spter);
                    break;

                default:
                    Log(data);
                    break;
            }
        }

        public void connect(string portName)
        {
            sp.PortName = portName;
            try
            {
                if (sp.IsOpen)
                {
                    sp.Close();
                }
                sp.Open();
                this.onOpen();

                serialPortStatus = true;

            }
            catch (Exception e)
            {
                Log("error:" + e.Message);
            }
        }
        public void disconnect()
        {
            if (sp.IsOpen)
            {
                isClosing = true;
                while (isLisening)
                    Application.DoEvents();

                try
                {
                    sp.Close();
                    isClosing = false;
                }
                catch (Exception e)
                {
                    Log(e.Message);
                }
            }
            this.onClose();
            serialPortStatus = false;
        }

        //TODO
        public void OpenGate()
        {
            OpenLeftGate(() =>
            {
                OpenRightGate(() =>
                {
                    OpenRightGate(() =>
                    {
                        //OpenRightGate();
                        OpenRightAny(11 * MINIMAL_DEGREE);
                    });
                });
            });
        }
        //TODO
        public void CloseGate()
        {
            CloseRightGate(()=>
            {
                CloseRightGate(()=> {
                    CloseRightAny(11* MINIMAL_DEGREE,()=>
                    {
                        CloseLeftGate();
                    });
                });
            });

           /* CloseLeftGate(() =>
            {
                CloseRightGate();
            });*/
        }
        public void OpenLeftGate(Action next = null)
        {
            int step = MAX_STEP;
            getres(0, 0, step, next);
        }
        public void CloseLeftGate(Action next = null)
        {
            int step = MAX_STEP;
            getres(0, 1, step, next);
        }
        public void OpenRightGate(Action next = null)
        {
            int step = MAX_STEP;
            getres(1, 0, step, next);
        }
        public void CloseRightGate(Action next = null)
        {
            int step = MAX_STEP;
            getres(1, 1, step, next);

        }
        public void OpenLeftMinimal()
        {
            int step = MINIMAL_STEP;
            getres(0, 0, step);
        }
        public void OpenRightMinimal()
        {
            int step = MINIMAL_STEP;
            getres(1, 0, step);
        }
        public void CloseLeftMinimal()
        {
            int step = MINIMAL_STEP;
            getres(0, 1, step);
        }
        public void CloseRightMinimal()
        {
            int step = MINIMAL_STEP;
            getres(1, 1, step);
        }
        public void OpenLeftAny(float deg)
        {
            int step = getstep(deg);
            getres(0, 0, step);
        }
        public void OpenRightAny(float deg)
        {
            int step = getstep(deg);
            getres(1, 0, step);
        }
        public void CloseLeftAny(float deg)
        {
            int step = getstep(deg);
            getres(0, 1, step);
        }
        public void CloseRightAny(float deg,Action next = null)
        {
            int step = getstep(deg);
            getres(1, 1, step, next);

        }
        int getstep(float deg)
        {
            return (int)(deg / MINIMAL_DEGREE);
        }
        void getres(int position, int direction, int step, Action next = null, int nextDelayTime = 500)
        {
            if (!serialPortStatus)
            {
                Log("serial port hasnot connected");
                return;
            }
            //int msgtype = 0 << 7;
            //msgtype = 0
            int p = (position << 6);
            int d = (direction << 5);
            int s = step & 0x1f;
            byte data = (byte)(p | d | s);
            this.onStart();
            //resend 0x96 before every command send
            byte initdata = 0x96;
            sendData(initdata);

            sendData(data);
            string log = "";
            if (position == 0)
            {
                log += "LeftGate ";
            }
            else
            {
                log += "RightGate ";
            }

            if (direction == 0)
            {
                log += "Open ";
            }
            else
            {
                log += "Close ";
            }
            int delaytime = step * PER_STEP_DELAY;
            float dt = (float)delaytime / 1000;
            log += dt.ToString() + "s";
            Log(log);

            System.Timers.Timer t = new System.Timers.Timer(delaytime)
            {
                Enabled = true,
                AutoReset = false
            };
            t.Elapsed += (sender, e) =>
            {
                callbackDelegate del = delegate ()
                {
                    this.onStop();
                    Log("done");
                    if (next != null)
                    {
                        System.Threading.Thread.Sleep(nextDelayTime);
                        next();
                    }
                };
                this.form.Invoke(del);
            };
        }

        delegate void callbackDelegate();

        void sendData(byte data)
        {
            byte[] b = new byte[1];
            b[0] = data;
            try
            {
                Log("send:" + Convert.ToString(data, 16));//TODO need delete
                sp.Write(b, 0, 1);

            }
            catch (Exception e)
            {
                Log("error：" + e.Message);
            }
        }

    }
}
