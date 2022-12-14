using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDo;
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.SubForm
{
    public partial class CustomerForm : Form
    {
        CHUXE currentSelectedCustomer;
        bool isUpdate = false;
        public CustomerForm()
        {
            ReloadDataEvent.Ins.Addlistener(LoadDataCusDGV, DataType.Customer);
            InitializeComponent();
            ResetCus();
            if (UniversalUser.Ins.account.TYPE > 0)
                btbDelete2.Enabled = false;
            LoadDataCusDGV();
        }
        void ResetCus()
        {
            currentSelectedCustomer = null;
            isUpdate = false;
            txtCID.Text = txtHOTEN.Text = txtSDT.Text = txtEmail.Text = txtDIACHI.Text = "";
            btbAdd.Text = "Thêm";
            cbcSearchSDT.Text = "";
            btbDelete2.Enabled = false;
            btbAdd.Enabled = true;
        }
        void LoadDataCusDGV()
        {
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = DataProvider.Instance.db.CHUXEs.ToList<CHUXE>();
            cbcSearchSDT.DataSource = dgvCustomer.DataSource;
            cbcSearchSDT.DisplayMember = "DIENTHOAI";
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            btbAdd.Enabled = false;
            if (isUpdate)
            {
                if (txtSDT.Text == "" || txtHOTEN.Text == "")
                {
                    MessageBox.Show("Số điện thọai hoặc họ tên không được để trống, Vui lòng thử lại", "Nhập lại");
                    btbAdd.Enabled = true;
                    return;
                }
                if (DataProvider.Instance.CustomerCheckContainerSDT(txtSDT.Text, currentSelectedCustomer))
                {
                    MessageBox.Show("Số điện thọai này đã tồn tại, số điện thoại phải là duy nhất", "Lỗi");
                    btbAdd.Enabled = true;
                    return;
                }

                currentSelectedCustomer.DIENTHOAI = txtSDT.Text;
                currentSelectedCustomer.TENCHUXE = txtHOTEN.Text;
                currentSelectedCustomer.EMAIL = txtEmail.Text;
                currentSelectedCustomer.DIACHI = txtDIACHI.Text;
                DataProvider.Instance.UpdateCustomer(currentSelectedCustomer, ResetCus);
            }
            else
            {
                if (txtSDT.Text == "" || txtHOTEN.Text == "")
                {
                    MessageBox.Show("Số điện thọai hoặc họ tên không được để trống, Vui lòng thử lại", "Nhập lại");
                    btbAdd.Enabled = true;
                    return;
                }
                if (cbcSearchSDT.FindString(txtSDT.Text) > -1)
                {
                    MessageBox.Show("Số điện thọai này đã tồn tại, số điện thoại phải là duy nhất", "Lỗi");
                    btbAdd.Enabled = true;
                    return;
                }
                currentSelectedCustomer = new CHUXE();
                currentSelectedCustomer.DIENTHOAI = txtSDT.Text;
                currentSelectedCustomer.TENCHUXE = txtHOTEN.Text;
                currentSelectedCustomer.EMAIL = txtEmail.Text;
                currentSelectedCustomer.DIACHI = txtDIACHI.Text;
                DataProvider.Instance.SaveCustomer(currentSelectedCustomer, ResetCus);
            }
        }

        private void btbCancel_Click(object sender, EventArgs e)
        {
            ResetCus();
        }

        private void btbDelete2_Click(object sender, EventArgs e)
        {
            if (currentSelectedCustomer == null) return;
            btbDelete2.Enabled = false;
            DataProvider.Instance.DeleteCustomer(currentSelectedCustomer, ResetCus);
        }
        void UpdateViewDataCus(CHUXE cHUXE)
        {
            if (UniversalUser.Ins.account.TYPE < 1)
                btbDelete2.Enabled = true;
            else
                btbDelete2.Enabled = false;
            txtCID.Text = cHUXE.MACHUXE.ToString();
            txtHOTEN.Text = cHUXE.TENCHUXE;
            txtSDT.Text = cHUXE.DIENTHOAI;
            txtEmail.Text = cHUXE.EMAIL;
            txtDIACHI.Text = cHUXE.DIACHI;
        }
        private void dgvCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCustomer.CurrentRow.Index != -1)
            {
                currentSelectedCustomer = new CHUXE();
                currentSelectedCustomer.MACHUXE = Convert.ToInt32(dgvCustomer.CurrentRow.Cells[0].Value);
                currentSelectedCustomer.TENCHUXE = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
                currentSelectedCustomer.DIENTHOAI = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
                currentSelectedCustomer.EMAIL = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
                currentSelectedCustomer.DIACHI = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
                UpdateViewDataCus(currentSelectedCustomer);
                btbAdd.Text = "Cập nhật";
                isUpdate = true;
            }
            else
            {
                ResetCus();
            }
        }

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            dgvCustomer_CellMouseClick(sender, null);
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
        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReloadDataEvent.Ins.RemoveListerner(LoadDataCusDGV, DataType.Customer);
            DiposeToRoot(this);
        }
    }
}
