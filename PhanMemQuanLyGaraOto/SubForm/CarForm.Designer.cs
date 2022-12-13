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
            this.btbDelete = new System.Windows.Forms.Panel();
            this.dgvAccounts = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btbDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btbDelete
            // 
            this.btbDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btbDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btbDelete.Controls.Add(this.dgvAccounts);
            this.btbDelete.Location = new System.Drawing.Point(27, 36);
            this.btbDelete.Name = "btbDelete";
            this.btbDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btbDelete.Size = new System.Drawing.Size(929, 597);
            this.btbDelete.TabIndex = 2;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounts.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvAccounts.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.dgvAccounts.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgvAccounts.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgvAccounts.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgvAccounts.Location = new System.Drawing.Point(5, 5);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersWidth = 30;
            this.dgvAccounts.RowTemplate.Height = 24;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(917, 585);
            this.dgvAccounts.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvAccounts.StateCommon.Background.Color2 = System.Drawing.Color.WhiteSmoke;
            this.dgvAccounts.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.dgvAccounts.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.dgvAccounts.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvAccounts.StateCommon.DataCell.Border.Rounding = 5;
            this.dgvAccounts.StateCommon.DataCell.Border.Width = 1;
            this.dgvAccounts.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.dgvAccounts.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.dgvAccounts.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.dgvAccounts.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvAccounts.StateCommon.HeaderColumn.Border.Rounding = 3;
            this.dgvAccounts.StateCommon.HeaderColumn.Border.Width = 1;
            this.dgvAccounts.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAccounts.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.dgvAccounts.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.dgvAccounts.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.dgvAccounts.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvAccounts.StateCommon.HeaderRow.Border.Rounding = 5;
            this.dgvAccounts.StateCommon.HeaderRow.Border.Width = 1;
            this.dgvAccounts.TabIndex = 0;
            this.dgvAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellContentClick);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1107, 645);
            this.ControlBox = false;
            this.Controls.Add(this.btbDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.btbDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btbDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvAccounts;
    }
}