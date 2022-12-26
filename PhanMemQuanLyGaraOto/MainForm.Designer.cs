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
            this.AvatarPic = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AccountButton = new System.Windows.Forms.Button();
            this.Carbutton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.BrandButton = new System.Windows.Forms.Button();
            this.ToolButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.PolicyButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đếnTrangXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiếpNhậnXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điĐếnTrangCàiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệHỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DockPanel.SuspendLayout();
            this.AvatarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPic)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.DockPanel.Location = new System.Drawing.Point(0, 27);
            this.DockPanel.Name = "DockPanel";
            this.DockPanel.Size = new System.Drawing.Size(154, 696);
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
            this.DesLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DesLabel.Location = new System.Drawing.Point(15, 128);
            this.DesLabel.Name = "DesLabel";
            this.DesLabel.Size = new System.Drawing.Size(112, 28);
            this.DesLabel.TabIndex = 2;
            this.DesLabel.Text = "Quản lý";
            this.DesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(0, 110);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(148, 18);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Bảo Ly";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.AccountButton);
            this.flowLayoutPanel1.Controls.Add(this.Carbutton);
            this.flowLayoutPanel1.Controls.Add(this.CustomerButton);
            this.flowLayoutPanel1.Controls.Add(this.BrandButton);
            this.flowLayoutPanel1.Controls.Add(this.ToolButton);
            this.flowLayoutPanel1.Controls.Add(this.ReportButton);
            this.flowLayoutPanel1.Controls.Add(this.PolicyButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 162);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(146, 529);
            this.flowLayoutPanel1.TabIndex = 1;
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
            this.Carbutton.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_car_production_30;
            this.Carbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Carbutton.Location = new System.Drawing.Point(3, 58);
            this.Carbutton.Name = "Carbutton";
            this.Carbutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Carbutton.Size = new System.Drawing.Size(145, 49);
            this.Carbutton.TabIndex = 5;
            this.Carbutton.Text = "Xe";
            this.Carbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Carbutton.UseVisualStyleBackColor = false;
            this.Carbutton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerButton.FlatAppearance.BorderSize = 0;
            this.CustomerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.CustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.CustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerButton.ForeColor = System.Drawing.Color.Black;
            this.CustomerButton.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_customer_24;
            this.CustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerButton.Location = new System.Drawing.Point(3, 113);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CustomerButton.Size = new System.Drawing.Size(145, 49);
            this.CustomerButton.TabIndex = 9;
            this.CustomerButton.Text = "Khách hàng";
            this.CustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomerButton.UseVisualStyleBackColor = false;
            this.CustomerButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // BrandButton
            // 
            this.BrandButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrandButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BrandButton.FlatAppearance.BorderSize = 0;
            this.BrandButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.BrandButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BrandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrandButton.ForeColor = System.Drawing.Color.Black;
            this.BrandButton.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.icons8_garage_26;
            this.BrandButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrandButton.Location = new System.Drawing.Point(3, 168);
            this.BrandButton.Name = "BrandButton";
            this.BrandButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BrandButton.Size = new System.Drawing.Size(145, 49);
            this.BrandButton.TabIndex = 6;
            this.BrandButton.Text = "Hãng xe";
            this.BrandButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BrandButton.UseVisualStyleBackColor = false;
            this.BrandButton.Click += new System.EventHandler(this.MenuButton_Click);
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
            this.ReportButton.Click += new System.EventHandler(this.MenuButton_Click);
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
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.Location = new System.Drawing.Point(155, 27);
            this.MainPanel.MinimumSize = new System.Drawing.Size(500, 300);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1107, 645);
            this.MainPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.xeToolStripMenuItem,
            this.càiĐặtToolStripMenuItem,
            this.liênHệHỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtThôngTinToolStripMenuItem,
            this.thayĐổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátChươngTrìnhToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật thông tin";
            this.cậpNhậtThôngTinToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThôngTinToolStripMenuItem_Click);
            // 
            // thayĐổiMậtKhẩuToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thayĐổiMậtKhẩuToolStripMenuItem.Text = "Thay đổi mật khẩu";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            this.thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            this.thoátChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátChươngTrìnhToolStripMenuItem.Text = "Thoát chương trình";
            this.thoátChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.thoátChươngTrìnhToolStripMenuItem_Click);
            // 
            // xeToolStripMenuItem
            // 
            this.xeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đếnTrangXeToolStripMenuItem,
            this.tiếpNhậnXeToolStripMenuItem});
            this.xeToolStripMenuItem.Name = "xeToolStripMenuItem";
            this.xeToolStripMenuItem.Size = new System.Drawing.Size(40, 24);
            this.xeToolStripMenuItem.Text = "Xe";
            // 
            // đếnTrangXeToolStripMenuItem
            // 
            this.đếnTrangXeToolStripMenuItem.Name = "đếnTrangXeToolStripMenuItem";
            this.đếnTrangXeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đếnTrangXeToolStripMenuItem.Text = "Đến trang xe";
            this.đếnTrangXeToolStripMenuItem.Click += new System.EventHandler(this.đếnTrangXeToolStripMenuItem_Click);
            // 
            // tiếpNhậnXeToolStripMenuItem
            // 
            this.tiếpNhậnXeToolStripMenuItem.Name = "tiếpNhậnXeToolStripMenuItem";
            this.tiếpNhậnXeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tiếpNhậnXeToolStripMenuItem.Text = "Tiếp nhận xe";
            this.tiếpNhậnXeToolStripMenuItem.Click += new System.EventHandler(this.tiếpNhậnXeToolStripMenuItem_Click);
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.điĐếnTrangCàiĐặtToolStripMenuItem});
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.càiĐặtToolStripMenuItem.Text = "Cài đặt";
            // 
            // điĐếnTrangCàiĐặtToolStripMenuItem
            // 
            this.điĐếnTrangCàiĐặtToolStripMenuItem.Name = "điĐếnTrangCàiĐặtToolStripMenuItem";
            this.điĐếnTrangCàiĐặtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.điĐếnTrangCàiĐặtToolStripMenuItem.Text = "Đi đến phần cài đặt";
            this.điĐếnTrangCàiĐặtToolStripMenuItem.Click += new System.EventHandler(this.điĐếnTrangCàiĐặtToolStripMenuItem_Click);
            // 
            // liênHệHỗTrợToolStripMenuItem
            // 
            this.liênHệHỗTrợToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facebookToolStripMenuItem,
            this.linkedinToolStripMenuItem,
            this.githubToolStripMenuItem});
            this.liênHệHỗTrợToolStripMenuItem.Name = "liênHệHỗTrợToolStripMenuItem";
            this.liênHệHỗTrợToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.liênHệHỗTrợToolStripMenuItem.Text = "Liên hệ hỗ trợ";
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.facebookToolStripMenuItem.Text = "Facebook";
            this.facebookToolStripMenuItem.Click += new System.EventHandler(this.facebookToolStripMenuItem_Click);
            // 
            // linkedinToolStripMenuItem
            // 
            this.linkedinToolStripMenuItem.Name = "linkedinToolStripMenuItem";
            this.linkedinToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.linkedinToolStripMenuItem.Text = "Linkedin";
            this.linkedinToolStripMenuItem.Click += new System.EventHandler(this.linkedinToolStripMenuItem_Click);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.DockPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điều khiển";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DockPanel.ResumeLayout(false);
            this.AvatarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPic)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button BrandButton;
        private System.Windows.Forms.Button ToolButton;
        private System.Windows.Forms.Button PolicyButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đếnTrangXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiếpNhậnXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điĐếnTrangCàiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệHỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
    }
}