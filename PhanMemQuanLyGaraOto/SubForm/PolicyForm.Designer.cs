namespace PhanMemQuanLyGaraOto.SubForm
{
    partial class PolicyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.btbMaxFixChange = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.btbToggleChange = new PhanMemQuanLyGaraOto.CustomControl.ToggleButton();
            this.btbProfitChange = new System.Windows.Forms.Button();
            this.nudProfitRate = new System.Windows.Forms.NumericUpDown();
            this.nudMaxFixTimes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toggleNotiGeneRal = new PhanMemQuanLyGaraOto.CustomControl.ToggleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.toggleNotiData = new PhanMemQuanLyGaraOto.CustomControl.ToggleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProfitRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxFixTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ControlPanel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 553);
            this.panel1.TabIndex = 0;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ControlPanel.Controls.Add(this.btbMaxFixChange);
            this.ControlPanel.Controls.Add(this.lblState);
            this.ControlPanel.Controls.Add(this.btbToggleChange);
            this.ControlPanel.Controls.Add(this.btbProfitChange);
            this.ControlPanel.Controls.Add(this.nudProfitRate);
            this.ControlPanel.Controls.Add(this.nudMaxFixTimes);
            this.ControlPanel.Location = new System.Drawing.Point(351, 175);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(315, 302);
            this.ControlPanel.TabIndex = 6;
            // 
            // btbMaxFixChange
            // 
            this.btbMaxFixChange.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbMaxFixChange.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btbMaxFixChange.Location = new System.Drawing.Point(153, 5);
            this.btbMaxFixChange.Name = "btbMaxFixChange";
            this.btbMaxFixChange.Size = new System.Drawing.Size(148, 34);
            this.btbMaxFixChange.TabIndex = 7;
            this.btbMaxFixChange.Text = "Thay đổi";
            this.btbMaxFixChange.UseVisualStyleBackColor = true;
            this.btbMaxFixChange.Click += new System.EventHandler(this.btbMaxFixChange_Click);
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblState.Location = new System.Drawing.Point(153, 246);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(148, 32);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "Không cho phép";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btbToggleChange
            // 
            this.btbToggleChange.Location = new System.Drawing.Point(13, 249);
            this.btbToggleChange.MinimumSize = new System.Drawing.Size(45, 22);
            this.btbToggleChange.Name = "btbToggleChange";
            this.btbToggleChange.OffBackColor = System.Drawing.Color.DarkGray;
            this.btbToggleChange.OffToggleColor = System.Drawing.Color.IndianRed;
            this.btbToggleChange.OnBackColor = System.Drawing.Color.DodgerBlue;
            this.btbToggleChange.OnToggleColor = System.Drawing.Color.DarkBlue;
            this.btbToggleChange.Size = new System.Drawing.Size(110, 30);
            this.btbToggleChange.TabIndex = 7;
            this.btbToggleChange.UseVisualStyleBackColor = true;
            this.btbToggleChange.CheckedChanged += new System.EventHandler(this.btbToggleChange_CheckedChanged);
            this.btbToggleChange.Click += new System.EventHandler(this.btbToggleChange_Click);
            // 
            // btbProfitChange
            // 
            this.btbProfitChange.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbProfitChange.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btbProfitChange.Location = new System.Drawing.Point(153, 127);
            this.btbProfitChange.Name = "btbProfitChange";
            this.btbProfitChange.Size = new System.Drawing.Size(148, 34);
            this.btbProfitChange.TabIndex = 8;
            this.btbProfitChange.Text = "Thay đổi";
            this.btbProfitChange.UseVisualStyleBackColor = true;
            this.btbProfitChange.Click += new System.EventHandler(this.btbProfitChange_Click);
            // 
            // nudProfitRate
            // 
            this.nudProfitRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProfitRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudProfitRate.Location = new System.Drawing.Point(13, 130);
            this.nudProfitRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProfitRate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudProfitRate.Name = "nudProfitRate";
            this.nudProfitRate.Size = new System.Drawing.Size(110, 30);
            this.nudProfitRate.TabIndex = 6;
            this.nudProfitRate.ThousandsSeparator = true;
            this.nudProfitRate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudMaxFixTimes
            // 
            this.nudMaxFixTimes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxFixTimes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudMaxFixTimes.Location = new System.Drawing.Point(13, 7);
            this.nudMaxFixTimes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxFixTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxFixTimes.Name = "nudMaxFixTimes";
            this.nudMaxFixTimes.Size = new System.Drawing.Size(110, 30);
            this.nudMaxFixTimes.TabIndex = 5;
            this.nudMaxFixTimes.ThousandsSeparator = true;
            this.nudMaxFixTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cho phép tiền thu vượt quá tiền nợ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tỷ lệ phần trăm giá phụ tùng bán ra";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số xe sữa chữa tối đa trong ngày";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_policy_document_30;
            this.pictureBox1.Location = new System.Drawing.Point(297, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quy định";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.toggleNotiGeneRal);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.toggleNotiData);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(724, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 184);
            this.panel2.TabIndex = 1;
            // 
            // toggleNotiGeneRal
            // 
            this.toggleNotiGeneRal.Location = new System.Drawing.Point(204, 125);
            this.toggleNotiGeneRal.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleNotiGeneRal.Name = "toggleNotiGeneRal";
            this.toggleNotiGeneRal.OffBackColor = System.Drawing.Color.DarkGray;
            this.toggleNotiGeneRal.OffToggleColor = System.Drawing.Color.IndianRed;
            this.toggleNotiGeneRal.OnBackColor = System.Drawing.Color.DodgerBlue;
            this.toggleNotiGeneRal.OnToggleColor = System.Drawing.Color.DarkBlue;
            this.toggleNotiGeneRal.Size = new System.Drawing.Size(110, 30);
            this.toggleNotiGeneRal.TabIndex = 10;
            this.toggleNotiGeneRal.UseVisualStyleBackColor = true;
            this.toggleNotiGeneRal.CheckedChanged += new System.EventHandler(this.toggleNotiGeneRal_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Thông báo chung";
            // 
            // toggleNotiData
            // 
            this.toggleNotiData.Location = new System.Drawing.Point(204, 65);
            this.toggleNotiData.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleNotiData.Name = "toggleNotiData";
            this.toggleNotiData.OffBackColor = System.Drawing.Color.DarkGray;
            this.toggleNotiData.OffToggleColor = System.Drawing.Color.IndianRed;
            this.toggleNotiData.OnBackColor = System.Drawing.Color.DodgerBlue;
            this.toggleNotiData.OnToggleColor = System.Drawing.Color.DarkBlue;
            this.toggleNotiData.Size = new System.Drawing.Size(110, 30);
            this.toggleNotiData.TabIndex = 8;
            this.toggleNotiData.UseVisualStyleBackColor = true;
            this.toggleNotiData.CheckedChanged += new System.EventHandler(this.toggleNotiData_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thông báo dữ liệu";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cài đặt";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(724, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 346);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(100, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Link  github";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(98, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Click Vào đây";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(89, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "--------Hoặc-------";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(80, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "Bản lưu hành cục bộ";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 38);
            this.label12.TabIndex = 12;
            this.label12.Text = "Mọi thắc mắc xin liên hệ qua \r\nemail: 21521109@gm.uit.edu.vn";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Được phát triển bởi nhóm 8";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(119, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Phiên bản 1.0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(350, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Phần mềm quản lý Gara oto\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PolicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1107, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PolicyForm";
            this.Text = "PolicyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PolicyForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudProfitRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxFixTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.NumericUpDown nudProfitRate;
        private System.Windows.Forms.NumericUpDown nudMaxFixTimes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControl.ToggleButton btbToggleChange;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btbProfitChange;
        private System.Windows.Forms.Button btbMaxFixChange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomControl.ToggleButton toggleNotiData;
        private System.Windows.Forms.Label label7;
        private CustomControl.ToggleButton toggleNotiGeneRal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
    }
}