namespace TcpClient
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDiagnostic = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblConnect = new System.Windows.Forms.Label();
            this.btnDiagnostic = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblTmp2 = new System.Windows.Forms.Label();
            this.lblHmd2 = new System.Windows.Forms.Label();
            this.lblTmp = new System.Windows.Forms.Label();
            this.lblHmd = new System.Windows.Forms.Label();
            this.lblSoil2 = new System.Windows.Forms.Label();
            this.lblSoil = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSerial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.lblExit);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.lblDiagnostic);
            this.panel2.Controls.Add(this.lblState);
            this.panel2.Controls.Add(this.lblConnect);
            this.panel2.Controls.Add(this.btnDiagnostic);
            this.panel2.Controls.Add(this.btnState);
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 443);
            this.panel2.TabIndex = 5;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(66, 389);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(42, 23);
            this.lblExit.TabIndex = 16;
            this.lblExit.Text = "Exit";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(64, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 60);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Smart Dr.Farm";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-6, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(82, 79);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Beige;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(13, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 36);
            this.btnExit.TabIndex = 14;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDiagnostic
            // 
            this.lblDiagnostic.AutoSize = true;
            this.lblDiagnostic.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostic.Location = new System.Drawing.Point(55, 261);
            this.lblDiagnostic.Name = "lblDiagnostic";
            this.lblDiagnostic.Size = new System.Drawing.Size(108, 23);
            this.lblDiagnostic.TabIndex = 11;
            this.lblDiagnostic.Text = "Diagnostic";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(55, 192);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(57, 23);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State";
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnect.Location = new System.Drawing.Point(54, 130);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(89, 23);
            this.lblConnect.TabIndex = 9;
            this.lblConnect.Text = "Connect";
            // 
            // btnDiagnostic
            // 
            this.btnDiagnostic.BackColor = System.Drawing.Color.Beige;
            this.btnDiagnostic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiagnostic.BackgroundImage")));
            this.btnDiagnostic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiagnostic.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnostic.Location = new System.Drawing.Point(10, 252);
            this.btnDiagnostic.Name = "btnDiagnostic";
            this.btnDiagnostic.Size = new System.Drawing.Size(40, 36);
            this.btnDiagnostic.TabIndex = 2;
            this.btnDiagnostic.UseVisualStyleBackColor = false;
            this.btnDiagnostic.Click += new System.EventHandler(this.btnDiagnostic_Click);
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.Beige;
            this.btnState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnState.BackgroundImage")));
            this.btnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnState.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnState.Location = new System.Drawing.Point(10, 183);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(40, 36);
            this.btnState.TabIndex = 1;
            this.btnState.Text = "2";
            this.btnState.UseVisualStyleBackColor = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.BackColor = System.Drawing.Color.Beige;
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(9, 119);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(41, 36);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "1";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblTmp2
            // 
            this.lblTmp2.AutoSize = true;
            this.lblTmp2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmp2.Location = new System.Drawing.Point(44, 143);
            this.lblTmp2.Name = "lblTmp2";
            this.lblTmp2.Size = new System.Drawing.Size(55, 25);
            this.lblTmp2.TabIndex = 1;
            this.lblTmp2.Text = "Tmp";
            // 
            // lblHmd2
            // 
            this.lblHmd2.AutoSize = true;
            this.lblHmd2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHmd2.Location = new System.Drawing.Point(43, 143);
            this.lblHmd2.Name = "lblHmd2";
            this.lblHmd2.Size = new System.Drawing.Size(60, 25);
            this.lblHmd2.TabIndex = 2;
            this.lblHmd2.Text = "Hmd";
            // 
            // lblTmp
            // 
            this.lblTmp.AutoSize = true;
            this.lblTmp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTmp.Location = new System.Drawing.Point(55, 172);
            this.lblTmp.Name = "lblTmp";
            this.lblTmp.Size = new System.Drawing.Size(30, 25);
            this.lblTmp.TabIndex = 3;
            this.lblTmp.Text = "--";
            this.lblTmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTmp.Click += new System.EventHandler(this.lblTmp_Click);
            // 
            // lblHmd
            // 
            this.lblHmd.AutoSize = true;
            this.lblHmd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHmd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHmd.Location = new System.Drawing.Point(53, 173);
            this.lblHmd.Name = "lblHmd";
            this.lblHmd.Size = new System.Drawing.Size(30, 25);
            this.lblHmd.TabIndex = 4;
            this.lblHmd.Text = "--";
            this.lblHmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoil2
            // 
            this.lblSoil2.AutoSize = true;
            this.lblSoil2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoil2.Location = new System.Drawing.Point(50, 143);
            this.lblSoil2.Name = "lblSoil2";
            this.lblSoil2.Size = new System.Drawing.Size(46, 25);
            this.lblSoil2.TabIndex = 5;
            this.lblSoil2.Text = "Soil";
            // 
            // lblSoil
            // 
            this.lblSoil.AutoSize = true;
            this.lblSoil.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoil.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSoil.Location = new System.Drawing.Point(24, 173);
            this.lblSoil.Name = "lblSoil";
            this.lblSoil.Size = new System.Drawing.Size(54, 25);
            this.lblSoil.TabIndex = 6;
            this.lblSoil.Text = "    --";
            this.lblSoil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSoil.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(92, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "(℃)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(85, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "(%)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(86, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "(%)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTitle2);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 548);
            this.panel1.TabIndex = 8;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.Location = new System.Drawing.Point(83, 39);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(36, 23);
            this.lblSerial.TabIndex = 13;
            this.lblSerial.Text = "Off";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Serial :";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(83, 15);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(36, 23);
            this.lblServer.TabIndex = 11;
            this.lblServer.Text = "Off";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(320, 79);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(230, 38);
            this.lblTitle2.TabIndex = 9;
            this.lblTitle2.Text = "sub-title 4 test";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Ivory;
            this.groupBox6.Controls.Add(this.pictureBox3);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.lblSoil2);
            this.groupBox6.Controls.Add(this.lblSoil);
            this.groupBox6.Location = new System.Drawing.Point(533, 156);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(145, 214);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Ivory;
            this.groupBox5.Controls.Add(this.pictureBox2);
            this.groupBox5.Controls.Add(this.lblHmd2);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.lblHmd);
            this.groupBox5.Location = new System.Drawing.Point(367, 156);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(145, 214);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Ivory;
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.lblTmp2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.lblTmp);
            this.groupBox4.Location = new System.Drawing.Point(200, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(146, 214);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(24, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(114, 23);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "2022-01-01";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel3.Controls.Add(this.lblSerial);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblServer);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(545, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 74);
            this.panel3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 544);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDiagnostic;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSoil;
        private System.Windows.Forms.Label lblSoil2;
        private System.Windows.Forms.Label lblHmd;
        private System.Windows.Forms.Label lblTmp;
        private System.Windows.Forms.Label lblHmd2;
        private System.Windows.Forms.Label lblTmp2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDiagnostic;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel3;
    }
}

