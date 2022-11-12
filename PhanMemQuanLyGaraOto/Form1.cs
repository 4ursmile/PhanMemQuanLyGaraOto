using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace PhanMemQuanLyGaraOto
{
    public partial class LoginForm : KryptonForm
    {

        public LoginForm()
        {
            InitializeComponent();
            LoiChucInit();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        void LoiChucInit()
        {
            TimeSpan timeSpan = DateTime.Now.TimeOfDay;
            if (timeSpan.Hours > 3 && timeSpan.Hours < 11)
                Loichucdau.Text = "Chào buổi sáng";
            else if (timeSpan.Hours >= 11 && timeSpan.Hours < 13)
                Loichucdau.Text = "chào buổi trưa";
            else if (timeSpan.Hours >= 13 && timeSpan.Hours < 19)
                Loichucdau.Text = "chào buổi chiều";
            else if (timeSpan.Hours >= 19 && timeSpan.Hours <23)
                Loichucdau.Text = "Chào buổi tối";
            else
                Loichucdau.Text = "Chúc ngủ ngon";

        }

        private void Loichucdau_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void SigninButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            mainForm.Dispose();
            this.Show();
        }
    }
}
