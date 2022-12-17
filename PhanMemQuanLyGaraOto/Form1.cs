using CommunityToolkit.WinUI.Notifications;
using ComponentFactory.Krypton.Toolkit;
using PhanMemQuanLyGaraOto.DDo;
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace PhanMemQuanLyGaraOto
{
    public partial class LoginForm : KryptonForm
    {

        public LoginForm()
        {
            InitializeComponent();
            LoiChucInit();
            users = new ListUser { ListU = new List<User>(), SelectedIndex = 0 };
            LoadUser();
            ToastNotificationManagerCompat.History.Clear();
        }

        ListUser users;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void SaveUser()
        {
            int findindex = UserComboBox.FindString(UserComboBox.Text);
            if (findindex < 0 && SaveUserCheckBox.Checked)
            {
                users.ListU.Add(new User { UserName = UserComboBox.Text, Password = PassWordText.Text });
            }
            else
            {
                if (users.ListU.Count == 0) goto SAVE;
                users.ListU[findindex].Password = PassWordText.Text;
            }
        SAVE:
            users.isCheckd = SaveUserCheckBox.Checked;
            users.SelectedIndex = users.ListU.Count == 0 ? -1 : UserComboBox.SelectedIndex;
            if (users.ListU.Count > 0 && UserComboBox.SelectedIndex == -1)
            {
                users.SelectedIndex = 0;
            }
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

            string jsonFile = JsonSerializer.Serialize<ListUser>(users, options);
            if (!Directory.Exists(Application.UserAppDataPath + "/SystemConsoleLog/Mirage"))
                Directory.CreateDirectory(Application.UserAppDataPath + "/SystemConsoleLog/Mirage");
            File.WriteAllText(Application.UserAppDataPath + "/SystemConsoleLog/Mirage/isaac32.json", jsonFile);
        }
        void LoadUser()
        {
            if (File.Exists(Application.UserAppDataPath + "/SystemConsoleLog/Mirage/isaac32.json"))
            {

                string path = Application.UserAppDataPath + "/SystemConsoleLog/Mirage/isaac32.json";
                string jsonfile = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<ListUser>(jsonfile);

                UserComboBox.DataSource = users.ListU.ToList();
                UserComboBox.SelectedIndex = users.ListU.Count == 0 ? -1 : users.SelectedIndex;
                if (users.ListU.Count > 0 && UserComboBox.SelectedIndex == -1)
                {
                    UserComboBox.SelectedIndex = 0;
                }
                UserComboBox.DisplayMember = "UserName";
                SaveUserCheckBox.Checked = users.isCheckd;

            }
        }
        void AddBinding()
        {
            PassWordText.DataBindings.Add("Text", UserComboBox.DataSource, "Password", true);
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
            else if (timeSpan.Hours >= 19 && timeSpan.Hours < 23)
                Loichucdau.Text = "Chào buổi tối";
            else
                Loichucdau.Text = "Chúc ngủ ngon";

        }

        private void Loichucdau_Click(object sender, EventArgs e)
        {
            string password = "garavuive";
            Clipboard.SetText(SuperHash.GetHashPassWord(password));
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

        void SwitchStateAll(bool state)
        {
            foreach (var item in panel1.Controls.OfType<Button>())
                item.Enabled = state;
            foreach (var item in panel1.Controls.OfType<ComboBox>())
                item.Enabled = state;
            foreach (var item in panel1.Controls.OfType<TextBox>())
                item.Enabled = state;

        }
        void SigninAction(ACCOUNT aCCOUNT)
        {
            UniversalUser.Ins.SetUser(aCCOUNT);
            SaveUser();
            LoadUser();
            MainForm mainForm = new MainForm();
            this.Hide();
            this.SuspendLayout();
            mainForm.ShowDialog();
            mainForm.Dispose();
            LoadUser();
            if (ExitInforHolder.isQuit)
            {
                Application.Exit();
            }
            else
            {
                mainForm.Dispose();
                mainForm.Close();
                this.ResumeLayout();
                this.Show();
            }
        }
        void DeleteUser()
        {
            User user = UserComboBox.SelectedValue as User;
            if (users.ListU.Contains(user))
            {
                users.ListU.Remove(user);
                users.SelectedIndex = users.ListU.Count == 0 ? -1 : 0;
                UserComboBox.SelectedIndex = users.SelectedIndex;
                PassWordText.Text = "";

                SaveUser();
                LoadUser();

            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string target = "https://www.linkedin.com/in/bao-ly-tran-hoang-252739229/";
            System.Diagnostics.Process.Start(target);
        }


        private void SigninButton_Click(object sender, EventArgs e)
        {

            SwitchStateAll(false);
            SigninButton.Enabled = false;
            lblLoad.Visible = true;
            ACCOUNT account;
            int resStatus = DDOpassword.Ins.CheckPassWord(UserComboBox.Text, PassWordText.Text, out account);
            if (resStatus == 1)
            {
                SigninAction(account);
            }
            else if (resStatus == 0)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mặt khẩu vui lòng thử lại");
            }
            else
            {
                MessageBox.Show("Kết nối với máy chủ thất bại, Vui lòng thử lại sau", "Từ chối kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SwitchStateAll(true);
            SigninButton.Enabled = true;
            lblLoad.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PassWordText.Text = (UserComboBox.SelectedValue as User).Password;
        }

        private void ptbOld_Click(object sender, EventArgs e)
        {
            char SpecicalChar = '•';
            if (PassWordText.PasswordChar == SpecicalChar)
                PassWordText.PasswordChar = '\0';
            else
                PassWordText.PasswordChar = SpecicalChar;
        }
    }
}
