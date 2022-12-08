namespace PhanMemQuanLyGaraOto.SubForm.SubSubForm
{
    partial class ChangePassForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btbSavePassChange = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOld = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNew = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtReNew = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ptbOld = new System.Windows.Forms.PictureBox();
            this.ptbNew = new System.Windows.Forms.PictureBox();
            this.ptbReNew = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReNew)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thay đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập mật khẩu cũ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập mật khẩu mới:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xác nhận lại mật khẩu:\r\n";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ptbReNew);
            this.panel1.Controls.Add(this.ptbNew);
            this.panel1.Controls.Add(this.ptbOld);
            this.panel1.Controls.Add(this.txtReNew);
            this.panel1.Controls.Add(this.txtNew);
            this.panel1.Controls.Add(this.txtOld);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 180);
            this.panel1.TabIndex = 5;
            // 
            // btbSavePassChange
            // 
            this.btbSavePassChange.BackColor = System.Drawing.Color.White;
            this.btbSavePassChange.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btbSavePassChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btbSavePassChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btbSavePassChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbSavePassChange.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbSavePassChange.Location = new System.Drawing.Point(114, 0);
            this.btbSavePassChange.Name = "btbSavePassChange";
            this.btbSavePassChange.Size = new System.Drawing.Size(132, 35);
            this.btbSavePassChange.TabIndex = 6;
            this.btbSavePassChange.Text = "Cập nhật";
            this.btbSavePassChange.UseVisualStyleBackColor = false;
            this.btbSavePassChange.Click += new System.EventHandler(this.btbSavePassChange_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUserName.Location = new System.Drawing.Point(262, 91);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(45, 19);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.Text = "anoy";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(288, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hủy bỏ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btbSavePassChange);
            this.panel2.Location = new System.Drawing.Point(-2, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 38);
            this.panel2.TabIndex = 9;
            // 
            // txtOld
            // 
            this.txtOld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOld.Location = new System.Drawing.Point(202, 16);
            this.txtOld.Name = "txtOld";
            this.txtOld.PasswordChar = '•';
            this.txtOld.Size = new System.Drawing.Size(325, 31);
            this.txtOld.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtOld.StateCommon.Border.Rounding = 6;
            this.txtOld.TabIndex = 5;
            // 
            // txtNew
            // 
            this.txtNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNew.Location = new System.Drawing.Point(202, 69);
            this.txtNew.Name = "txtNew";
            this.txtNew.PasswordChar = '•';
            this.txtNew.Size = new System.Drawing.Size(325, 31);
            this.txtNew.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNew.StateCommon.Border.Rounding = 6;
            this.txtNew.TabIndex = 6;
            // 
            // txtReNew
            // 
            this.txtReNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReNew.Location = new System.Drawing.Point(202, 118);
            this.txtReNew.Name = "txtReNew";
            this.txtReNew.PasswordChar = '•';
            this.txtReNew.Size = new System.Drawing.Size(325, 31);
            this.txtReNew.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtReNew.StateCommon.Border.Rounding = 6;
            this.txtReNew.TabIndex = 7;
            this.txtReNew.TextChanged += new System.EventHandler(this.txtReNew_TextChanged);
            // 
            // ptbOld
            // 
            this.ptbOld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbOld.BackColor = System.Drawing.Color.White;
            this.ptbOld.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_uchiha_eyes_24;
            this.ptbOld.Location = new System.Drawing.Point(499, 20);
            this.ptbOld.Name = "ptbOld";
            this.ptbOld.Size = new System.Drawing.Size(25, 23);
            this.ptbOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbOld.TabIndex = 8;
            this.ptbOld.TabStop = false;
            this.ptbOld.Click += new System.EventHandler(this.ptbOld_Click);
            // 
            // ptbNew
            // 
            this.ptbNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbNew.BackColor = System.Drawing.Color.White;
            this.ptbNew.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_uchiha_eyes_24;
            this.ptbNew.Location = new System.Drawing.Point(499, 73);
            this.ptbNew.Name = "ptbNew";
            this.ptbNew.Size = new System.Drawing.Size(25, 23);
            this.ptbNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNew.TabIndex = 9;
            this.ptbNew.TabStop = false;
            this.ptbNew.Click += new System.EventHandler(this.ptbNew_Click);
            // 
            // ptbReNew
            // 
            this.ptbReNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbReNew.BackColor = System.Drawing.Color.White;
            this.ptbReNew.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_uchiha_eyes_24;
            this.ptbReNew.Location = new System.Drawing.Point(499, 122);
            this.ptbReNew.Name = "ptbReNew";
            this.ptbReNew.Size = new System.Drawing.Size(25, 23);
            this.ptbReNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbReNew.TabIndex = 10;
            this.ptbReNew.TabStop = false;
            this.ptbReNew.Click += new System.EventHandler(this.ptbReNew_Click);
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangePassForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btbSavePassChange;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOld;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtReNew;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNew;
        private System.Windows.Forms.PictureBox ptbOld;
        private System.Windows.Forms.PictureBox ptbReNew;
        private System.Windows.Forms.PictureBox ptbNew;
    }
}