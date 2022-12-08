using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Configuration;
using System.Xml;
using PhanMemQuanLyGaraOto.Model;
using PhanMemQuanLyGaraOto.DDo;

namespace PhanMemQuanLyGaraOto
{
    public partial class LoginForm : KryptonForm
    {

        public LoginForm()
        {
            InitializeComponent();
            LoiChucInit();
            users = new ListUser { ListU = new List<User>(), SelectedIndex = 0};
            LoadUser();

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
            } else
            {
                users.ListU[findindex].Password = PassWordText.Text;
            }
            users.isCheckd = SaveUserCheckBox.Checked;
            users.SelectedIndex = UserComboBox.SelectedIndex;
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
                List<User> listuser = users.ListU.ToList();
                UserComboBox.DataSource = listuser;
                UserComboBox.SelectedIndex = listuser.Count == 0? -1: users.SelectedIndex;
                UserComboBox.DisplayMember = "UserName";
                SaveUserCheckBox.Checked = users.isCheckd;
                PassWordText.DataBindings.Clear();
                AddBinding();
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
            else if (timeSpan.Hours >= 19 && timeSpan.Hours <23)
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
        
        private void SigninButton_MouseClick(object sender, MouseEventArgs e)
        {

            ACCOUNT account;
            if (DDOpassword.Ins.CheckPassWord(UserComboBox.Text, PassWordText.Text,out account))
            {
                SigninAction(account);
            } else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mặt khẩu vui lòng thử lại sau");
            }
           
        }
        void SigninAction(ACCOUNT aCCOUNT)
        {
            UniversalUser.Ins.SetUser(aCCOUNT);
            SaveUser();
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            mainForm.Dispose();
            LoadUser();
            if (ExitInforHolder.isQuit)
            {
                Application.Exit();
            } else
            {
                this.Show();
            }
        }
        void DeleteUser()
        {
            User user = UserComboBox.SelectedValue as User;
            if (users.ListU.Contains(user))
            {
                users.ListU.Remove(user);
                UserComboBox.DataSource =users.ListU.ToList();
                users.SelectedIndex = users.ListU.Count == 0? -1 : 0;
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

        private void PassWordText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
