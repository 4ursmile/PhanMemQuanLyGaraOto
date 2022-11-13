using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto
{ 

    public partial class MainForm : Form
    {
        Button currentButton;
        Dictionary<Button, Form> dicOfForms;
        Form CurrentForm;
        public MainForm()
        {
            InitializeComponent();
            currentButton = AccountButton;
            SubFormInit();
            currentButton.BackColor = selectColor;
            MenuButton_Click(AccountButton as object,null);


        }
        void SubFormInit()
        {
            dicOfForms = new Dictionary<Button, Form>();
            dicOfForms.Add(AccountButton, new AccountForm());
            dicOfForms.Add(Carbutton, new CarForm());
            dicOfForms.Add(RepairButton, new RepairForm());
            dicOfForms.Add(BillButton, new BillForm());
            dicOfForms.Add(ReportButton, new ReportForm());
            dicOfForms.Add(ToolButton, new ToolForm());
            dicOfForms.Add(PolicyButton, new PolicyForm());

            foreach (var a in dicOfForms)
            {
                a.Value.TopLevel = false;
                a.Value.TopMost = true;
                a.Value.FormBorderStyle = FormBorderStyle.None;
                a.Value.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(a.Value);
            }
            CurrentForm = dicOfForms[currentButton];
            CurrentForm.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
        Color selectColor = Color.FromArgb(60, 126, 150);
       
        private void MenuButton_Click(object sender, EventArgs e)
        {
            Button newButton = sender as Button;
            if (currentButton != newButton )
            {
                currentButton.BackColor = Color.WhiteSmoke;
                CurrentForm.Hide();
                CurrentForm = dicOfForms[newButton];
                FormNameLabel.Text = newButton.Text;
                CurrentForm.Show();
                currentButton = newButton; 
                currentButton.BackColor = selectColor;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
