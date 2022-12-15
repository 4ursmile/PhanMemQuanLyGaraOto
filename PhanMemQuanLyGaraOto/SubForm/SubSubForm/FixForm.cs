using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.SubForm.SubSubForm
{
    public partial class FixForm : Form
    {
        public FixForm()
        {
            InitializeComponent();
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            LoadDataToCBC();
        }
        void LoadDataToCBC()
        {
            cbcNoiDung.DataSource = DataProvider.Instance.db.TIENCONGs.ToList<TIENCONG>();
            cbcNoiDung.DisplayMember = "NOIDUNG";
            cbcPhutung.DataSource = DataProvider.Instance.db.PHUTUNGs.ToList<PHUTUNG>();
            cbcPhutung.DisplayMember = "TENPHUTUNG";
        }
        private void dgvPHUTUNG_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvPHUTUNG.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvPHUTUNG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void DiposeToRoot(Control k)
        {
            if (k == null) return;
            foreach (Control e in k.Controls)
            {
                e.Dispose();

                DiposeToRoot(e);
            }
            k.Dispose();
        }
        private void FixForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DiposeToRoot(this);
            this.Dispose();
        }

        private void nudGiaPT_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbcNoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudTienCong.Value = (decimal)(cbcNoiDung.SelectedValue as TIENCONG).TIENCONG1;
        }

        private void cbcPhutung_SelectedIndexChanged(object sender, EventArgs e)
        {
            PHUTUNG d = (cbcPhutung.SelectedValue as PHUTUNG);
            nudDonGia.Value = (decimal)d.DONGIA;
            nudSLT.Maximum = (int)(d.SOLUONGTON);
        }
    }
}
