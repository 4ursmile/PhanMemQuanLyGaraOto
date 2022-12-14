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
        public CarForm()
        {
            ReloadDataEvent.Ins.Addlistener(LoadToDGVCarComplex, DataType.Car, DataType.Brand, DataType.Customer);
            InitializeComponent();
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
    }
}
