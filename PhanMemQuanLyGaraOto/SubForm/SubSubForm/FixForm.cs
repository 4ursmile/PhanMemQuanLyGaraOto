using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDO;
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        int maPhieu;
        REMCheckCar checkCar;
        PHIEUSUACHUA currentFixForm;  
        public FixForm(REMCheckCar rEM = null)
        {
            InitializeComponent();
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            checkCar = rEM;
            LoadCurrentFixForm();
            LoadDisplayDetail();
            LoadDataToCBC();
            LoadDataToDGVFixDetail();
        }
        void LoadDisplayDetail()
        {
            txtBienSo.Text = checkCar.CarNumber;
            txtHieuXe.Text = checkCar.CarBrand;
            dtpNgayLap.Value = DateTime.Today;
        }
        void LoadCurrentFixForm()
        {
            currentFixForm = DataProvider.Instance.GetPHIEUSUACHUA(checkCar.CarId);
            if (currentFixForm == null)
            {
                currentFixForm = new PHIEUSUACHUA();
                currentFixForm.MAXE = checkCar.CarId;
                currentFixForm.NGAYLAP = DateTime.Today;
                currentFixForm.TONGTIEN = 0;
                currentFixForm.TINHTRANG = 0;
                DataProvider.Instance.SavePHIEUSUACHUA(currentFixForm);
                currentFixForm = DataProvider.Instance.GetPHIEUSUACHUA(checkCar.CarId);
                if (currentFixForm == null)
                {
                    MessageBox.Show("Lỗi không mong muốn đã xảy ra");
                    this.Close();
                }
                ReloadDataEvent.Ins.Alert(DataType.FixForm);
            } 

        }
        void LoadDataToDGVFixDetail()
        {
            dgvPHUTUNG.AutoGenerateColumns = false;
            if (currentFixForm != null)
            dgvPHUTUNG.DataSource = DataProvider.Instance.GetChiTietPSC(currentFixForm.MAPHIEU);
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

        private void btbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbCancelPhieu_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.db.XOAPHIEUSUACHUA(currentFixForm.MAPHIEU);
            this.Close();
            ReloadDataEvent.Ins.Alert(DataType.FixForm);
        }
    }
}
