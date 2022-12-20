using PhanMemQuanLyGaraOto.Class;
using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDO;
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
    public partial class ImportForm : Form
    {
        PHIEUNHAP currentPhieuNhap;
        public ImportForm()
        {
            LoadPhieuNhap();
            ReloadDataEvent.Ins.Addlistener(LoadDGVCTPhuTungAsync, DataType.ImportDetail);
            ReloadDataEvent.Ins.Addlistener(LoadCBCRemainPhuTungAsync, DataType.ImportDetail);

            InitializeComponent();
            LoadDGVCTPhuTungAsync();
            LoadCBCRemainPhuTungAsync();
            ResetImportForm();

        }
        void LoadPhieuNhap()
        {
            currentPhieuNhap = DataProvider.Instance.GetPhieuNhapActive();
            if (currentPhieuNhap == null)
            {
                currentPhieuNhap = new PHIEUNHAP();
                currentPhieuNhap.TINHTRANG = 0;
                currentPhieuNhap.NGAYLAP = DateTime.Today;
                currentPhieuNhap.TONGTIEN = 0;
                DataProvider.Instance.SaveImport(currentPhieuNhap);
                currentPhieuNhap = DataProvider.Instance.GetPhieuNhapActive();
                if (currentPhieuNhap == null)
                {
                    
                    MessageBox.Show("Lỗi không mong muốn đã xảy ra");
                    this.Close();
                }
            }
        }
        private void ImportForm_Load(object sender, EventArgs e)
        {

        }
        async void LoadDGVCTPhuTungAsync()
        {
            dgvCT_PHIEUNHAP.DataSource =await DataProvider.Instance.GetCImportToolsAsync(currentPhieuNhap.SOPHIEUNHAP);
            decimal total = (dgvCT_PHIEUNHAP.DataSource as List<CImportTool>).Sum(a=>a.thanhtien).Value;
            txtThanhTien.Text = total.ToString("c0");
        }
        async void LoadCBCRemainPhuTungAsync()
        {
            cbcPhutung.DataSource = await DataProvider.Instance.GetCurrentListPhuTungAsync(currentPhieuNhap.SOPHIEUNHAP);
            cbcPhutung.DisplayMember = "TENPHUTUNG";
        }
        void ResetImportForm()
        {
            dgvCT_PHIEUNHAP.ClearSelection();
            btbDELETEB.Enabled = false;
            btbADDB.Enabled = true;
            nudSLT.Value = 0;
            nudDonGia.Value = 0;
        }
        private void dgvCT_PHIEUNHAP_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvCT_PHIEUNHAP.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ImportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadDataEvent.Ins.RemoveListerner(LoadDGVCTPhuTungAsync, DataType.ImportDetail);
            ReloadDataEvent.Ins.RemoveListerner(LoadCBCRemainPhuTungAsync, DataType.ImportDetail);
        }

        private void btbCANCLEB_Click(object sender, EventArgs e)
        {
            ResetImportForm();
        }

        private void btbADDB_Click(object sender, EventArgs e)
        {
            btbADDB.Enabled = false;
            if (nudSLT.Value == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Không hợp lệ");
                btbADDB.Enabled = true;
                return;
            }
            var selectPhutung = cbcPhutung.SelectedValue as GETCURRENTPHUTUNGTOSELECT_Result;
            if (selectPhutung == null)
            {
                MessageBox.Show("Phụ tùng không hợp lệ", "Không hợp lệ");
                btbADDB.Enabled = true;
                return;
            }
            CT_PHIEUNHAP ct = new CT_PHIEUNHAP();
            ct.SOPHIEUNHAP = currentPhieuNhap.SOPHIEUNHAP;
            ct.MAPHUTUNG = selectPhutung.MAPHUTUNG;
            ct.SOLUONGNHAP = (int)nudSLT.Value;
            ct.DONGIA = nudDonGia.Value;
            ct.THANHTIEN = ct.DONGIA * ct.SOLUONGNHAP;
            DataProvider.Instance.SaveImportDetail(ct, ResetImportForm);
        }

        private void cbcPhutung_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pt = cbcPhutung.SelectedValue as GETCURRENTPHUTUNGTOSELECT_Result;
            if (pt == null) return;
            nudDonGia.Value = pt.DONGIA.Value;
        }

        private void btbAccect_Click(object sender, EventArgs e)
        {
            if (MesseageBoxStatic.MessageBoxQuestion("Bạn có muốn xác nhận phiếu nhập này không?") != DialogResult.Yes)
                return;
            try
            {
                DataProvider.Instance.db.DONGPHIEUNHAP(currentPhieuNhap.SOPHIEUNHAP);
                ReloadDataEvent.Ins.Alert(DataType.ImportForm);
                Notification.MakeImportSuccesNoti();
                this.Close();
            } catch
            {
                DataProvider.Instance.MakeNotiError("Nhập hàng");
                this.Close();
            }

        }

        private void btbImportAll_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.db.GETCURRENTPHUTUNG(currentPhieuNhap.SOPHIEUNHAP);
            ReloadDataEvent.Ins.Alert(DataType.ImportDetail);
        }
        CImportTool currentct;
        private void dgvCT_PHIEUNHAP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCT_PHIEUNHAP.CurrentRow.Index > -1)
            {
                currentct = dgvCT_PHIEUNHAP.CurrentRow.DataBoundItem as CImportTool;
                btbDELETEB.Enabled = true;
            }  else
            {
                ResetImportForm();
            }
        }

        private void dgvCT_PHIEUNHAP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCT_PHIEUNHAP_SelectionChanged(object sender, EventArgs e)
        {
            dgvCT_PHIEUNHAP_CellMouseClick(sender, null);
        }

        private void btbDELETEB_Click(object sender, EventArgs e)
        {
            if (currentct == null) return;
            CT_PHIEUNHAP ct = new CT_PHIEUNHAP();
            ct.SOPHIEUNHAP = currentct.sophieunhap;
            ct.MAPHUTUNG = currentct.maphutung;
            DataProvider.Instance.DeleteImportDetail(ct, ResetImportForm);
        }

        private void btbSetNumberAll_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.db.SETNUMBERFORALLELEMENT(currentPhieuNhap.SOPHIEUNHAP, (int)nudSetNumberAll.Value);
            LoadDGVCTPhuTungAsync();
        }

        private void btbSetPriceAll_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.db.SETPRICE4ALLELEMENT(currentPhieuNhap.SOPHIEUNHAP, nudSetPriceall.Value);
            LoadDGVCTPhuTungAsync();
        }
    }
}
