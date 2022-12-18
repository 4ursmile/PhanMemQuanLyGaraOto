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
    public partial class BillForm : Form
    {
        REMCheckCar checkCar;
        public BillForm(REMCheckCar cCar = null)
        {
            if (cCar == null)
            {
                this.Close();
                return;
            }
            InitializeComponent();
            checkCar = cCar;
            Loadinfo();
        }
        async void Loadinfo()
        {
            txtTen.Text = checkCar.CarOwnerName;
            txtSDT.Text = checkCar.CarOwnerTele;
            txtBienSo.Text = checkCar.CarNumber;
            dtpNgayLap.MaxDate = DateTime.Today;
            numericUpDown1.Maximum = checkCar.DebtMoney;
            numericUpDown1.Value = checkCar.DebtMoney;
            txtEmail.Text = await DataProvider.Instance.GetCarOwnerEmailAsync(checkCar.CarOwnerTele);

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BillForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbDongPhieu_Click(object sender, EventArgs e)
        {
            PHIEUTHUTIEN phieuThu = new PHIEUTHUTIEN();
            phieuThu.MAXE = checkCar.CarId;
            phieuThu.NGAYTHU = dtpNgayLap.Value;
            phieuThu.SOTIENTHU = numericUpDown1.Value;
            DataProvider.Instance.SavePHIEUTHU(phieuThu);
            this.Close();
        }
    }
}
