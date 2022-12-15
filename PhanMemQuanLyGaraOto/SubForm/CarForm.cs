using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDO;
using PhanMemQuanLyGaraOto.SubForm.SubSubForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.SubForm
{
    public partial class CarForm : Form
    {
        REMCheckCar currentCheckCar;
        public CarForm()
        {
            ReloadDataEvent.Ins.Addlistener(LoadToDGVCarComplex, DataType.Car, DataType.Brand, DataType.Customer);
            InitializeComponent();
            btbcollect.Enabled = false;
            btbUpdate.Enabled = false;
            LoadToDGVCarComplex();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }
        void LoadToDGVCarComplex()
        {
            dgvCheckCars.DataSource = DataProvider.Instance.GetCheckCar();
            cbcBienSo.DataSource = dgvCheckCars.DataSource;
            cbcBienSo.DisplayMember = "CarNumber";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiepNhanForm tiepNhanForm = new TiepNhanForm();
            tiepNhanForm.ShowDialog();
            tiepNhanForm.Dispose();
        }

        private void dgvAccounts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
        private void CarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReloadDataEvent.Ins.RemoveListerner(LoadToDGVCarComplex, DataType.Car, DataType.Brand, DataType.Customer);
            DiposeToRoot(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TiepNhanForm tiepNhanForm = new TiepNhanForm(currentCheckCar);
            tiepNhanForm.ShowDialog();
            tiepNhanForm.Dispose();
        }

        private void dgvCheckCars_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCheckCars.CurrentRow.Index > -1)
            {
                DataGridViewRow cRow = dgvCheckCars.CurrentRow;
                currentCheckCar = (cRow.DataBoundItem as REMCheckCar);
                btbcollect.Enabled = true;
                btbUpdate.Enabled = true;
            } else
            {
                btbcollect.Enabled = false;
                btbUpdate.Enabled = false;
            }
        }

        private void dgvCheckCars_SelectionChanged(object sender, EventArgs e)
        {
            dgvCheckCars_CellMouseClick(sender, null);
        }
    }
}
