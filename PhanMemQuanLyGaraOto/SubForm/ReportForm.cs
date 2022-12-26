using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.DDO;
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto.SubForm
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            LoadMonthTimeData();
        }
        void LoadMonthTimeData()
        {
            cbcYear.DataSource = cbcNamTon.DataSource = MonthAndYearList.Ins.getListYear();
            cbcMonth.DataSource = cbcThangTon.DataSource =  MonthAndYearList.Ins.getListMonth(Convert.ToInt32(cbcYear.Text));
            cbcMonth.SelectedIndex = DateTime.Today.Month -1;
        }
        private void ReportForm_Load(object sender, System.EventArgs e)
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
        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DiposeToRoot(this);
        }

        private void label2_Click(object sender, System.EventArgs e)
        {
            
        }

        private void cbcYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbcMonth.DataSource = cbcThangTon.DataSource = MonthAndYearList.Ins.getListMonth(Convert.ToInt32(cbcYear.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
        async void LoadBaoCao()
        {
            Task.WaitAll();
            int thang = Convert.ToInt16(cbcMonth.Text);
            int nam = Convert.ToInt16(cbcYear.Text);
            dgvCheckCars.DataSource = await DataProvider.Instance.GetBaoCaosAsync(thang,nam);
            decimal Total = (decimal)(dgvCheckCars.DataSource as List<CustomBaoCao>).Sum(a => a.tongTien);
            txtThanhTien.Text = Total.ToString("c0");
        }
        async void LoadBaoCaoTon()
        {
            Task.WaitAll();
            int thang = Convert.ToInt16(cbcThangTon.Text);
            int nam = Convert.ToInt16(cbcNamTon.Text);
            dgvBaoCaoTon.DataSource = await DataProvider.Instance.GETBAOCAOTONsAsync(thang,nam);
        }

        private void dgvCheckCars_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvCheckCars.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbBaocaoTon_Click(object sender, EventArgs e)
        {
            LoadBaoCaoTon();
        }

        private void dgvBaoCaoTon_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvBaoCaoTon.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        void ExportExecelCheckCar(DataGridView dgv)
        {
            Microsoft.Office.Interop.Excel.ApplicationClass excelSheet = new Microsoft.Office.Interop.Excel.ApplicationClass();
            excelSheet.Application.Workbooks.Add(Type.Missing);
            for(int i = 1; i< dgv.Columns.Count + 1; i++)
            {
                    excelSheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            for(int i =  0; i<dgv.Rows.Count ; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    string str = dgv.Rows[i].Cells[j].Value?.ToString() ?? "0";
                    float sdd;
                    bool isFloat = float.TryParse(str, out sdd);
                    if (isFloat)
                        excelSheet.Cells[i + 2, j + 1] = sdd.ToString("N");
                    else
                        excelSheet.Cells[i + 2, j + 1] = str;


                }
            }
            excelSheet.Columns.AutoFit();
            excelSheet.Visible = true;

        }
        void ExportExecelSLTON(DataGridView dgv)
        {
            Microsoft.Office.Interop.Excel.ApplicationClass excelSheet = new Microsoft.Office.Interop.Excel.ApplicationClass();
            excelSheet.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                excelSheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    string str = dgv.Rows[i].Cells[j].Value?.ToString() ?? "0";
                    excelSheet.Cells[i + 2, j + 1] = str;
                }
            }
            excelSheet.Columns.AutoFit();
            excelSheet.Visible = true;

        }
        private async void btbBaoCaoExport_Click(object sender, EventArgs e)
        {
            btbBaocaoTon.Enabled = false;
            if (dgvBaoCaoTon.Rows.Count > 0)
            {
                await Task.Run(() => ExportExecelSLTON(dgvBaoCaoTon));
            }
            btbBaocaoTon.Enabled = true;
        }

        private async void btbbcExport_Click(object sender, EventArgs e)
        {
            btbBaoCao.Enabled = false;
            if (dgvCheckCars.Rows.Count > 0)
            {
                await Task.Run(() => ExportExecelCheckCar(dgvCheckCars));
            }
            btbBaoCao.Enabled = true;
        }
    }
}
