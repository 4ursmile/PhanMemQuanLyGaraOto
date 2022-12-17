using PhanMemQuanLyGaraOto.Class;
using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDO;
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Media.Playback;
using Windows.Networking.NetworkOperators;

namespace PhanMemQuanLyGaraOto.SubForm.SubSubForm
{
    public partial class FixForm : Form
    {
        int maPhieu;
        decimal profitRate = 1;
        REMCheckCar checkCar;
        PHIEUSUACHUA currentFixForm;
        CustomCTPSC currentCTPSC;
        CHITIET_PSC currentChiTiet;
        public FixForm(REMCheckCar rEM = null)
        {
            InitializeComponent();
            ReloadDataEvent.Ins.Addlistener(LoadDataToDGVFixDetail, DataType.FixDetail);
            ReloadDataEvent.Ins.Addlistener(LoadDataToCBC, DataType.FixDetail);
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            checkCar = rEM;
            LoadCurrentFixForm();
            LoadDisplayDetail();
            profitRate = (decimal)DataProvider.Instance.getPhutungProfitRate();
            LoadDataToCBC();
            LoadDataToDGVFixDetail();
            ResetPSC();
        }
        async void LoadProfitRate()
        {
            
        }
        void ResetPSC()
        {
            cbcNoiDung.SelectedIndex = -1;
            cbcPhutung.SelectedIndex = -1;
            nudDonGia.Value = 0;
            nudTienCong.Value = 0;
            nudSLT.Value = 0;
            currentCTPSC = null;
            currentChiTiet = null;
            btbADDB.Enabled = true;
            btbDELETEB.Enabled = false;
        }
        void LoadDisplayDetail()
        {
            txtBienSo.Text = checkCar.CarNumber;
            dtpNgayLap.Value = DateTime.Today;
        }
        void LoadCurrentFixForm()
        {
            if (checkCar.TinhTrang == 1)
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
            } else
            {
                currentFixForm = DataProvider.Instance.GetPHIEUSUACHUA(checkCar.CarId);
                if (currentFixForm == null)
                {
                    MessageBox.Show("Lỗi không mong muốn đã xảy ra");
                    this.Close();
                }
            }

        }
        async void LoadDataToDGVFixDetail()
        {
            dgvPHUTUNG.AutoGenerateColumns = false;
            if (currentFixForm != null)
            {
                dgvPHUTUNG.DataSource = await (Task.Run(()=> DataProvider.Instance.GetChiTietPSC(currentFixForm.MAPHIEU)));
            }
            else
            {
                this.Close();
                return;
            }
            decimal thanhtien = (decimal)(dgvPHUTUNG.DataSource as List<CustomCTPSC>).Sum(a => a.THANHTIEN);
            txtThanhTien.Text = thanhtien.ToString("c0");
            currentFixForm.TONGTIEN = thanhtien;
        }
        async void LoadDataToCBC()
        {
            cbcNoiDung.DataSource = DataProvider.Instance.refreshDB.TIENCONGs.ToList<TIENCONG>();
            cbcNoiDung.DisplayMember = "NOIDUNG";
            cbcPhutung.DataSource = await DataProvider.Instance.GetPHUTUNGs();
            cbcPhutung.DisplayMember = "TENPHUTUNG";
            cbcPhutung.SelectedIndex = -1;
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
            ReloadDataEvent.Ins.RemoveListerner(LoadDataToDGVFixDetail, DataType.FixDetail);
        }

        private void nudGiaPT_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbcNoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcNoiDung.SelectedValue == null)
            {
                nudTienCong.Value = 0;
                return;
            }
            nudTienCong.Value = (decimal)(cbcNoiDung.SelectedValue as TIENCONG).TIENCONG1;
        }

        private void cbcPhutung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcPhutung.SelectedValue == null)
            {
                nudDonGia.Value = 0;
                lblMax.Text = "0";
                return;
            }
            PHUTUNG d = (cbcPhutung.SelectedValue as PHUTUNG);
            nudDonGia.Value = (decimal)d.DONGIA*profitRate;
            nudSLT.Maximum = (int)(d.SOLUONGTON);
            lblMax.Text = nudSLT.Maximum.ToString();
            if (nudSLT.Maximum == 0)
                MesseageBoxStatic.MessageBoxNoti("Phụ tùng này đã hết");
            nudSLT.Value = 0;
        }

        private void btbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btbCancelPhieu_Click(object sender, EventArgs e)
        {

        }

        private void btbDongPhieu_Click(object sender, EventArgs e)
        {
            this.Close();
            DataProvider.Instance.UpdatePHIEUSUACHUA(currentFixForm);
            DataProvider.Instance.db.DONGPHIEUSUACHUA(currentFixForm.MAPHIEU, currentFixForm.TONGTIEN);
            ReloadDataEvent.Ins.Alert(DataType.Car);
        }
        private void btbADDB_Click(object sender, EventArgs e)
        {
            btbADDB.Enabled = false;
            if (cbcNoiDung.SelectedValue == null || cbcPhutung.SelectedValue == null)
            {
                MesseageBoxStatic.MessageBoxNoti("Nội dung hoặc phụ kiện không được để trống!");
                btbADDB.Enabled = true;
                return;
            }
            if (nudSLT.Value < 1)
            {
                MesseageBoxStatic.MessageBoxNoti("Số lượng phải lớn hơn 0");
                btbADDB.Enabled = true;
                return;
            }
            currentChiTiet = new CHITIET_PSC
            {
                MAPHIEU = currentFixForm.MAPHIEU,
                MANDTC = (cbcNoiDung.SelectedValue as TIENCONG).MANDTC,
                TIENCONG = (decimal)nudTienCong.Value,
                MAPHUTUNG = (cbcPhutung.SelectedValue as PHUTUNG).MAPHUTUNG,
                SOLUONG = (int)nudSLT.Value,
                DONGIA = (decimal)nudDonGia.Value
            };
            currentChiTiet.THANHTIEN = currentChiTiet.SOLUONG * currentChiTiet.DONGIA + currentChiTiet.TIENCONG;
            DataProvider.Instance.SaveCHITETPHIEUSUACHUA(currentChiTiet);
            ResetPSC();
        }

        private void btbCANCLEB_Click(object sender, EventArgs e)
        {
            ResetPSC();
        }
        void UpdateViewPoint(CustomCTPSC cus)
        {
            cbcNoiDung.Text = cus.NOIDUNG;
            cbcPhutung.Text = cus.TENPHUTUNG;
            nudDonGia.Value = (decimal)cus.DONGIA;
            nudTienCong.Value = (decimal)cus.TIENCONG;
            nudSLT.Value = (int)cus.SOLUONG;
            btbDELETEB.Enabled = true;
            btbADDB.Enabled = false;
        }
        private void dgvPHUTUNG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPHUTUNG.CurrentRow.Index > -1)
            {
                currentCTPSC = dgvPHUTUNG.CurrentRow.DataBoundItem as CustomCTPSC;
                if (currentCTPSC == null) return;
                UpdateViewPoint(currentCTPSC);
            } else
            {
                ResetPSC();
            }
        }

        private void btbDELETEB_Click(object sender, EventArgs e)
        {
            if (currentCTPSC == null) return;
            currentChiTiet = new CHITIET_PSC();
            currentChiTiet.MACTPSC = currentCTPSC.MACTPSC;
            DataProvider.Instance.DeleteCHITIET_PSC(currentChiTiet);
        }
    }
}
