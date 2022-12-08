using PhanMemQuanLyGaraOto.DDo;
using PhanMemQuanLyGaraOto.SubForm.SubSubForm;
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
        #region Init
        public MainForm()
        {
            ExitInforHolder.isQuit = true;
            InitializeComponent();
            currentButton = AccountButton;
            SubFormInit();
            currentButton.BackColor = selectColor;
            MenuButton_Click(AccountButton as object,null);

            SetInformation();
        }
        void SetInformation()
        {
            DesLabel.Text = PosNameMap.GetAccountPosName((int)UniversalUser.Ins.account.TYPE);
            NameLabel.Text = UniversalUser.Ins.account.DISPLAYNAME;

        }
        void SubFormInit()
        {
            dicOfForms = new Dictionary<Button, Form>();
            dicOfForms.Add(AccountButton, new SubForm.AccountForm());
            dicOfForms.Add(Carbutton, new SubForm.CarForm());
            dicOfForms.Add(CustomerButton, new SubForm.CustomerForm());
            dicOfForms.Add(BrandButton, new SubForm.BrandForm());
            dicOfForms.Add(ToolButton, new SubForm.ToolForm());
            dicOfForms.Add(ReportButton, new SubForm.ReportForm());
            dicOfForms.Add(PolicyButton, new SubForm.PolicyForm());

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
        #endregion
        #region Event
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitInforHolder.isQuit = false;
            this.Close();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitInforHolder.isQuit = true;
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UniversalAlert.Ins.AddListener(SetInformation);
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string target = "https://www.linkedin.com/in/bao-ly-tran-hoang-252739229/";
            System.Diagnostics.Process.Start(target);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UniversalAlert.Ins.RemoveListenr(SetInformation);
        }
        #endregion

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassForm cpform = new ChangePassForm();
            cpform.ShowDialog();
        }
    }
}
