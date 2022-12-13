using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDo;
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.SubForm
{
    public partial class BrandForm : Form
    {
        TIENCONG cuurentSelectTienCong;
        HIEUXE currentSelectHieuXe;
        public BrandForm()
        {
            InitializeComponent();
            ResetBrand();
            LoadDataToDGVBRAND();
            Reset();
            LoadDataToDGV();
        }
        bool isUpdate = false;
        void Reset()
        {
            if (UniversalUser.Ins.account.TYPE > 1)
            {
                btbAdd.Enabled = false;
                txtContent.Enabled = false;
                nudPrice.Enabled = false;
            }
            else
            {
                btbAdd.Enabled = true;
                txtContent.Enabled = true;
                nudPrice.Enabled = true;
            }
            cuurentSelectTienCong = null;
            btbDelete2.Enabled = false;
            btbAdd.Text = "Thêm";
            txtContent.Text = txtPriceID.Text = "";
            nudPrice.Value = 0;
            isUpdate = false;
            cbcSearchTienCong.Text = "";

        }
        bool isUpdateB;
        void ResetBrand()
        {
            if (UniversalUser.Ins.account.TYPE > 1)
            {
                btbADDB.Enabled = false;
                txtBrandName.Enabled = false;
            }
            else
            {
                btbADDB.Enabled = true;
                txtBrandName.Enabled = true;
            }
            currentSelectHieuXe = null;
            btbDELETEB.Enabled = false;
            btbADDB.Text = "Thêm";
            txtBrandName.Text = txtBRANDID.Text = "";
            isUpdateB = false;
            cbcSearchBrand.Text = "";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void btbDelete2_Click(object sender, EventArgs e)
        {
            if (cuurentSelectTienCong == null) return;
            btbDelete2.Enabled = false;
            DataProvider.Instance.DeleteTienCong(cuurentSelectTienCong, LoadDataToDGV, Reset);

        }

        private void btbCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void LoadDataToDGV()
        {
            dgvTIENCONG.AutoGenerateColumns = false;
            dgvTIENCONG.DataSource = DataProvider.Instance.db.TIENCONGs.ToList<TIENCONG>();
            cbcSearchTienCong.DataSource = dgvTIENCONG.DataSource;
            cbcSearchTienCong.DisplayMember = "NOIDUNG";
        }
        private void btbAdd_Click(object sender, EventArgs e)
        {
            btbAdd.Enabled = false;
            if (isUpdate)
            {
                if (txtContent.Text == "")
                {
                    MessageBox.Show("Nội dung là bắt buộc!", "Không hợp lệ");
                    btbAdd.Enabled = true;

                    return;
                }
                cuurentSelectTienCong.TIENCONG1 = nudPrice.Value;
                cuurentSelectTienCong.NOIDUNG = txtContent.Text;
                cuurentSelectTienCong.MANDTC = Convert.ToInt32(txtPriceID.Text);
                DataProvider.Instance.UpdateTienCong(cuurentSelectTienCong, LoadDataToDGV, Reset);
            }
            else
            {
                if (txtContent.Text == "")
                {
                    MessageBox.Show("Nội dung là bắt buộc!", "Không hợp lệ");
                    btbAdd.Enabled = true;
                    return;
                }
                cuurentSelectTienCong = new TIENCONG();
                cuurentSelectTienCong.NOIDUNG = txtContent.Text;
                cuurentSelectTienCong.TIENCONG1 = nudPrice.Value;
                DataProvider.Instance.SaveTienCong(cuurentSelectTienCong, LoadDataToDGV, Reset);
            }
        }
        void UpdateViewData(TIENCONG tIENCONG)
        {
            txtContent.Text = tIENCONG.NOIDUNG;
            txtPriceID.Text = tIENCONG.MANDTC.ToString();
            nudPrice.Value = Convert.ToDecimal(tIENCONG.TIENCONG1);
            if (UniversalUser.Ins.account.TYPE > 1)
            {
                btbDelete2.Enabled = false;
            }
            else
            {
                btbDelete2.Enabled = true;
            }
        }
        private void kryptonDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTIENCONG.CurrentRow.Index != -1)
            {
                cuurentSelectTienCong = new TIENCONG();
                cuurentSelectTienCong.MANDTC = Convert.ToInt32(dgvTIENCONG.CurrentRow.Cells[0].Value);
                cuurentSelectTienCong.TIENCONG1 = Convert.ToDecimal(dgvTIENCONG.CurrentRow.Cells[2].Value);
                cuurentSelectTienCong.NOIDUNG = dgvTIENCONG.CurrentRow.Cells[1].Value.ToString();
                UpdateViewData(cuurentSelectTienCong);
                btbAdd.Text = "Cập nhật";
                isUpdate = true;
            }
            else
            {
                Reset();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoadDataToDGVBRAND()
        {
            dgvBRAND.AutoGenerateColumns = false;
            dgvBRAND.DataSource = DataProvider.Instance.db.HIEUXEs.ToList<HIEUXE>();
            cbcSearchBrand.DataSource = dgvBRAND.DataSource;
            cbcSearchBrand.DisplayMember = "TENHIEUXE";
        }
        void UpdateViewDataBrand(HIEUXE hIEUXE)
        {
            txtBRANDID.Text = hIEUXE.MAHIEUXE.ToString();
            txtBrandName.Text = hIEUXE.TENHIEUXE;
            if (UniversalUser.Ins.account.TYPE > 1)
            {
                btbDELETEB.Enabled = false;
            }
            else
            {
                btbDELETEB.Enabled = true;
            }
        }
        private void dgvBRAND_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvBRAND.AutoGenerateColumns = false;
            if (dgvBRAND == null) return;
            if (dgvBRAND.CurrentRow.Index != -1)
            {
                currentSelectHieuXe = new HIEUXE();
                currentSelectHieuXe.MAHIEUXE = Convert.ToInt32(dgvBRAND.CurrentRow.Cells[0].Value);
                currentSelectHieuXe.TENHIEUXE = dgvBRAND.CurrentRow.Cells[1].Value.ToString();
                UpdateViewDataBrand(currentSelectHieuXe);
                btbADDB.Text = "Cập nhật";
                isUpdateB = true;
            }
            else
            {
                ResetBrand();
            }
        }

        private void btbADDB_Click(object sender, EventArgs e)
        {
            btbADDB.Enabled = false;
            if (isUpdateB)
            {
                if (currentSelectHieuXe == null)
                {
                    btbADDB.Enabled = true;
                }
                if (txtBrandName.Text == "")
                {
                    MessageBox.Show("Tên hiệu xe là bắt buộc!", "Không hợp lệ");
                    btbAdd.Enabled = true;
                    return;
                }
                currentSelectHieuXe.TENHIEUXE = txtBrandName.Text;
                DataProvider.Instance.UpdateBrand(currentSelectHieuXe, LoadDataToDGVBRAND, ResetBrand);
            }
            else
            {
                if (txtBrandName.Text == "")
                {
                    MessageBox.Show("Tên hiệu xe là bắt buộc!", "Không hợp lệ");
                    btbAdd.Enabled = true;
                    return;
                }
                currentSelectHieuXe = new HIEUXE();
                currentSelectHieuXe.TENHIEUXE = txtBrandName.Text;
                DataProvider.Instance.SaveBrand(currentSelectHieuXe, LoadDataToDGVBRAND, ResetBrand);

            }
        }

        private void btbCANCLEB_Click(object sender, EventArgs e)
        {
            ResetBrand();
        }

        private void btbDELETEB_Click(object sender, EventArgs e)
        {
            if (currentSelectHieuXe == null)
            {
                ResetBrand();
                return;
            }
            btbDELETEB.Enabled = false;
            DataProvider.Instance.DeleteBrand(currentSelectHieuXe, LoadDataToDGVBRAND, ResetBrand);
        }

        private void dgvTIENCONG_SelectionChanged(object sender, EventArgs e)
        {
            kryptonDataGridView1_CellMouseClick(sender, null);
        }

        private void dgvBRAND_SelectionChanged(object sender, EventArgs e)
        {
            dgvBRAND_CellMouseClick(sender, null);
        }

    }
}
