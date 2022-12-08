namespace PhanMemQuanLyGaraOto.SubForm
{
    partial class AccountForm
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
            this.tabcAccount = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btbInfo = new System.Windows.Forms.Button();
            this.btbChangePass = new System.Windows.Forms.Button();
            this.btbLogout = new System.Windows.Forms.Button();
            this.btbExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtDes = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabcAccount.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcAccount
            // 
            this.tabcAccount.Controls.Add(this.tabPage1);
            this.tabcAccount.Controls.Add(this.tabPage2);
            this.tabcAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcAccount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcAccount.ItemSize = new System.Drawing.Size(200, 30);
            this.tabcAccount.Location = new System.Drawing.Point(0, 0);
            this.tabcAccount.Name = "tabcAccount";
            this.tabcAccount.SelectedIndex = 0;
            this.tabcAccount.Size = new System.Drawing.Size(1020, 576);
            this.tabcAccount.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tài khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btbInfo);
            this.flowLayoutPanel1.Controls.Add(this.btbChangePass);
            this.flowLayoutPanel1.Controls.Add(this.btbLogout);
            this.flowLayoutPanel1.Controls.Add(this.btbExit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(836, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 522);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btbInfo
            // 
            this.btbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbInfo.BackColor = System.Drawing.Color.White;
            this.btbInfo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbInfo.Location = new System.Drawing.Point(3, 3);
            this.btbInfo.Name = "btbInfo";
            this.btbInfo.Size = new System.Drawing.Size(170, 41);
            this.btbInfo.TabIndex = 0;
            this.btbInfo.Text = "Cập nhật thông tin";
            this.btbInfo.UseVisualStyleBackColor = false;
            this.btbInfo.Click += new System.EventHandler(this.btbInfo_Click);
            // 
            // btbChangePass
            // 
            this.btbChangePass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbChangePass.BackColor = System.Drawing.Color.White;
            this.btbChangePass.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbChangePass.Location = new System.Drawing.Point(3, 50);
            this.btbChangePass.Name = "btbChangePass";
            this.btbChangePass.Size = new System.Drawing.Size(170, 41);
            this.btbChangePass.TabIndex = 1;
            this.btbChangePass.Text = "Thay đổi mật khẩu\r\n";
            this.btbChangePass.UseVisualStyleBackColor = false;
            this.btbChangePass.Click += new System.EventHandler(this.btbChangePass_Click);
            // 
            // btbLogout
            // 
            this.btbLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbLogout.BackColor = System.Drawing.Color.White;
            this.btbLogout.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbLogout.Location = new System.Drawing.Point(3, 97);
            this.btbLogout.Name = "btbLogout";
            this.btbLogout.Size = new System.Drawing.Size(170, 41);
            this.btbLogout.TabIndex = 3;
            this.btbLogout.Text = "Đăng xuất";
            this.btbLogout.UseVisualStyleBackColor = false;
            this.btbLogout.Click += new System.EventHandler(this.btbLogout_Click);
            // 
            // btbExit
            // 
            this.btbExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbExit.BackColor = System.Drawing.Color.White;
            this.btbExit.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbExit.Location = new System.Drawing.Point(3, 144);
            this.btbExit.Name = "btbExit";
            this.btbExit.Size = new System.Drawing.Size(170, 41);
            this.btbExit.TabIndex = 2;
            this.btbExit.Text = "Đóng chương trình";
            this.btbExit.UseVisualStyleBackColor = false;
            this.btbExit.Click += new System.EventHandler(this.btbExit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.txtDes);
            this.panel1.Controls.Add(this.txtDisplayName);
            this.panel1.Controls.Add(this.txtPos);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 523);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::PhanMemQuanLyGaraOto.Properties.Resources._44_443617_coming_soon_blue_png_transparent_png;
            this.pictureBox3.Location = new System.Drawing.Point(1, 501);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(807, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // txtDes
            // 
            this.txtDes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDes.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDes.Location = new System.Drawing.Point(100, 457);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(609, 47);
            this.txtDes.TabIndex = 4;
            this.txtDes.Text = "Quản lý";
            this.txtDes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplayName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.Location = new System.Drawing.Point(301, 392);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(208, 30);
            this.txtDisplayName.TabIndex = 2;
            this.txtDisplayName.Text = "Bảo Ly";
            this.txtDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDisplayName.Click += new System.EventHandler(this.txtDisplayName_Click);
            // 
            // txtPos
            // 
            this.txtPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPos.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtPos.Location = new System.Drawing.Point(302, 422);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(208, 30);
            this.txtPos.TabIndex = 3;
            this.txtPos.Text = "Quản lý";
            this.txtPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.ManagerAvatat1;
            this.pictureBox2.Location = new System.Drawing.Point(319, 206);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.sylvain_sarrailh_panoramique2;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(822, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1012, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý tài khoản";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 576);
            this.Controls.Add(this.tabcAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.tabcAccount.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcAccount;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txtDisplayName;
        private System.Windows.Forms.Label txtDes;
        private System.Windows.Forms.Label txtPos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btbInfo;
        private System.Windows.Forms.Button btbLogout;
        private System.Windows.Forms.Button btbExit;
        private System.Windows.Forms.Button btbChangePass;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}