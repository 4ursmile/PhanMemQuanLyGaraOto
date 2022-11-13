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
            AddBinding();
        }

        ListUser users;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void SaveUser()
        {
            if (UserComboBox.FindString(UserComboBox.Text) < 0 && SaveUserCheckBox.Checked)
            {
                users.ListU.Add(new User { UserName = UserComboBox.Text, Password = PassWordText.Text });
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
                UserComboBox.SelectedIndex = users.SelectedIndex;
                UserComboBox.DisplayMember = "UserName";
                SaveUserCheckBox.Checked = users.isCheckd;
            }
        }
        void AddBinding()
        {
            PassWordText.DataBindings.Add(new Binding("Text", UserComboBox.DataSource, "Password"));
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
            SaveUser();
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            mainForm.Dispose();
            LoadUser();
            this.Show();
        }
        void DeleteUser()
        {
            User user = UserComboBox.SelectedValue as User;
            if (users.ListU.Contains(user))
            {
                users.ListU.Remove(user);
                UserComboBox.DataSource =users.ListU.ToList();
                users.SelectedIndex = 0;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
    }
}
