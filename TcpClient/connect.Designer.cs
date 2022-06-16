namespace TcpClient
{
    partial class connect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTcpConnect = new System.Windows.Forms.Button();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPaddress = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbBoardRate = new System.Windows.Forms.ComboBox();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.btnSerial = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 264);
            this.panel3.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTcpConnect);
            this.groupBox1.Controls.Add(this.txtLocalPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIPaddress);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnTcpConnect
            // 
            this.btnTcpConnect.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnTcpConnect.Location = new System.Drawing.Point(341, 25);
            this.btnTcpConnect.Name = "btnTcpConnect";
            this.btnTcpConnect.Size = new System.Drawing.Size(79, 59);
            this.btnTcpConnect.TabIndex = 6;
            this.btnTcpConnect.Text = "Connect";
            this.btnTcpConnect.UseVisualStyleBackColor = false;
            this.btnTcpConnect.Click += new System.EventHandler(this.btnTcpConnect_Click);
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Location = new System.Drawing.Point(209, 55);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(77, 21);
            this.txtLocalPort.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // txtIPaddress
            // 
            this.txtIPaddress.Location = new System.Drawing.Point(79, 55);
            this.txtIPaddress.Name = "txtIPaddress";
            this.txtIPaddress.Size = new System.Drawing.Size(79, 21);
            this.txtIPaddress.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(79, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(79, 21);
            this.txtUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbBoardRate);
            this.groupBox3.Controls.Add(this.cmbSerialPort);
            this.groupBox3.Controls.Add(this.btnSerial);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 143);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // cmbBoardRate
            // 
            this.cmbBoardRate.FormattingEnabled = true;
            this.cmbBoardRate.Location = new System.Drawing.Point(81, 64);
            this.cmbBoardRate.Name = "cmbBoardRate";
            this.cmbBoardRate.Size = new System.Drawing.Size(99, 20);
            this.cmbBoardRate.TabIndex = 13;
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(81, 25);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(99, 20);
            this.cmbSerialPort.TabIndex = 12;
            // 
            // btnSerial
            // 
            this.btnSerial.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSerial.Location = new System.Drawing.Point(341, 47);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(79, 57);
            this.btnSerial.TabIndex = 11;
            this.btnSerial.Text = "Connect";
            this.btnSerial.UseVisualStyleBackColor = false;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "BoardRate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "SerialPort";
            // 
            // connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 288);
            this.Controls.Add(this.panel3);
            this.Name = "connect";
            this.Text = "connect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.connect_FormClosing);
            this.Load += new System.EventHandler(this.connect_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTcpConnect;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIPaddress;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbBoardRate;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}