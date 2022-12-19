using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.Model;
using PhanMemQuanLyGaraOto.SubForm.SubSubForm;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.SubForm
{
    public partial class ToolForm : Form
    {
        bool isUpdateTool = false;
        PHUTUNG currentPHUTUNG;
        public ToolForm()
        {
            InitializeComponent();
            isUpdateTool = false;
            ReloadDataEvent.Ins.Addlistener(LoadData2DGVPhuTung, DataType.Tool);
            ReloadDataEvent.Ins.Addlistener(LoadData2DGVPHUTUNGasync, DataType.FixDetail);
            ResetToolView();
            LoadData2DGVPhuTung();
        }
        void LoadData2DGVPhuTung()
        {
            dgvPHUTUNG.AutoGenerateColumns = false;
            dgvPHUTUNG.DataSource = DataProvider.Instance.db.PHUTUNGs.ToList<PHUTUNG>();
            cbcTenPT.DataSource = dgvPHUTUNG.DataSource;
            cbcTenPT.DisplayMember = "TENPHUTUNG"; 
        }
        async void LoadData2DGVPHUTUNGasync()
        {
            dgvPHUTUNG.AutoGenerateColumns = false;
            dgvPHUTUNG.DataSource = await Task.Run(() => DataProvider.Instance.GetPHUTUNGs());
            cbcTenPT.DataSource = dgvPHUTUNG.DataSource;
            cbcTenPT.DisplayMember = "TENPHUTUNG";
        }
        void ResetToolView()
        {
            btbDELETEB.Enabled = false;
            btbADDB.Enabled = true;
            btbADDB.Text = "Thêm";
            isUpdateTool = false;
            txtTenPT.Text = cbcTenPT.Text = "";
            nudGiaPT.Value = nudSLPT.Value = 0;
            currentPHUTUNG = null;
        }
        void DisplayMemberPhuTung(PHUTUNG pHUTUNG)
        {
            txtTenPT.Text = pHUTUNG.TENPHUTUNG;
            nudSLPT.Value = (int)pHUTUNG.SOLUONGTON;
            nudGiaPT.Value = (decimal)pHUTUNG.DONGIA;
            btbDELETEB.Enabled = true;
            btbADDB.Text = "Cập nhật";
            isUpdateTool = true;

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
        private void ToolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReloadDataEvent.Ins.RemoveListerner(LoadData2DGVPhuTung, DataType.Tool);
            ReloadDataEvent.Ins.RemoveListerner(LoadData2DGVPHUTUNGasync, DataType.FixDetail);
            DiposeToRoot(this);
        }

        private void btbADDB_Click(object sender, System.EventArgs e)
        {
            btbADDB.Enabled = false;
            if (isUpdateTool)
            {
                if (txtTenPT.Text == "")
                {
                    MessageBox.Show("Tên phụ tùng không được để trống");
                    btbADDB.Enabled = true;
                    return;
                }
                currentPHUTUNG.TENPHUTUNG = txtTenPT.Text;
                currentPHUTUNG.SOLUONGTON = (int)nudSLPT.Value;
                currentPHUTUNG.DONGIA = nudGiaPT.Value;
                DataProvider.Instance.UpdateTool(currentPHUTUNG);
                ResetToolView();

            }
            else
            {
                if (txtTenPT.Text == "")
                {
                    MessageBox.Show("Tên phụ tùng không được để trống");
                    btbADDB.Enabled = true;
                    return;
                }
                currentPHUTUNG = new PHUTUNG();
                currentPHUTUNG.TENPHUTUNG = txtTenPT.Text;
                currentPHUTUNG.SOLUONGTON = (int)nudSLPT.Value;
                currentPHUTUNG.DONGIA = nudGiaPT.Value;
                DataProvider.Instance.SaveTool(currentPHUTUNG);
                ResetToolView();
            }
        }

        private void ToolForm_Load(object sender, System.EventArgs e)
        {

        }

        private void btbDELETEB_Click(object sender, System.EventArgs e)
        {
            if (currentPHUTUNG == null) return;
            DataProvider.Instance.DeleteTool(currentPHUTUNG,ResetToolView);
        }

        private void btbCANCLEB_Click(object sender, System.EventArgs e)
        {
            ResetToolView();
        }

        private void dgvPHUTUNG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPHUTUNG.CurrentRow.Index > -1)
            {
                DataGridViewRow data = dgvPHUTUNG.CurrentRow;
                currentPHUTUNG = data.DataBoundItem as PHUTUNG;
                DisplayMemberPhuTung(currentPHUTUNG);
            } else
            {
                ResetToolView();
            }
        }

        private void dgvPHUTUNG_SelectionChanged(object sender, System.EventArgs e)
        {
            dgvPHUTUNG_CellMouseClick(sender, null);
        }

        private void label4_Click(object sender, System.EventArgs e)
        {
            LoadData2DGVPhuTung();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
