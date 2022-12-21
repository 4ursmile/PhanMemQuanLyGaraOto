using PhanMemQuanLyGaraOto.DDo;
using PhanMemQuanLyGaraOto.SubForm.SubSubForm;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            MenuButton_Click(AccountButton as object, null);



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
            if (currentButton != newButton)
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
            ExitInforHolder.IsLogout = true;
            ExitInforHolder.isQuit = false;
            this.Close();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình?", "Xác nhận đóng chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No) return;
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
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitInforHolder.isQuit == false)
            {
                if (!ExitInforHolder.IsLogout)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình?", "Xác nhận đóng chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

            }
            UniversalAlert.Ins.RemoveListenr(SetInformation);
            foreach (var k in dicOfForms)
            {
                k.Value.SuspendLayout();
                k.Value.Close();
                k.Value.Dispose();
            }
            DiposeToRoot(this);
            this.SuspendLayout();
            this.Dispose();
        }
        #endregion

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassForm cpform = new ChangePassForm();
            cpform.ShowDialog();
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateInforForm updateInforForm = new UpdateInforForm();
            updateInforForm.ShowDialog();
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string target = "https://www.facebook.com/ly7733";
            System.Diagnostics.Process.Start(target);
        }

        private void linkedinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string target = "https://www.linkedin.com/in/bao-ly-tran-hoang-252739229/";
            System.Diagnostics.Process.Start(target);
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string target = "https://github.com/UIT-21521109";
            System.Diagnostics.Process.Start(target);
        }

        private void điĐếnTrangCàiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuButton_Click(PolicyButton, null);
        }

        private void đếnTrangXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuButton_Click(Carbutton, null);
        }

        private void tiếpNhậnXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.WaitAll();
            TiepNhanForm tiepNhanForm = new TiepNhanForm();
            tiepNhanForm.ShowDialog();
            tiepNhanForm.Dispose();
        }
    }
}
