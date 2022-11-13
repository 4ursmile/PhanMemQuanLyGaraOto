using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto
{
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
            NumberChart.Titles[0].Text = ("Số lượng khách hàng trong ngày");
            NumberChart.Series[0].Points.AddXY("Đã tiếp nhận", 30);
            NumberChart.Series[0].Points.AddXY("Còn trống", 70);
            NumberChart.Series[0].Points[0].Color = Color.PaleVioletRed;
            NumberChart.Series[0].Points[1].Color = Color.PaleTurquoise;

        }

        private void NumberChart_Click(object sender, EventArgs e)
        {

        }
    }
}
