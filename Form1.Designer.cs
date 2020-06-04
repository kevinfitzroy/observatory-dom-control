namespace Observatory
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenGate = new System.Windows.Forms.Button();
            this.CloseGate = new System.Windows.Forms.Button();
            this.OpenRightGate = new System.Windows.Forms.Button();
            this.OpenLeftGate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseLeftGate = new System.Windows.Forms.Button();
            this.CloseRightGate = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.serialDrop = new System.Windows.Forms.ComboBox();
            this.serialPromot = new System.Windows.Forms.Label();
            this.OpenSerialPort = new System.Windows.Forms.Button();
            this.CloseSerialPort = new System.Windows.Forms.Button();
            this.OpenLeftMinimal = new System.Windows.Forms.Button();
            this.OpenRightMinimal = new System.Windows.Forms.Button();
            this.CloseLeftMinimal = new System.Windows.Forms.Button();
            this.CloseRightMinimal = new System.Windows.Forms.Button();
            this.OpenAnyDropBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseAnyDropBox = new System.Windows.Forms.ComboBox();
            this.OpenLeftAnyDegree = new System.Windows.Forms.Button();
            this.OpenRightAnyDegree = new System.Windows.Forms.Button();
            this.CloseRightAnyDegree = new System.Windows.Forms.Button();
            this.CloseLeftAnyDrgree = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CapAnyOpenButton = new System.Windows.Forms.Button();
            this.capOpenDegreeBox = new System.Windows.Forms.TextBox();
            this.CapHalfOpenButton = new System.Windows.Forms.Button();
            this.CapSerialDrop = new System.Windows.Forms.ComboBox();
            this.CapConnectButton = new System.Windows.Forms.Button();
            this.CapCloseButton = new System.Windows.Forms.Button();
            this.CapFullOpenButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenGate
            // 
            this.OpenGate.BackColor = System.Drawing.Color.DarkGreen;
            this.OpenGate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenGate.ForeColor = System.Drawing.Color.White;
            this.OpenGate.Location = new System.Drawing.Point(21, 310);
            this.OpenGate.Name = "OpenGate";
            this.OpenGate.Size = new System.Drawing.Size(118, 115);
            this.OpenGate.TabIndex = 0;
            this.OpenGate.Text = "开门";
            this.OpenGate.UseVisualStyleBackColor = false;
            this.OpenGate.Click += new System.EventHandler(this.OpenGate_Click);
            // 
            // CloseGate
            // 
            this.CloseGate.BackColor = System.Drawing.Color.DarkRed;
            this.CloseGate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseGate.ForeColor = System.Drawing.Color.White;
            this.CloseGate.Location = new System.Drawing.Point(21, 463);
            this.CloseGate.Name = "CloseGate";
            this.CloseGate.Size = new System.Drawing.Size(118, 115);
            this.CloseGate.TabIndex = 1;
            this.CloseGate.Text = "关门";
            this.CloseGate.UseVisualStyleBackColor = false;
            this.CloseGate.Click += new System.EventHandler(this.CloseGate_Click);
            // 
            // OpenRightGate
            // 
            this.OpenRightGate.BackColor = System.Drawing.Color.ForestGreen;
            this.OpenRightGate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenRightGate.ForeColor = System.Drawing.Color.White;
            this.OpenRightGate.Location = new System.Drawing.Point(331, 310);
            this.OpenRightGate.Name = "OpenRightGate";
            this.OpenRightGate.Size = new System.Drawing.Size(107, 35);
            this.OpenRightGate.TabIndex = 2;
            this.OpenRightGate.Text = "全开顶门";
            this.OpenRightGate.UseVisualStyleBackColor = false;
            this.OpenRightGate.Click += new System.EventHandler(this.OpenRightGate_Click);
            // 
            // OpenLeftGate
            // 
            this.OpenLeftGate.BackColor = System.Drawing.Color.SeaGreen;
            this.OpenLeftGate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenLeftGate.ForeColor = System.Drawing.Color.White;
            this.OpenLeftGate.Location = new System.Drawing.Point(181, 310);
            this.OpenLeftGate.Name = "OpenLeftGate";
            this.OpenLeftGate.Size = new System.Drawing.Size(107, 35);
            this.OpenLeftGate.TabIndex = 3;
            this.OpenLeftGate.Text = "全开侧门";
            this.OpenLeftGate.UseVisualStyleBackColor = false;
            this.OpenLeftGate.Click += new System.EventHandler(this.OpenLeftGate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(930, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CloseLeftGate
            // 
            this.CloseLeftGate.BackColor = System.Drawing.Color.Brown;
            this.CloseLeftGate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseLeftGate.ForeColor = System.Drawing.Color.White;
            this.CloseLeftGate.Location = new System.Drawing.Point(181, 463);
            this.CloseLeftGate.Name = "CloseLeftGate";
            this.CloseLeftGate.Size = new System.Drawing.Size(107, 35);
            this.CloseLeftGate.TabIndex = 7;
            this.CloseLeftGate.Text = "全关侧门";
            this.CloseLeftGate.UseVisualStyleBackColor = false;
            this.CloseLeftGate.Click += new System.EventHandler(this.CloseLeftGate_Click);
            // 
            // CloseRightGate
            // 
            this.CloseRightGate.BackColor = System.Drawing.Color.SaddleBrown;
            this.CloseRightGate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseRightGate.ForeColor = System.Drawing.Color.White;
            this.CloseRightGate.Location = new System.Drawing.Point(331, 463);
            this.CloseRightGate.Name = "CloseRightGate";
            this.CloseRightGate.Size = new System.Drawing.Size(107, 35);
            this.CloseRightGate.TabIndex = 6;
            this.CloseRightGate.Text = "全关顶门";
            this.CloseRightGate.UseVisualStyleBackColor = false;
            this.CloseRightGate.Click += new System.EventHandler(this.CloseRightGate_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Title.Location = new System.Drawing.Point(281, 96);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(359, 62);
            this.Title.TabIndex = 8;
            this.Title.Text = "Dome Control";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialDrop
            // 
            this.serialDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialDrop.FormattingEnabled = true;
            this.serialDrop.Location = new System.Drawing.Point(98, 266);
            this.serialDrop.Name = "serialDrop";
            this.serialDrop.Size = new System.Drawing.Size(118, 20);
            this.serialDrop.TabIndex = 11;
            // 
            // serialPromot
            // 
            this.serialPromot.AutoSize = true;
            this.serialPromot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.serialPromot.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serialPromot.Location = new System.Drawing.Point(17, 266);
            this.serialPromot.Name = "serialPromot";
            this.serialPromot.Size = new System.Drawing.Size(68, 17);
            this.serialPromot.TabIndex = 12;
            this.serialPromot.Text = "选择串口：";
            // 
            // OpenSerialPort
            // 
            this.OpenSerialPort.Location = new System.Drawing.Point(243, 264);
            this.OpenSerialPort.Name = "OpenSerialPort";
            this.OpenSerialPort.Size = new System.Drawing.Size(75, 23);
            this.OpenSerialPort.TabIndex = 13;
            this.OpenSerialPort.Text = "打开串口";
            this.OpenSerialPort.UseVisualStyleBackColor = true;
            this.OpenSerialPort.Click += new System.EventHandler(this.OpenSerialPort_Click);
            // 
            // CloseSerialPort
            // 
            this.CloseSerialPort.Location = new System.Drawing.Point(345, 264);
            this.CloseSerialPort.Name = "CloseSerialPort";
            this.CloseSerialPort.Size = new System.Drawing.Size(75, 23);
            this.CloseSerialPort.TabIndex = 14;
            this.CloseSerialPort.Text = "关闭串口";
            this.CloseSerialPort.UseVisualStyleBackColor = true;
            this.CloseSerialPort.Click += new System.EventHandler(this.CloseSerialPort_Click);
            // 
            // OpenLeftMinimal
            // 
            this.OpenLeftMinimal.BackColor = System.Drawing.Color.SeaGreen;
            this.OpenLeftMinimal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenLeftMinimal.ForeColor = System.Drawing.Color.White;
            this.OpenLeftMinimal.Location = new System.Drawing.Point(181, 350);
            this.OpenLeftMinimal.Name = "OpenLeftMinimal";
            this.OpenLeftMinimal.Size = new System.Drawing.Size(107, 35);
            this.OpenLeftMinimal.TabIndex = 15;
            this.OpenLeftMinimal.Text = "开侧门1步";
            this.OpenLeftMinimal.UseVisualStyleBackColor = false;
            this.OpenLeftMinimal.Click += new System.EventHandler(this.OpenLeftMinimal_Click);
            // 
            // OpenRightMinimal
            // 
            this.OpenRightMinimal.BackColor = System.Drawing.Color.ForestGreen;
            this.OpenRightMinimal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenRightMinimal.ForeColor = System.Drawing.Color.White;
            this.OpenRightMinimal.Location = new System.Drawing.Point(331, 351);
            this.OpenRightMinimal.Name = "OpenRightMinimal";
            this.OpenRightMinimal.Size = new System.Drawing.Size(107, 35);
            this.OpenRightMinimal.TabIndex = 16;
            this.OpenRightMinimal.Text = "开顶门1步";
            this.OpenRightMinimal.UseVisualStyleBackColor = false;
            this.OpenRightMinimal.Click += new System.EventHandler(this.OpenRightMinimal_Click);
            // 
            // CloseLeftMinimal
            // 
            this.CloseLeftMinimal.BackColor = System.Drawing.Color.Brown;
            this.CloseLeftMinimal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseLeftMinimal.ForeColor = System.Drawing.Color.White;
            this.CloseLeftMinimal.Location = new System.Drawing.Point(181, 503);
            this.CloseLeftMinimal.Name = "CloseLeftMinimal";
            this.CloseLeftMinimal.Size = new System.Drawing.Size(107, 35);
            this.CloseLeftMinimal.TabIndex = 17;
            this.CloseLeftMinimal.Text = "关侧门1步";
            this.CloseLeftMinimal.UseVisualStyleBackColor = false;
            this.CloseLeftMinimal.Click += new System.EventHandler(this.CloseLeftMinimal_Click);
            // 
            // CloseRightMinimal
            // 
            this.CloseRightMinimal.BackColor = System.Drawing.Color.SaddleBrown;
            this.CloseRightMinimal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseRightMinimal.ForeColor = System.Drawing.Color.White;
            this.CloseRightMinimal.Location = new System.Drawing.Point(331, 503);
            this.CloseRightMinimal.Name = "CloseRightMinimal";
            this.CloseRightMinimal.Size = new System.Drawing.Size(107, 35);
            this.CloseRightMinimal.TabIndex = 18;
            this.CloseRightMinimal.Text = "关顶门1步";
            this.CloseRightMinimal.UseVisualStyleBackColor = false;
            this.CloseRightMinimal.Click += new System.EventHandler(this.CloseRightMinimal_Click);
            // 
            // OpenAnyDropBox
            // 
            this.OpenAnyDropBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpenAnyDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OpenAnyDropBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenAnyDropBox.FormattingEnabled = true;
            this.OpenAnyDropBox.Items.AddRange(new object[] {
            "3.5",
            "7",
            "14",
            "28",
            "56",
            "91"});
            this.OpenAnyDropBox.Location = new System.Drawing.Point(250, 405);
            this.OpenAnyDropBox.Name = "OpenAnyDropBox";
            this.OpenAnyDropBox.Size = new System.Drawing.Size(50, 25);
            this.OpenAnyDropBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(179, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "任选行程：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(179, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "任选行程：";
            // 
            // CloseAnyDropBox
            // 
            this.CloseAnyDropBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CloseAnyDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CloseAnyDropBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseAnyDropBox.FormattingEnabled = true;
            this.CloseAnyDropBox.Items.AddRange(new object[] {
            "3.5",
            "7",
            "14",
            "28",
            "56",
            "91"});
            this.CloseAnyDropBox.Location = new System.Drawing.Point(250, 558);
            this.CloseAnyDropBox.Name = "CloseAnyDropBox";
            this.CloseAnyDropBox.Size = new System.Drawing.Size(50, 25);
            this.CloseAnyDropBox.TabIndex = 23;
            // 
            // OpenLeftAnyDegree
            // 
            this.OpenLeftAnyDegree.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenLeftAnyDegree.Location = new System.Drawing.Point(334, 402);
            this.OpenLeftAnyDegree.Name = "OpenLeftAnyDegree";
            this.OpenLeftAnyDegree.Size = new System.Drawing.Size(49, 23);
            this.OpenLeftAnyDegree.TabIndex = 24;
            this.OpenLeftAnyDegree.Text = "开侧";
            this.OpenLeftAnyDegree.UseVisualStyleBackColor = true;
            this.OpenLeftAnyDegree.Click += new System.EventHandler(this.OpenLeftAnyDegree_Click);
            // 
            // OpenRightAnyDegree
            // 
            this.OpenRightAnyDegree.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenRightAnyDegree.Location = new System.Drawing.Point(389, 402);
            this.OpenRightAnyDegree.Name = "OpenRightAnyDegree";
            this.OpenRightAnyDegree.Size = new System.Drawing.Size(49, 23);
            this.OpenRightAnyDegree.TabIndex = 25;
            this.OpenRightAnyDegree.Text = "开顶";
            this.OpenRightAnyDegree.UseVisualStyleBackColor = true;
            this.OpenRightAnyDegree.Click += new System.EventHandler(this.OpenRightAnyDegree_Click);
            // 
            // CloseRightAnyDegree
            // 
            this.CloseRightAnyDegree.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseRightAnyDegree.Location = new System.Drawing.Point(389, 558);
            this.CloseRightAnyDegree.Name = "CloseRightAnyDegree";
            this.CloseRightAnyDegree.Size = new System.Drawing.Size(49, 23);
            this.CloseRightAnyDegree.TabIndex = 27;
            this.CloseRightAnyDegree.Text = "关顶";
            this.CloseRightAnyDegree.UseVisualStyleBackColor = true;
            this.CloseRightAnyDegree.Click += new System.EventHandler(this.CloseRightAnyDegree_Click);
            // 
            // CloseLeftAnyDrgree
            // 
            this.CloseLeftAnyDrgree.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseLeftAnyDrgree.Location = new System.Drawing.Point(334, 558);
            this.CloseLeftAnyDrgree.Name = "CloseLeftAnyDrgree";
            this.CloseLeftAnyDrgree.Size = new System.Drawing.Size(49, 23);
            this.CloseLeftAnyDrgree.TabIndex = 26;
            this.CloseLeftAnyDrgree.Text = "关侧";
            this.CloseLeftAnyDrgree.UseVisualStyleBackColor = true;
            this.CloseLeftAnyDrgree.Click += new System.EventHandler(this.CloseLeftAnyDrgree_Click);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(474, 260);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(444, 460);
            this.logBox.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 148);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "开门控制区";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 447);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 148);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "关门控制区";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 37);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CapAnyOpenButton);
            this.groupBox4.Controls.Add(this.capOpenDegreeBox);
            this.groupBox4.Controls.Add(this.CapHalfOpenButton);
            this.groupBox4.Controls.Add(this.CapSerialDrop);
            this.groupBox4.Controls.Add(this.CapConnectButton);
            this.groupBox4.Controls.Add(this.CapCloseButton);
            this.groupBox4.Controls.Add(this.CapFullOpenButton);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 606);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 115);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "镜头盖控制区";
            // 
            // CapAnyOpenButton
            // 
            this.CapAnyOpenButton.Enabled = false;
            this.CapAnyOpenButton.Location = new System.Drawing.Point(260, 68);
            this.CapAnyOpenButton.Name = "CapAnyOpenButton";
            this.CapAnyOpenButton.Size = new System.Drawing.Size(83, 23);
            this.CapAnyOpenButton.TabIndex = 9;
            this.CapAnyOpenButton.Text = "任意角度开";
            this.CapAnyOpenButton.UseVisualStyleBackColor = true;
            this.CapAnyOpenButton.Click += new System.EventHandler(this.CapAnyOpenButton_Click);
            // 
            // capOpenDegreeBox
            // 
            this.capOpenDegreeBox.Location = new System.Drawing.Point(171, 68);
            this.capOpenDegreeBox.Name = "capOpenDegreeBox";
            this.capOpenDegreeBox.Size = new System.Drawing.Size(83, 23);
            this.capOpenDegreeBox.TabIndex = 8;
            // 
            // CapHalfOpenButton
            // 
            this.CapHalfOpenButton.Enabled = false;
            this.CapHalfOpenButton.Location = new System.Drawing.Point(260, 36);
            this.CapHalfOpenButton.Name = "CapHalfOpenButton";
            this.CapHalfOpenButton.Size = new System.Drawing.Size(83, 23);
            this.CapHalfOpenButton.TabIndex = 7;
            this.CapHalfOpenButton.Text = "半开";
            this.CapHalfOpenButton.UseVisualStyleBackColor = true;
            this.CapHalfOpenButton.Click += new System.EventHandler(this.CapHalfOpenButton_Click);
            // 
            // CapSerialDrop
            // 
            this.CapSerialDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CapSerialDrop.FormattingEnabled = true;
            this.CapSerialDrop.Location = new System.Drawing.Point(19, 36);
            this.CapSerialDrop.Name = "CapSerialDrop";
            this.CapSerialDrop.Size = new System.Drawing.Size(121, 25);
            this.CapSerialDrop.TabIndex = 5;
            // 
            // CapConnectButton
            // 
            this.CapConnectButton.Location = new System.Drawing.Point(19, 67);
            this.CapConnectButton.Name = "CapConnectButton";
            this.CapConnectButton.Size = new System.Drawing.Size(121, 26);
            this.CapConnectButton.TabIndex = 4;
            this.CapConnectButton.Text = "连接";
            this.CapConnectButton.UseVisualStyleBackColor = true;
            this.CapConnectButton.Click += new System.EventHandler(this.CapConnectButton_Click);
            // 
            // CapCloseButton
            // 
            this.CapCloseButton.Enabled = false;
            this.CapCloseButton.Location = new System.Drawing.Point(349, 36);
            this.CapCloseButton.Name = "CapCloseButton";
            this.CapCloseButton.Size = new System.Drawing.Size(77, 55);
            this.CapCloseButton.TabIndex = 2;
            this.CapCloseButton.Text = "关闭镜头盖";
            this.CapCloseButton.UseVisualStyleBackColor = true;
            this.CapCloseButton.Click += new System.EventHandler(this.CapCloseButton_Click);
            // 
            // CapFullOpenButton
            // 
            this.CapFullOpenButton.Enabled = false;
            this.CapFullOpenButton.Location = new System.Drawing.Point(171, 36);
            this.CapFullOpenButton.Name = "CapFullOpenButton";
            this.CapFullOpenButton.Size = new System.Drawing.Size(83, 25);
            this.CapFullOpenButton.TabIndex = 0;
            this.CapFullOpenButton.Text = "全开";
            this.CapFullOpenButton.UseVisualStyleBackColor = true;
            this.CapFullOpenButton.Click += new System.EventHandler(this.CapFullOpenButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(9, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(141, 86);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 731);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.CloseRightAnyDegree);
            this.Controls.Add(this.CloseLeftAnyDrgree);
            this.Controls.Add(this.OpenRightAnyDegree);
            this.Controls.Add(this.OpenLeftAnyDegree);
            this.Controls.Add(this.CloseAnyDropBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenAnyDropBox);
            this.Controls.Add(this.CloseRightMinimal);
            this.Controls.Add(this.CloseLeftMinimal);
            this.Controls.Add(this.OpenRightMinimal);
            this.Controls.Add(this.OpenLeftMinimal);
            this.Controls.Add(this.CloseSerialPort);
            this.Controls.Add(this.OpenSerialPort);
            this.Controls.Add(this.serialPromot);
            this.Controls.Add(this.serialDrop);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CloseLeftGate);
            this.Controls.Add(this.CloseRightGate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OpenLeftGate);
            this.Controls.Add(this.OpenRightGate);
            this.Controls.Add(this.CloseGate);
            this.Controls.Add(this.OpenGate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ObservatoryGapControlSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenGate;
        private System.Windows.Forms.Button CloseGate;
        private System.Windows.Forms.Button OpenRightGate;
        private System.Windows.Forms.Button OpenLeftGate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseLeftGate;
        private System.Windows.Forms.Button CloseRightGate;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox serialDrop;
        private System.Windows.Forms.Label serialPromot;
        private System.Windows.Forms.Button OpenSerialPort;
        private System.Windows.Forms.Button CloseSerialPort;
        private System.Windows.Forms.Button OpenLeftMinimal;
        private System.Windows.Forms.Button OpenRightMinimal;
        private System.Windows.Forms.Button CloseLeftMinimal;
        private System.Windows.Forms.Button CloseRightMinimal;
        private System.Windows.Forms.ComboBox OpenAnyDropBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CloseAnyDropBox;
        private System.Windows.Forms.Button OpenLeftAnyDegree;
        private System.Windows.Forms.Button OpenRightAnyDegree;
        private System.Windows.Forms.Button CloseRightAnyDegree;
        private System.Windows.Forms.Button CloseLeftAnyDrgree;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button CapCloseButton;
        private System.Windows.Forms.Button CapFullOpenButton;
        private System.Windows.Forms.ComboBox CapSerialDrop;
        private System.Windows.Forms.Button CapConnectButton;
        private System.Windows.Forms.Button CapAnyOpenButton;
        private System.Windows.Forms.TextBox capOpenDegreeBox;
        private System.Windows.Forms.Button CapHalfOpenButton;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

