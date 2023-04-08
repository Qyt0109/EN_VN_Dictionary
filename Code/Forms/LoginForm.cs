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
    public partial class Form_Login : Form
    {
        string LoginFormTitleVN = "Đăng nhập";
        string LoginFormTitleEN = "Login";
        string AppNameVN = "TỪ ĐIỂN ANH VIỆT";
        string AppNameEN = "English Vietnamese Dictionary";
        string UsernameVN = "Tên đăng nhập:";
        string UsernameEN = "Username:";
        string PasswordEN = "Password:";
        string PasswordVN = "Mật khẩu:";
        string LangVN = "Ngôn ngữ:";
        string LangEN = "Language:";

        string LoggedInSuccessfullyTitleVN = "Đăng nhập thành công!";
        string LoggedInSuccessfullyTitleEN = "Logged in successfully!";
        string WelcomeVN = "Chào mừng";
        string WelcomeEN = "Welcome";
        string LoggedInFailedTitleVN = "Đăng nhập thất bại!";
        string LoggedInFailedTitleEN = "Logged in failed!";
        string MissingVN = "Thiếu thông tin đăng nhập!";
        string MissingEN = "Missing login information";
        string FailedVN = "Xin hãy kiểm tra lại thông tin đăng nhập";
        string FailedEN = "Please check your login information again";


        bool isHidePassword = true;
        public Form_Login()
        {
            InitializeComponent();
            SetLanguage(isVN: GlobalVariable.isVietnameseLanguage);
            HidePassword(isHidePassword);
        }

        private void SetLanguage(bool isVN)
        {
            if(isVN)
            {
                this.Text = LoginFormTitleVN;
                label_AppName.Text = AppNameVN;
                label_Username.Text = UsernameVN;
                label_Password.Text = PasswordVN;
            }
            else
            {
                this.Text = LoginFormTitleEN;
                label_AppName.Text = AppNameEN;
                label_Username.Text = UsernameEN;
                label_Password.Text = PasswordEN;
            }
        }

        private void HidePassword(bool isHidePassword)
        {
            pictureBox_ShowPassword.Visible = !isHidePassword;
            pictureBox_HidePassword.Visible = isHidePassword;

            textBox_Password.UseSystemPasswordChar = isHidePassword;
        }

        private void pictureBox_HidePassword_Click(object sender, EventArgs e)
        {
            isHidePassword = !isHidePassword;
            HidePassword(isHidePassword);
        }

        private void pictureBox_ShowPassword_Click(object sender, EventArgs e)
        {
            isHidePassword = !isHidePassword;
            HidePassword(isHidePassword);
        }

        private void pictureBox_VN_Click(object sender, EventArgs e)
        {
            GlobalVariable.isVietnameseLanguage = !GlobalVariable.isVietnameseLanguage;
            SetLanguage(GlobalVariable.isVietnameseLanguage);
        }

        private void pictureBox_EN_Click(object sender, EventArgs e)
        {
            GlobalVariable.isVietnameseLanguage = !GlobalVariable.isVietnameseLanguage;
            SetLanguage(GlobalVariable.isVietnameseLanguage);
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Login(textBox_Username.Text, textBox_Password.Text);
        }

        private void Login(string username, string password)
        {
            if (isValidate())
            {
                GlobalVariable.database.loadDB();
                foreach (var account in GlobalVariable.database.getAccounts())
                {
                    // lấy dữ liệu từ các cột trong mỗi dòng
                    if (username == account.Username && password == account.Password)
                    {
                        GlobalVariable.loggedInAccount = account;
                        MessageBox.Show(GlobalVariable.isVietnameseLanguage ? WelcomeVN : WelcomeEN + " " + username, GlobalVariable.isVietnameseLanguage ? LoggedInSuccessfullyTitleVN : LoggedInSuccessfullyTitleEN, MessageBoxButtons.OK);
                        this.Close();
                        break;
                    }
                }

                if (GlobalVariable.loggedInAccount == null)
                    MessageBox.Show(GlobalVariable.isVietnameseLanguage ? FailedVN : FailedEN, GlobalVariable.isVietnameseLanguage ? LoggedInFailedTitleVN : LoggedInFailedTitleEN, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(GlobalVariable.isVietnameseLanguage ? MissingVN : MissingEN, GlobalVariable.isVietnameseLanguage ? LoggedInFailedTitleVN : LoggedInFailedTitleEN, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isValidate()
        {
            if (string.IsNullOrEmpty(textBox_Username.Text) || string.IsNullOrEmpty(textBox_Password.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
