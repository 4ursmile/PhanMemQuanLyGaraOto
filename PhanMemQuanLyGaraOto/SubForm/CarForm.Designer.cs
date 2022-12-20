namespace PhanMemQuanLyGaraOto.SubForm
{
    partial class CarForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btbDelete = new System.Windows.Forms.Panel();
            this.dgvCheckCars = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFilterSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcFilterFix = new System.Windows.Forms.ComboBox();
            this.btbFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcFilterDebt = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btbFix = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcBienSo = new System.Windows.Forms.ComboBox();
            this.btbcollect = new System.Windows.Forms.Button();
            this.btbUpdate = new System.Windows.Forms.Button();
            this.btbTiepNhan = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carOwnerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carOwnerTeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMCheckCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.btbDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckCars)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEMCheckCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.56939F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.43061F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 569F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1107, 645);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btbDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(153, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 563);
            this.panel1.TabIndex = 4;
            // 
            // btbDelete
            // 
            this.btbDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btbDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btbDelete.Controls.Add(this.dgvCheckCars);
            this.btbDelete.Location = new System.Drawing.Point(5, 4);
            this.btbDelete.Name = "btbDelete";
            this.btbDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btbDelete.Size = new System.Drawing.Size(942, 546);
            this.btbDelete.TabIndex = 2;
            // 
            // dgvCheckCars
            // 
            this.dgvCheckCars.AutoGenerateColumns = false;
            this.dgvCheckCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.carIdDataGridViewTextBoxColumn,
            this.carBrandDataGridViewTextBoxColumn,
            this.carNumberDataGridViewTextBoxColumn,
            this.carOwnerNameDataGridViewTextBoxColumn,
            this.carOwnerTeleDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.debtMoneyDataGridViewTextBoxColumn,
            this.TinhTrang});
            this.dgvCheckCars.DataSource = this.rEMCheckCarBindingSource;
            this.dgvCheckCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckCars.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvCheckCars.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.dgvCheckCars.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgvCheckCars.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgvCheckCars.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgvCheckCars.Location = new System.Drawing.Point(5, 5);
            this.dgvCheckCars.Name = "dgvCheckCars";
            this.dgvCheckCars.RowHeadersWidth = 30;
            this.dgvCheckCars.RowTemplate.Height = 24;
            this.dgvCheckCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckCars.Size = new System.Drawing.Size(930, 534);
            this.dgvCheckCars.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvCheckCars.StateCommon.Background.Color2 = System.Drawing.Color.WhiteSmoke;
            this.dgvCheckCars.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.dgvCheckCars.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.dgvCheckCars.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvCheckCars.StateCommon.DataCell.Border.Rounding = 5;
            this.dgvCheckCars.StateCommon.DataCell.Border.Width = 1;
            this.dgvCheckCars.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.dgvCheckCars.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.dgvCheckCars.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.dgvCheckCars.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvCheckCars.StateCommon.HeaderColumn.Border.Rounding = 3;
            this.dgvCheckCars.StateCommon.HeaderColumn.Border.Width = 1;
            this.dgvCheckCars.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCheckCars.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvCheckCars.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.dgvCheckCars.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.dgvCheckCars.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvCheckCars.StateCommon.HeaderRow.Border.Rounding = 5;
            this.dgvCheckCars.StateCommon.HeaderRow.Border.Width = 1;
            this.dgvCheckCars.TabIndex = 0;
            this.dgvCheckCars.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCheckCars_CellMouseClick);
            this.dgvCheckCars.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCheckCars_RowPostPaint);
            this.dgvCheckCars.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvCheckCars_RowPrePaint);
            this.dgvCheckCars.SelectionChanged += new System.EventHandler(this.dgvCheckCars_SelectionChanged_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtCarNumber);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtFilterSDT);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbcFilterFix);
            this.panel2.Controls.Add(this.btbFilter);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbcFilterDebt);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(3, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 563);
            this.panel2.TabIndex = 5;
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarNumber.Location = new System.Drawing.Point(3, 364);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(134, 22);
            this.txtCarNumber.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Biển số";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Đặt lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // txtFilterSDT
            // 
            this.txtFilterSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterSDT.Location = new System.Drawing.Point(3, 287);
            this.txtFilterSDT.Name = "txtFilterSDT";
            this.txtFilterSDT.Size = new System.Drawing.Size(134, 22);
            this.txtFilterSDT.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sửa chữa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbcFilterFix
            // 
            this.cbcFilterFix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbcFilterFix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcFilterFix.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcFilterFix.FormattingEnabled = true;
            this.cbcFilterFix.Items.AddRange(new object[] {
            "Tất cả",
            "Đang sửa chữa",
            "Không sửa chữa"});
            this.cbcFilterFix.Location = new System.Drawing.Point(3, 192);
            this.cbcFilterFix.Name = "cbcFilterFix";
            this.cbcFilterFix.Size = new System.Drawing.Size(136, 24);
            this.cbcFilterFix.TabIndex = 15;
            // 
            // btbFilter
            // 
            this.btbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbFilter.BackColor = System.Drawing.Color.White;
            this.btbFilter.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btbFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btbFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btbFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbFilter.Location = new System.Drawing.Point(11, 422);
            this.btbFilter.Name = "btbFilter";
            this.btbFilter.Size = new System.Drawing.Size(122, 35);
            this.btbFilter.TabIndex = 10;
            this.btbFilter.Text = "Lọc";
            this.btbFilter.UseVisualStyleBackColor = false;
            this.btbFilter.Click += new System.EventHandler(this.btbFilter_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(7, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bộ lọc";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "SĐT Chủ xe";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tình trạng nợ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbcFilterDebt
            // 
            this.cbcFilterDebt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbcFilterDebt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcFilterDebt.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcFilterDebt.FormattingEnabled = true;
            this.cbcFilterDebt.Items.AddRange(new object[] {
            "Tất cả",
            "Đã trả",
            "Còn nợ"});
            this.cbcFilterDebt.Location = new System.Drawing.Point(3, 116);
            this.cbcFilterDebt.Name = "cbcFilterDebt";
            this.cbcFilterDebt.Size = new System.Drawing.Size(136, 24);
            this.cbcFilterDebt.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PhanMemQuanLyGaraOto.Properties.Resources.filter;
            this.pictureBox1.Location = new System.Drawing.Point(36, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btbFix);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbcBienSo);
            this.panel3.Controls.Add(this.btbcollect);
            this.panel3.Controls.Add(this.btbUpdate);
            this.panel3.Controls.Add(this.btbTiepNhan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(153, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 104);
            this.panel3.TabIndex = 6;
            // 
            // btbFix
            // 
            this.btbFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btbFix.BackColor = System.Drawing.Color.Bisque;
            this.btbFix.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btbFix.FlatAppearance.BorderSize = 2;
            this.btbFix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btbFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbFix.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbFix.Location = new System.Drawing.Point(647, 37);
            this.btbFix.Name = "btbFix";
            this.btbFix.Size = new System.Drawing.Size(116, 35);
            this.btbFix.TabIndex = 10;
            this.btbFix.Text = "Sửa chữa";
            this.btbFix.UseVisualStyleBackColor = false;
            this.btbFix.Click += new System.EventHandler(this.btbFix_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Biển số";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbcBienSo
            // 
            this.cbcBienSo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcBienSo.FormattingEnabled = true;
            this.cbcBienSo.Location = new System.Drawing.Point(91, 42);
            this.cbcBienSo.Name = "cbcBienSo";
            this.cbcBienSo.Size = new System.Drawing.Size(187, 27);
            this.cbcBienSo.TabIndex = 3;
            // 
            // btbcollect
            // 
            this.btbcollect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btbcollect.BackColor = System.Drawing.Color.PaleGreen;
            this.btbcollect.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btbcollect.FlatAppearance.BorderSize = 2;
            this.btbcollect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btbcollect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbcollect.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbcollect.ForeColor = System.Drawing.Color.Black;
            this.btbcollect.Location = new System.Drawing.Point(790, 37);
            this.btbcollect.Name = "btbcollect";
            this.btbcollect.Size = new System.Drawing.Size(148, 35);
            this.btbcollect.TabIndex = 2;
            this.btbcollect.Text = "Thu tiền";
            this.btbcollect.UseVisualStyleBackColor = false;
            this.btbcollect.Click += new System.EventHandler(this.btbcollect_Click);
            // 
            // btbUpdate
            // 
            this.btbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btbUpdate.BackColor = System.Drawing.Color.White;
            this.btbUpdate.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btbUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btbUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btbUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbUpdate.Location = new System.Drawing.Point(497, 37);
            this.btbUpdate.Name = "btbUpdate";
            this.btbUpdate.Size = new System.Drawing.Size(109, 35);
            this.btbUpdate.TabIndex = 1;
            this.btbUpdate.Text = "Cập nhật";
            this.btbUpdate.UseVisualStyleBackColor = false;
            this.btbUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btbTiepNhan
            // 
            this.btbTiepNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btbTiepNhan.BackColor = System.Drawing.Color.White;
            this.btbTiepNhan.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btbTiepNhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btbTiepNhan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btbTiepNhan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbTiepNhan.Location = new System.Drawing.Point(352, 37);
            this.btbTiepNhan.Name = "btbTiepNhan";
            this.btbTiepNhan.Size = new System.Drawing.Size(124, 35);
            this.btbTiepNhan.TabIndex = 0;
            this.btbTiepNhan.Text = "Tiếp nhận";
            this.btbTiepNhan.UseVisualStyleBackColor = false;
            this.btbTiepNhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.IndianRed;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(144, 104);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Số lượt sửa";
            this.chart1.Titles.Add(title1);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "TinhTrang";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Visible = false;
            this.TinhTrang.Width = 125;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CID";
            this.carIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            this.carIdDataGridViewTextBoxColumn.Visible = false;
            this.carIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // carBrandDataGridViewTextBoxColumn
            // 
            this.carBrandDataGridViewTextBoxColumn.DataPropertyName = "CarBrand";
            this.carBrandDataGridViewTextBoxColumn.HeaderText = "Hiệu xe";
            this.carBrandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carBrandDataGridViewTextBoxColumn.Name = "carBrandDataGridViewTextBoxColumn";
            this.carBrandDataGridViewTextBoxColumn.ReadOnly = true;
            this.carBrandDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.carBrandDataGridViewTextBoxColumn.Width = 110;
            // 
            // carNumberDataGridViewTextBoxColumn
            // 
            this.carNumberDataGridViewTextBoxColumn.DataPropertyName = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.HeaderText = "Biển số";
            this.carNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carNumberDataGridViewTextBoxColumn.Name = "carNumberDataGridViewTextBoxColumn";
            this.carNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.carNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.carNumberDataGridViewTextBoxColumn.Width = 105;
            // 
            // carOwnerNameDataGridViewTextBoxColumn
            // 
            this.carOwnerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.carOwnerNameDataGridViewTextBoxColumn.DataPropertyName = "CarOwnerName";
            this.carOwnerNameDataGridViewTextBoxColumn.HeaderText = "Tên chủ xe";
            this.carOwnerNameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.carOwnerNameDataGridViewTextBoxColumn.Name = "carOwnerNameDataGridViewTextBoxColumn";
            this.carOwnerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carOwnerTeleDataGridViewTextBoxColumn
            // 
            this.carOwnerTeleDataGridViewTextBoxColumn.DataPropertyName = "CarOwnerTele";
            this.carOwnerTeleDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.carOwnerTeleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carOwnerTeleDataGridViewTextBoxColumn.Name = "carOwnerTeleDataGridViewTextBoxColumn";
            this.carOwnerTeleDataGridViewTextBoxColumn.ReadOnly = true;
            this.carOwnerTeleDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = "Không xác định";
            this.dateInDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateInDataGridViewTextBoxColumn.HeaderText = "Ngày tiếp nhận";
            this.dateInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            this.dateInDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateInDataGridViewTextBoxColumn.Width = 120;
            // 
            // debtMoneyDataGridViewTextBoxColumn
            // 
            this.debtMoneyDataGridViewTextBoxColumn.DataPropertyName = "DebtMoney";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.debtMoneyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.debtMoneyDataGridViewTextBoxColumn.HeaderText = "Tổng nợ";
            this.debtMoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.debtMoneyDataGridViewTextBoxColumn.Name = "debtMoneyDataGridViewTextBoxColumn";
            this.debtMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.debtMoneyDataGridViewTextBoxColumn.Width = 135;
            // 
            // rEMCheckCarBindingSource
            // 
            this.rEMCheckCarBindingSource.DataSource = typeof(PhanMemQuanLyGaraOto.DDO.REMCheckCar);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1107, 645);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CarForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarForm_FormClosing);
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.btbDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckCars)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEMCheckCarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource rEMCheckCarBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btbDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvCheckCars;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFilterSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbcFilterFix;
        private System.Windows.Forms.Button btbFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcFilterDebt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btbFix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbcBienSo;
        private System.Windows.Forms.Button btbcollect;
        private System.Windows.Forms.Button btbUpdate;
        private System.Windows.Forms.Button btbTiepNhan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carOwnerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carOwnerTeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}