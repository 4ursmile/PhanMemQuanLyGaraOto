﻿namespace PhanMemQuanLyGaraOto.SubForm
{
    partial class ToolForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbcTenPT = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btbCANCLEB = new System.Windows.Forms.Button();
            this.btbDELETEB = new System.Windows.Forms.Button();
            this.btbADDB = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenPT = new System.Windows.Forms.TextBox();
            this.nudGiaPT = new System.Windows.Forms.NumericUpDown();
            this.nudSLPT = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPHUTUNG = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonDataGridView2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btbImport = new System.Windows.Forms.Button();
            this.mAPHUTUNGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENPHUTUNGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGTONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAOCAOTONsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHITIETPSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPHIEUNHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHUTUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLPT)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHUTUNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHUTUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.cbcTenPT);
            this.panel8.Location = new System.Drawing.Point(47, 74);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(423, 69);
            this.panel8.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(44, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tìm kiếm theo Tên phụ tùng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbcTenPT
            // 
            this.cbcTenPT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbcTenPT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcTenPT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbcTenPT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcTenPT.FormattingEnabled = true;
            this.cbcTenPT.Location = new System.Drawing.Point(36, 29);
            this.cbcTenPT.Name = "cbcTenPT";
            this.cbcTenPT.Size = new System.Drawing.Size(343, 25);
            this.cbcTenPT.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(505, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Danh sách vật tư phụ tùng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Thông tin chi tiết";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(47, 167);
            this.panel2.MinimumSize = new System.Drawing.Size(300, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 344);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btbCANCLEB);
            this.panel3.Controls.Add(this.btbDELETEB);
            this.panel3.Controls.Add(this.btbADDB);
            this.panel3.Location = new System.Drawing.Point(12, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 46);
            this.panel3.TabIndex = 2;
            // 
            // btbCANCLEB
            // 
            this.btbCANCLEB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbCANCLEB.AutoSize = true;
            this.btbCANCLEB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btbCANCLEB.Location = new System.Drawing.Point(261, 0);
            this.btbCANCLEB.Name = "btbCANCLEB";
            this.btbCANCLEB.Size = new System.Drawing.Size(123, 43);
            this.btbCANCLEB.TabIndex = 2;
            this.btbCANCLEB.Text = "Hủy bỏ";
            this.btbCANCLEB.UseVisualStyleBackColor = true;
            this.btbCANCLEB.Click += new System.EventHandler(this.btbCANCLEB_Click);
            // 
            // btbDELETEB
            // 
            this.btbDELETEB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btbDELETEB.AutoSize = true;
            this.btbDELETEB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btbDELETEB.Location = new System.Drawing.Point(137, 0);
            this.btbDELETEB.MaximumSize = new System.Drawing.Size(210, 50);
            this.btbDELETEB.Name = "btbDELETEB";
            this.btbDELETEB.Size = new System.Drawing.Size(104, 43);
            this.btbDELETEB.TabIndex = 1;
            this.btbDELETEB.Text = "Xóa";
            this.btbDELETEB.UseVisualStyleBackColor = true;
            this.btbDELETEB.Click += new System.EventHandler(this.btbDELETEB_Click);
            // 
            // btbADDB
            // 
            this.btbADDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btbADDB.AutoSize = true;
            this.btbADDB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btbADDB.Location = new System.Drawing.Point(3, 3);
            this.btbADDB.Name = "btbADDB";
            this.btbADDB.Size = new System.Drawing.Size(123, 40);
            this.btbADDB.TabIndex = 0;
            this.btbADDB.Text = "Thêm";
            this.btbADDB.UseVisualStyleBackColor = true;
            this.btbADDB.Click += new System.EventHandler(this.btbADDB_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 300);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.txtTenPT);
            this.panel7.Controls.Add(this.nudGiaPT);
            this.panel7.Controls.Add(this.nudSLPT);
            this.panel7.Location = new System.Drawing.Point(13, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(387, 250);
            this.panel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(30, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số lượng tồn";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(32, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(30, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên phụ tùng";
            // 
            // txtTenPT
            // 
            this.txtTenPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenPT.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPT.Location = new System.Drawing.Point(22, 37);
            this.txtTenPT.MaximumSize = new System.Drawing.Size(1000, 100);
            this.txtTenPT.MinimumSize = new System.Drawing.Size(150, 60);
            this.txtTenPT.Name = "txtTenPT";
            this.txtTenPT.Size = new System.Drawing.Size(343, 28);
            this.txtTenPT.TabIndex = 8;
            // 
            // nudGiaPT
            // 
            this.nudGiaPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGiaPT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGiaPT.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudGiaPT.Location = new System.Drawing.Point(22, 135);
            this.nudGiaPT.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudGiaPT.Name = "nudGiaPT";
            this.nudGiaPT.Size = new System.Drawing.Size(343, 27);
            this.nudGiaPT.TabIndex = 12;
            this.nudGiaPT.ThousandsSeparator = true;
            // 
            // nudSLPT
            // 
            this.nudSLPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSLPT.Enabled = false;
            this.nudSLPT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSLPT.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSLPT.Location = new System.Drawing.Point(22, 207);
            this.nudSLPT.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSLPT.Name = "nudSLPT";
            this.nudSLPT.Size = new System.Drawing.Size(343, 27);
            this.nudSLPT.TabIndex = 13;
            this.nudSLPT.ThousandsSeparator = true;
            this.nudSLPT.ValueChanged += new System.EventHandler(this.nudSLPT_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvPHUTUNG);
            this.panel1.Controls.Add(this.kryptonDataGridView2);
            this.panel1.Location = new System.Drawing.Point(497, 74);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(572, 526);
            this.panel1.TabIndex = 8;
            // 
            // dgvPHUTUNG
            // 
            this.dgvPHUTUNG.AutoGenerateColumns = false;
            this.dgvPHUTUNG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPHUTUNG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPHUTUNGDataGridViewTextBoxColumn,
            this.tENPHUTUNGDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.sOLUONGTONDataGridViewTextBoxColumn,
            this.bAOCAOTONsDataGridViewTextBoxColumn,
            this.cHITIETPSCDataGridViewTextBoxColumn,
            this.cTPHIEUNHAPDataGridViewTextBoxColumn});
            this.dgvPHUTUNG.DataSource = this.pHUTUNGBindingSource;
            this.dgvPHUTUNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPHUTUNG.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvPHUTUNG.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.dgvPHUTUNG.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgvPHUTUNG.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgvPHUTUNG.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgvPHUTUNG.Location = new System.Drawing.Point(5, 5);
            this.dgvPHUTUNG.Name = "dgvPHUTUNG";
            this.dgvPHUTUNG.ReadOnly = true;
            this.dgvPHUTUNG.RowHeadersWidth = 30;
            this.dgvPHUTUNG.RowTemplate.Height = 24;
            this.dgvPHUTUNG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPHUTUNG.Size = new System.Drawing.Size(560, 514);
            this.dgvPHUTUNG.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvPHUTUNG.StateCommon.Background.Color2 = System.Drawing.Color.WhiteSmoke;
            this.dgvPHUTUNG.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.dgvPHUTUNG.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.dgvPHUTUNG.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvPHUTUNG.StateCommon.DataCell.Border.Rounding = 0;
            this.dgvPHUTUNG.StateCommon.DataCell.Border.Width = 1;
            this.dgvPHUTUNG.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.dgvPHUTUNG.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.dgvPHUTUNG.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.dgvPHUTUNG.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvPHUTUNG.StateCommon.HeaderColumn.Border.Rounding = 0;
            this.dgvPHUTUNG.StateCommon.HeaderColumn.Border.Width = 1;
            this.dgvPHUTUNG.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPHUTUNG.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvPHUTUNG.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.dgvPHUTUNG.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.dgvPHUTUNG.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvPHUTUNG.StateCommon.HeaderRow.Border.Rounding = 0;
            this.dgvPHUTUNG.StateCommon.HeaderRow.Border.Width = 1;
            this.dgvPHUTUNG.TabIndex = 9;
            this.dgvPHUTUNG.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPHUTUNG_CellMouseClick);
            this.dgvPHUTUNG.SelectionChanged += new System.EventHandler(this.dgvPHUTUNG_SelectionChanged);
            // 
            // kryptonDataGridView2
            // 
            this.kryptonDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView2.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.kryptonDataGridView2.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.kryptonDataGridView2.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kryptonDataGridView2.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kryptonDataGridView2.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kryptonDataGridView2.Location = new System.Drawing.Point(5, 5);
            this.kryptonDataGridView2.Name = "kryptonDataGridView2";
            this.kryptonDataGridView2.ReadOnly = true;
            this.kryptonDataGridView2.RowHeadersWidth = 30;
            this.kryptonDataGridView2.RowTemplate.Height = 24;
            this.kryptonDataGridView2.Size = new System.Drawing.Size(560, 514);
            this.kryptonDataGridView2.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView2.StateCommon.Background.Color2 = System.Drawing.Color.WhiteSmoke;
            this.kryptonDataGridView2.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.kryptonDataGridView2.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView2.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView2.StateCommon.DataCell.Border.Rounding = 5;
            this.kryptonDataGridView2.StateCommon.DataCell.Border.Width = 1;
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Border.Rounding = 3;
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Border.Width = 1;
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDataGridView2.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView2.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView2.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView2.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView2.StateCommon.HeaderRow.Border.Rounding = 5;
            this.kryptonDataGridView2.StateCommon.HeaderRow.Border.Width = 1;
            this.kryptonDataGridView2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btbImport);
            this.panel4.Location = new System.Drawing.Point(48, 532);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(421, 67);
            this.panel4.TabIndex = 13;
            // 
            // btbImport
            // 
            this.btbImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btbImport.AutoSize = true;
            this.btbImport.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btbImport.FlatAppearance.BorderSize = 2;
            this.btbImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btbImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btbImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbImport.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbImport.Location = new System.Drawing.Point(21, 15);
            this.btbImport.Name = "btbImport";
            this.btbImport.Size = new System.Drawing.Size(375, 40);
            this.btbImport.TabIndex = 1;
            this.btbImport.Text = "Nhập Hàng";
            this.btbImport.UseVisualStyleBackColor = true;
            this.btbImport.Click += new System.EventHandler(this.btbImport_Click);
            // 
            // mAPHUTUNGDataGridViewTextBoxColumn
            // 
            this.mAPHUTUNGDataGridViewTextBoxColumn.DataPropertyName = "MAPHUTUNG";
            this.mAPHUTUNGDataGridViewTextBoxColumn.HeaderText = "MAPHUTUNG";
            this.mAPHUTUNGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAPHUTUNGDataGridViewTextBoxColumn.Name = "mAPHUTUNGDataGridViewTextBoxColumn";
            this.mAPHUTUNGDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAPHUTUNGDataGridViewTextBoxColumn.Visible = false;
            this.mAPHUTUNGDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENPHUTUNGDataGridViewTextBoxColumn
            // 
            this.tENPHUTUNGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tENPHUTUNGDataGridViewTextBoxColumn.DataPropertyName = "TENPHUTUNG";
            this.tENPHUTUNGDataGridViewTextBoxColumn.HeaderText = "Tên phụ tùng";
            this.tENPHUTUNGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENPHUTUNGDataGridViewTextBoxColumn.Name = "tENPHUTUNGDataGridViewTextBoxColumn";
            this.tENPHUTUNGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.dONGIADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dONGIADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            this.dONGIADataGridViewTextBoxColumn.ReadOnly = true;
            this.dONGIADataGridViewTextBoxColumn.Width = 135;
            // 
            // sOLUONGTONDataGridViewTextBoxColumn
            // 
            this.sOLUONGTONDataGridViewTextBoxColumn.DataPropertyName = "SOLUONGTON";
            this.sOLUONGTONDataGridViewTextBoxColumn.HeaderText = "SL Tồn";
            this.sOLUONGTONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOLUONGTONDataGridViewTextBoxColumn.Name = "sOLUONGTONDataGridViewTextBoxColumn";
            this.sOLUONGTONDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOLUONGTONDataGridViewTextBoxColumn.Width = 125;
            // 
            // bAOCAOTONsDataGridViewTextBoxColumn
            // 
            this.bAOCAOTONsDataGridViewTextBoxColumn.DataPropertyName = "BAOCAOTONs";
            this.bAOCAOTONsDataGridViewTextBoxColumn.HeaderText = "BAOCAOTONs";
            this.bAOCAOTONsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bAOCAOTONsDataGridViewTextBoxColumn.Name = "bAOCAOTONsDataGridViewTextBoxColumn";
            this.bAOCAOTONsDataGridViewTextBoxColumn.ReadOnly = true;
            this.bAOCAOTONsDataGridViewTextBoxColumn.Visible = false;
            this.bAOCAOTONsDataGridViewTextBoxColumn.Width = 125;
            // 
            // cHITIETPSCDataGridViewTextBoxColumn
            // 
            this.cHITIETPSCDataGridViewTextBoxColumn.DataPropertyName = "CHITIET_PSC";
            this.cHITIETPSCDataGridViewTextBoxColumn.HeaderText = "CHITIET_PSC";
            this.cHITIETPSCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cHITIETPSCDataGridViewTextBoxColumn.Name = "cHITIETPSCDataGridViewTextBoxColumn";
            this.cHITIETPSCDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHITIETPSCDataGridViewTextBoxColumn.Visible = false;
            this.cHITIETPSCDataGridViewTextBoxColumn.Width = 125;
            // 
            // cTPHIEUNHAPDataGridViewTextBoxColumn
            // 
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.DataPropertyName = "CT_PHIEUNHAP";
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.HeaderText = "CT_PHIEUNHAP";
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.Name = "cTPHIEUNHAPDataGridViewTextBoxColumn";
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.Visible = false;
            this.cTPHIEUNHAPDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHUTUNGBindingSource
            // 
            this.pHUTUNGBindingSource.DataSource = typeof(PhanMemQuanLyGaraOto.Model.PHUTUNG);
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 645);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToolForm";
            this.Text = "ToolForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolForm_FormClosing);
            this.Load += new System.EventHandler(this.ToolForm_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLPT)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHUTUNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHUTUNGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btbCANCLEB;
        private System.Windows.Forms.Button btbDELETEB;
        private System.Windows.Forms.Button btbADDB;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvPHUTUNG;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView2;
        private System.Windows.Forms.BindingSource pHUTUNGBindingSource;
        private System.Windows.Forms.ComboBox cbcTenPT;
        private System.Windows.Forms.TextBox txtTenPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudGiaPT;
        private System.Windows.Forms.NumericUpDown nudSLPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPHUTUNGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENPHUTUNGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGTONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAOCAOTONsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHITIETPSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTPHIEUNHAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btbImport;
    }
}