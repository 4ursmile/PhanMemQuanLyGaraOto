namespace PhanMemQuanLyGaraOto.SubForm
{
    partial class CustomerForm
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.btbDelete = new System.Windows.Forms.Panel();
            this.dgvCustomer = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbcSearchSDT = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btbCancel = new System.Windows.Forms.Button();
            this.btbDelete2 = new System.Windows.Forms.Button();
            this.btbAdd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDIACHI = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHOTEN = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtCID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.mACHUXEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENCHUXEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIENTHOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUXEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btbDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbcSearchSDT)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUXEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Danh sách khách hàng";
            // 
            // btbDelete
            // 
            this.btbDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btbDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btbDelete.Controls.Add(this.dgvCustomer);
            this.btbDelete.Location = new System.Drawing.Point(432, 55);
            this.btbDelete.Name = "btbDelete";
            this.btbDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btbDelete.Size = new System.Drawing.Size(663, 542);
            this.btbDelete.TabIndex = 5;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mACHUXEDataGridViewTextBoxColumn,
            this.tENCHUXEDataGridViewTextBoxColumn,
            this.dIENTHOAIDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.xEsDataGridViewTextBoxColumn});
            this.dgvCustomer.DataSource = this.cHUXEBindingSource;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvCustomer.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.dgvCustomer.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgvCustomer.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgvCustomer.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgvCustomer.Location = new System.Drawing.Point(5, 5);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 30;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(651, 530);
            this.dgvCustomer.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvCustomer.StateCommon.Background.Color2 = System.Drawing.Color.WhiteSmoke;
            this.dgvCustomer.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.dgvCustomer.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.dgvCustomer.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvCustomer.StateCommon.DataCell.Border.Rounding = 5;
            this.dgvCustomer.StateCommon.DataCell.Border.Width = 1;
            this.dgvCustomer.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.dgvCustomer.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.dgvCustomer.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.dgvCustomer.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvCustomer.StateCommon.HeaderColumn.Border.Rounding = 3;
            this.dgvCustomer.StateCommon.HeaderColumn.Border.Width = 1;
            this.dgvCustomer.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvCustomer.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.dgvCustomer.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.dgvCustomer.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvCustomer.StateCommon.HeaderRow.Border.Rounding = 5;
            this.dgvCustomer.StateCommon.HeaderRow.Border.Width = 1;
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustomer_CellMouseClick);
            this.dgvCustomer.SelectionChanged += new System.EventHandler(this.dgvCustomer_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbcSearchSDT);
            this.panel2.Location = new System.Drawing.Point(21, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 69);
            this.panel2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(44, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tìm kiếm theo số điẹn thoại";
            // 
            // cbcSearchSDT
            // 
            this.cbcSearchSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbcSearchSDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbcSearchSDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcSearchSDT.DropDownWidth = 266;
            this.cbcSearchSDT.FormattingEnabled = true;
            this.cbcSearchSDT.Location = new System.Drawing.Point(35, 23);
            this.cbcSearchSDT.Name = "cbcSearchSDT";
            this.cbcSearchSDT.Size = new System.Drawing.Size(331, 29);
            this.cbcSearchSDT.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.DimGray;
            this.cbcSearchSDT.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbcSearchSDT.StateCommon.ComboBox.Border.Rounding = 5;
            this.cbcSearchSDT.StateCommon.ComboBox.Border.Width = 2;
            this.cbcSearchSDT.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcSearchSDT.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thông tin chi tiết";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(21, 130);
            this.panel3.MinimumSize = new System.Drawing.Size(300, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 467);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.flowLayoutPanel2);
            this.panel5.Location = new System.Drawing.Point(13, 403);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 47);
            this.panel5.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.btbCancel);
            this.flowLayoutPanel2.Controls.Add(this.btbDelete2);
            this.flowLayoutPanel2.Controls.Add(this.btbAdd);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(368, 47);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btbCancel
            // 
            this.btbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbCancel.AutoSize = true;
            this.btbCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btbCancel.Location = new System.Drawing.Point(239, 3);
            this.btbCancel.Name = "btbCancel";
            this.btbCancel.Size = new System.Drawing.Size(126, 35);
            this.btbCancel.TabIndex = 7;
            this.btbCancel.Text = "Hủy bỏ";
            this.btbCancel.UseVisualStyleBackColor = true;
            this.btbCancel.Click += new System.EventHandler(this.btbCancel_Click);
            // 
            // btbDelete2
            // 
            this.btbDelete2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btbDelete2.AutoSize = true;
            this.btbDelete2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btbDelete2.Location = new System.Drawing.Point(135, 3);
            this.btbDelete2.MaximumSize = new System.Drawing.Size(210, 50);
            this.btbDelete2.Name = "btbDelete2";
            this.btbDelete2.Size = new System.Drawing.Size(98, 35);
            this.btbDelete2.TabIndex = 6;
            this.btbDelete2.Text = "Xóa";
            this.btbDelete2.UseVisualStyleBackColor = true;
            this.btbDelete2.Click += new System.EventHandler(this.btbDelete2_Click);
            // 
            // btbAdd
            // 
            this.btbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btbAdd.AutoSize = true;
            this.btbAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btbAdd.Location = new System.Drawing.Point(19, 3);
            this.btbAdd.Name = "btbAdd";
            this.btbAdd.Size = new System.Drawing.Size(110, 35);
            this.btbAdd.TabIndex = 5;
            this.btbAdd.Text = "Thêm";
            this.btbAdd.UseVisualStyleBackColor = true;
            this.btbAdd.Click += new System.EventHandler(this.btbAdd_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtDIACHI);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtSDT);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtHOTEN);
            this.panel4.Controls.Add(this.lblDisplay);
            this.panel4.Controls.Add(this.txtCID);
            this.panel4.Location = new System.Drawing.Point(13, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 383);
            this.panel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(30, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(21, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 31);
            this.txtEmail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtEmail.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.txtEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Rounding = 5;
            this.txtEmail.StateCommon.Border.Width = 2;
            this.txtEmail.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(30, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ";
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.AllowDrop = true;
            this.txtDIACHI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDIACHI.Location = new System.Drawing.Point(21, 257);
            this.txtDIACHI.MinimumSize = new System.Drawing.Size(0, 70);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(330, 70);
            this.txtDIACHI.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDIACHI.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.txtDIACHI.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDIACHI.StateCommon.Border.Rounding = 5;
            this.txtDIACHI.StateCommon.Border.Width = 2;
            this.txtDIACHI.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDIACHI.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(30, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Location = new System.Drawing.Point(21, 145);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(330, 31);
            this.txtSDT.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSDT.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.txtSDT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSDT.StateCommon.Border.Rounding = 5;
            this.txtSDT.StateCommon.Border.Width = 2;
            this.txtSDT.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(30, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên khách hàng";
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHOTEN.Location = new System.Drawing.Point(21, 82);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(330, 31);
            this.txtHOTEN.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtHOTEN.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.txtHOTEN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtHOTEN.StateCommon.Border.Rounding = 5;
            this.txtHOTEN.StateCommon.Border.Width = 2;
            this.txtHOTEN.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHOTEN.TabIndex = 1;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDisplay.Location = new System.Drawing.Point(30, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(104, 16);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "Mã khách hàng";
            // 
            // txtCID
            // 
            this.txtCID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCID.Enabled = false;
            this.txtCID.Location = new System.Drawing.Point(21, 26);
            this.txtCID.Name = "txtCID";
            this.txtCID.ReadOnly = true;
            this.txtCID.Size = new System.Drawing.Size(330, 31);
            this.txtCID.StateCommon.Back.Color1 = System.Drawing.Color.MistyRose;
            this.txtCID.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.txtCID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCID.StateCommon.Border.Rounding = 5;
            this.txtCID.StateCommon.Border.Width = 2;
            this.txtCID.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCID.TabIndex = 0;
            // 
            // mACHUXEDataGridViewTextBoxColumn
            // 
            this.mACHUXEDataGridViewTextBoxColumn.DataPropertyName = "MACHUXE";
            this.mACHUXEDataGridViewTextBoxColumn.HeaderText = "CID";
            this.mACHUXEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mACHUXEDataGridViewTextBoxColumn.Name = "mACHUXEDataGridViewTextBoxColumn";
            this.mACHUXEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mACHUXEDataGridViewTextBoxColumn.Width = 50;
            // 
            // tENCHUXEDataGridViewTextBoxColumn
            // 
            this.tENCHUXEDataGridViewTextBoxColumn.DataPropertyName = "TENCHUXE";
            this.tENCHUXEDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.tENCHUXEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENCHUXEDataGridViewTextBoxColumn.Name = "tENCHUXEDataGridViewTextBoxColumn";
            this.tENCHUXEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tENCHUXEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dIENTHOAIDataGridViewTextBoxColumn
            // 
            this.dIENTHOAIDataGridViewTextBoxColumn.DataPropertyName = "DIENTHOAI";
            this.dIENTHOAIDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.dIENTHOAIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIENTHOAIDataGridViewTextBoxColumn.Name = "dIENTHOAIDataGridViewTextBoxColumn";
            this.dIENTHOAIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIENTHOAIDataGridViewTextBoxColumn.Width = 90;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMAILDataGridViewTextBoxColumn.Width = 90;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.dIACHIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xEsDataGridViewTextBoxColumn
            // 
            this.xEsDataGridViewTextBoxColumn.DataPropertyName = "XEs";
            this.xEsDataGridViewTextBoxColumn.HeaderText = "XEs";
            this.xEsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xEsDataGridViewTextBoxColumn.Name = "xEsDataGridViewTextBoxColumn";
            this.xEsDataGridViewTextBoxColumn.ReadOnly = true;
            this.xEsDataGridViewTextBoxColumn.Visible = false;
            this.xEsDataGridViewTextBoxColumn.Width = 125;
            // 
            // cHUXEBindingSource
            // 
            this.cHUXEBindingSource.DataSource = typeof(PhanMemQuanLyGaraOto.Model.CHUXE);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btbDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.btbDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbcSearchSDT)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUXEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel btbDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACHUXEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENCHUXEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIENTHOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cHUXEBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbcSearchSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btbCancel;
        private System.Windows.Forms.Button btbDelete2;
        private System.Windows.Forms.Button btbAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDIACHI;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtHOTEN;
        private System.Windows.Forms.Label lblDisplay;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCID;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
    }
}