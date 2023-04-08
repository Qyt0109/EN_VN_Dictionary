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
    public partial class TranslationInfoForm : Form
    {
        string _EN;
        string _VN;
        public TranslationInfoForm()
        {
            InitializeComponent();
            mode(true);
        }

        public TranslationInfoForm(string en, string vn)
        {
            InitializeComponent();
            _EN = en;
            _VN = vn;
            loadToView();
            mode(false);
        }

        private void loadToView()
        {
            textBox_EN.Text = _EN;
            textBox_VN.Text = _VN;
            Text = GlobalVariable.isVietnameseLanguage ? "Bản dịch " + (string.IsNullOrEmpty(_EN) ? "mới" : _EN) : string.IsNullOrEmpty(_EN) ? "New" : _EN + " translation";
        }

        public void mode(bool isAdd)
        {
            button_Add.Visible = isAdd;
            button_Delete.Visible = !isAdd;
            button_Save.Visible = !isAdd;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (GlobalVariable.database.addNewTranslation(GlobalVariable.selectedDictionary, textBox_EN.Text, textBox_VN.Text))
                {
                    MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Đã thêm bản dịch cho " : "Added translation for " + textBox_EN.Text,
                        GlobalVariable.isVietnameseLanguage ? "Thêm bản dịch thành công" : "Translation added successfully",
                        MessageBoxButtons.OK);
                    mode(false);
                }
                else
                {
                    MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Không thể thêm bản dịch cho " : "Can't add translation for " + textBox_EN.Text,
                        GlobalVariable.isVietnameseLanguage ? "Thêm bản dịch thất bại" : "Translation added failed",
                        MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Thông tin còn thiếu, xin hãy kiểm tra lại" : "Missing infomation, please check again",
                        GlobalVariable.isVietnameseLanguage ? "Thêm bản dịch thất bại" : "Translation added failed",
                        MessageBoxButtons.OK);
            

        }

        private bool validate()
        {
            if (string.IsNullOrEmpty(textBox_EN.Text) || string.IsNullOrEmpty(textBox_VN.Text))
            {
                return false;
            }
            else
            {
                // Both textboxes have values
                return true;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Bạn có chắc chắn muốn xoá bản dịch cho " : "Are you sure want to delete translation for " + _EN,
                    GlobalVariable.isVietnameseLanguage ? "Xác nhận xoá?" : "Confirm to delete?",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (GlobalVariable.database.deleteTranslationByEN(GlobalVariable.selectedDictionary, _EN))
                {
                    MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Đã xoá bản dịch cho " : "Deleted translation for " + _EN,
                        GlobalVariable.isVietnameseLanguage ? "Xoá bản dịch thành công" : "Translation deleted successfully",
                        MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Không thể xoá bản dịch cho " : "Can't delete translation for " + textBox_EN.Text,
                        GlobalVariable.isVietnameseLanguage ? "Xoá bản dịch thất bại" : "Translation delete failed",
                        MessageBoxButtons.OK);
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (GlobalVariable.database.updateTranslationByEN(GlobalVariable.selectedDictionary, _EN, textBox_EN.Text, textBox_VN.Text))
                {
                    MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Đã sửa bản dịch cho " : "Changed translation for " + textBox_EN.Text,
                        GlobalVariable.isVietnameseLanguage ? "Sửa bản dịch thành công" : "Translation changed successfully",
                        MessageBoxButtons.OK);
                    mode(false);
                }
                else
                {
                    MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Không thể sửa bản dịch cho " : "Can't change translation for " + textBox_EN.Text,
                        GlobalVariable.isVietnameseLanguage ? "Sửa bản dịch thất bại" : "Translation change failed",
                        MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Thông tin còn thiếu, xin hãy kiểm tra lại" : "Missing infomation, please check again",
                        GlobalVariable.isVietnameseLanguage ? "Sửa bản dịch thất bại" : "Translation added failed",
                        MessageBoxButtons.OK);
        }
    }
}
