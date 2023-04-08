using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EN_VN_Lib
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            loadLanguage(GlobalVariable.isVietnameseLanguage);
            loadInfo();
        }

        private void loadInfo()
        {
            bool isLoggedIn = GlobalVariable.loggedInAccount != null;
            button_Login.Visible = !isLoggedIn;
            pictureBox_Logout.Visible = isLoggedIn;
            label_Username.Visible = isLoggedIn;
            textBox_Username.Visible = isLoggedIn;
            textBox_Username.Text = isLoggedIn ? GlobalVariable.loggedInAccount.Username +" (" + GlobalVariable.loggedInAccount.Role+")" : string.Empty;
        }

        private void loadLanguage(bool isVN)
        {
            pictureBox_EN.Visible = !isVN;
            pictureBox_VN.Visible = isVN;
            this.Text = isVN ? "Cài đặt" : "Settings";
            label_Language.Text = isVN ? "Ngôn ngữ:" : "Language:";
            label_Username.Text = isVN ? "Tài khoản đăng nhập:" : "Logged in account:";
            button_Login.Text = isVN ? "Đăng nhập" : "Login";
        }

        private void pictureBox_VN_Click(object sender, EventArgs e)
        {
            SetLanguage(false);
            loadLanguage(GlobalVariable.isVietnameseLanguage);
        }

        private void pictureBox_EN_Click(object sender, EventArgs e)
        {
            SetLanguage(true);
            loadLanguage(GlobalVariable.isVietnameseLanguage);
        }
        private void SetLanguage(bool isVN)
        {
            GlobalVariable.isVietnameseLanguage = isVN;
            GlobalVariable.database.saveSettings(GlobalVariable.isVietnameseLanguage, GlobalVariable.selectedDictionary);
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.FormClosed += new FormClosedEventHandler(LoadForm);
            login.Show();
        }

        private void LoadForm(object sender, FormClosedEventArgs e)
        {
            loadInfo();
        }

        private void pictureBox_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(GlobalVariable.isVietnameseLanguage? "Bạn có thực sự muốn đăng xuất?":"Do you want to logout?",
                                                    GlobalVariable.isVietnameseLanguage? "Đăng xuất":"Logout",
                                                    MessageBoxButtons.OKCancel,
                                                    MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                GlobalVariable.loggedInAccount = null;
                loadInfo();
            }
        }
    }
}
