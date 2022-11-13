namespace PhanMemQuanLyGaraOto
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DockPanel = new System.Windows.Forms.Panel();
            this.AvatarPanel = new System.Windows.Forms.Panel();
            this.DesLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.AvatarPic = new System.Windows.Forms.PictureBox();
            this.AccountButton = new System.Windows.Forms.Button();
            this.Carbutton = new System.Windows.Forms.Button();
            this.RepairButton = new System.Windows.Forms.Button();
            this.BillButton = new System.Windows.Forms.Button();
            this.ToolButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.PolicyButton = new System.Windows.Forms.Button();
            this.DockPanel.SuspendLayout();
            this.AvatarPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPic)).BeginInit();
            this.SuspendLayout();
            // 
            // DockPanel
            // 
            this.DockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DockPanel.AutoSize = true;
            this.DockPanel.BackColor = System.Drawing.Color.White;
            this.DockPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DockPanel.Controls.Add(this.AvatarPanel);
            this.DockPanel.Controls.Add(this.flowLayoutPanel1);
            this.DockPanel.Location = new System.Drawing.Point(0, 0);
            this.DockPanel.Name = "DockPanel";
            this.DockPanel.Size = new System.Drawing.Size(154, 660);
            this.DockPanel.TabIndex = 0;
            // 
            // AvatarPanel
            // 
            this.AvatarPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AvatarPanel.Controls.Add(this.DesLabel);
            this.AvatarPanel.Controls.Add(this.NameLabel);
            this.AvatarPanel.Controls.Add(this.AvatarPic);
            this.AvatarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AvatarPanel.Location = new System.Drawing.Point(0, 0);
            this.AvatarPanel.Name = "AvatarPanel";
            this.AvatarPanel.Size = new System.Drawing.Size(152, 156);
            this.AvatarPanel.TabIndex = 0;
            // 
            // DesLabel
            // 
            this.DesLabel.AutoSize = true;
            this.DesLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DesLabel.Location = new System.Drawing.Point(47, 130);
            this.DesLabel.Name = "DesLabel";
            this.DesLabel.Size = new System.Drawing.Size(51, 16);
            this.DesLabel.TabIndex = 2;
            this.DesLabel.Text = "Quản lý";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(46, 110);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 18);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Bảo Ly";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.AccountButton);
            this.flowLayoutPanel1.Controls.Add(this.Carbutton);
            this.flowLayoutPanel1.Controls.Add(this.RepairButton);
            this.flowLayoutPanel1.Controls.Add(this.BillButton);
            this.flowLayoutPanel1.Controls.Add(this.ToolButton);
            this.flowLayoutPanel1.Controls.Add(this.ReportButton);
            this.flowLayoutPanel1.Controls.Add(this.PolicyButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 162);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(146, 493);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.Location = new System.Drawing.Point(155, 75);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(907, 534);
            this.MainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.FormNameLabel);
            this.panel1.Location = new System.Drawing.Point(170, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 57);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNameLabel.Location = new System.Drawing.Point(18, 10);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(170, 38);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Tài khoản";
            this.FormNameLabel.Click += new System.EventHandler(this.FormNameLabel_Click);
            // 
            // AvatarPic
            // 
            this.AvatarPic.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.ManagerAvatat;
            this.AvatarPic.Location = new System.Drawing.Point(30, 12);
            this.AvatarPic.Name = "AvatarPic";
            this.AvatarPic.Size = new System.Drawing.Size(92, 90);
            this.AvatarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarPic.TabIndex = 0;
            this.AvatarPic.TabStop = false;
            this.AvatarPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccountButton.FlatAppearance.BorderSize = 0;
            this.AccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.AccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.ForeColor = System.Drawing.Color.Black;
            this.AccountButton.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_account_24;
            this.AccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountButton.Location = new System.Drawing.Point(3, 3);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.AccountButton.Size = new System.Drawing.Size(145, 49);
            this.AccountButton.TabIndex = 4;
            this.AccountButton.Text = "Tài khoản";
            this.AccountButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AccountButton.UseVisualStyleBackColor = false;
            this.AccountButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // Carbutton
            // 
            this.Carbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Carbutton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Carbutton.FlatAppearance.BorderSize = 0;
            this.Carbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.Carbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Carbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Carbutton.ForeColor = System.Drawing.Color.Black;
            this.Carbutton.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_garage_26;
            this.Carbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Carbutton.Location = new System.Drawing.Point(3, 58);
            this.Carbutton.Name = "Carbutton";
            this.Carbutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Carbutton.Size = new System.Drawing.Size(145, 49);
            this.Carbutton.TabIndex = 5;
            this.Carbutton.Text = "Tiếp nhận xe";
            this.Carbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Carbutton.UseVisualStyleBackColor = false;
            this.Carbutton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // RepairButton
            // 
            this.RepairButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepairButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RepairButton.FlatAppearance.BorderSize = 0;
            this.RepairButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.RepairButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.RepairButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepairButton.ForeColor = System.Drawing.Color.Black;
            this.RepairButton.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_car_production_30;
            this.RepairButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RepairButton.Location = new System.Drawing.Point(3, 113);
            this.RepairButton.Name = "RepairButton";
            this.RepairButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.RepairButton.Size = new System.Drawing.Size(145, 49);
            this.RepairButton.TabIndex = 9;
            this.RepairButton.Text = "Sữa chữa";
            this.RepairButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RepairButton.UseVisualStyleBackColor = false;
            this.RepairButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // BillButton
            // 
            this.BillButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BillButton.FlatAppearance.BorderSize = 0;
            this.BillButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.BillButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillButton.ForeColor = System.Drawing.Color.Black;
            this.BillButton.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_invoice_24;
            this.BillButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BillButton.Location = new System.Drawing.Point(3, 168);
            this.BillButton.Name = "BillButton";
            this.BillButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BillButton.Size = new System.Drawing.Size(145, 49);
            this.BillButton.TabIndex = 6;
            this.BillButton.Text = "Hóa đơn";
            this.BillButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BillButton.UseVisualStyleBackColor = false;
            this.BillButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // ToolButton
            // 
            this.ToolButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToolButton.FlatAppearance.BorderSize = 0;
            this.ToolButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.ToolButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.ToolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolButton.ForeColor = System.Drawing.Color.Black;
            this.ToolButton.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_tool_64;
            this.ToolButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolButton.Location = new System.Drawing.Point(3, 223);
            this.ToolButton.Name = "ToolButton";
            this.ToolButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ToolButton.Size = new System.Drawing.Size(145, 49);
            this.ToolButton.TabIndex = 7;
            this.ToolButton.Text = "Linh kiện";
            this.ToolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolButton.UseVisualStyleBackColor = false;
            this.ToolButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.ReportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.ForeColor = System.Drawing.Color.Black;
            this.ReportButton.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_slice_30;
            this.ReportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportButton.Location = new System.Drawing.Point(3, 278);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ReportButton.Size = new System.Drawing.Size(145, 49);
            this.ReportButton.TabIndex = 10;
            this.ReportButton.Text = "Báo cáo";
            this.ReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReportButton.UseVisualStyleBackColor = false;
            // 
            // PolicyButton
            // 
            this.PolicyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PolicyButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PolicyButton.FlatAppearance.BorderSize = 0;
            this.PolicyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.PolicyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.PolicyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PolicyButton.ForeColor = System.Drawing.Color.Black;
            this.PolicyButton.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_policy_document_30;
            this.PolicyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PolicyButton.Location = new System.Drawing.Point(3, 333);
            this.PolicyButton.Name = "PolicyButton";
            this.PolicyButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.PolicyButton.Size = new System.Drawing.Size(145, 49);
            this.PolicyButton.TabIndex = 8;
            this.PolicyButton.Text = "Quy định";
            this.PolicyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PolicyButton.UseVisualStyleBackColor = false;
            this.PolicyButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1062, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.DockPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.DockPanel.ResumeLayout(false);
            this.AvatarPanel.ResumeLayout(false);
            this.AvatarPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DockPanel;
        private System.Windows.Forms.Panel AvatarPanel;
        private System.Windows.Forms.PictureBox AvatarPic;
        private System.Windows.Forms.Label DesLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button Carbutton;
        private System.Windows.Forms.Button BillButton;
        private System.Windows.Forms.Button ToolButton;
        private System.Windows.Forms.Button PolicyButton;
        private System.Windows.Forms.Button RepairButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.Button ReportButton;
    }
}