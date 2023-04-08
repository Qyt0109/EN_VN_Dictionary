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
    public partial class DictionaryInfo : Form
    {
        string unSuccessVN = "Không thể thực hiện";
        string unSuccessEN = "Can't do the action";

        private string _dictionaryName = "";

        public DictionaryInfo()
        {
            InitializeComponent();
            loadToView();
            mode(true);
        }

        public DictionaryInfo(string dictionaryName)
        {
            InitializeComponent();
            _dictionaryName = dictionaryName;
            loadToView();
            mode(false);
        }

        private void mode(bool isAdd)
        {
            button_AddNewTranslation.Visible = isAdd;
            button_Select.Visible = !isAdd;
            button_Delete.Visible = !isAdd;
            button_Save.Visible = !isAdd;
        }
        private void loadToView()
        {
            textBox_DictionaryName.Text = _dictionaryName;
            Text = GlobalVariable.isVietnameseLanguage ? "Từ điển " + _dictionaryName : _dictionaryName + " dictionary";
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (_dictionaryName == GlobalVariable.selectedDictionary)
            {
                MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Không thể xoá từ điển đang được chọn làm dữ liệu cho hệ thống" : "Can't delete selected dictionary",
                                        GlobalVariable.isVietnameseLanguage ? unSuccessVN : unSuccessEN,
                                        MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Bạn có thật sự muốn xoá từ điển " + _dictionaryName : "Are you sure want to delete " + _dictionaryName,
                    GlobalVariable.isVietnameseLanguage ? "Xác nhận xoá?" : "Confirm to delete?",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                    );
                if (result == DialogResult.OK)
                {
                    if (GlobalVariable.database.deleteDictionary(_dictionaryName))
                    {

                        MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Đã xoá từ điển " + _dictionaryName : _dictionaryName + " dictionary deleted",
                                        GlobalVariable.isVietnameseLanguage ? "Xoá từ điển thành công!" : "Delete dictionary successfully!",
                                        MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Không thể xoá từ điển, xin hãy kiểm tra lại" : "Can't delete dictionary, please check again",
                                        GlobalVariable.isVietnameseLanguage ? unSuccessVN : unSuccessEN,
                                        MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void button_AddNewTranslation_Click(object sender, EventArgs e)
        {
            if (GlobalVariable.database.addNewDictonary(textBox_DictionaryName.Text))
            {

                MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Đã thêm từ điển " + textBox_DictionaryName.Text : textBox_DictionaryName.Text +" dictionary added",
                                GlobalVariable.isVietnameseLanguage ? "Thêm từ điển thành công!" : "Add new dictionary successfully!",
                                MessageBoxButtons.OK);
                _dictionaryName = textBox_DictionaryName.Text;
                loadToView();
                mode(false);
            }
            else
            {
                MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Không thể thêm từ điển, xin hãy kiểm tra lại" : "Can't add new dictionary, please check again",
                                GlobalVariable.isVietnameseLanguage ? unSuccessVN : unSuccessEN,
                                MessageBoxButtons.OK);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (GlobalVariable.database.updateDictionaryName(_dictionaryName, textBox_DictionaryName.Text))
            {

                MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Tên cũ: "+_dictionaryName+"\nTên mới: "+textBox_DictionaryName.Text : "Old name: " + _dictionaryName + "\nNew name: " + textBox_DictionaryName.Text,
                                GlobalVariable.isVietnameseLanguage ? "Cập nhật tên từ điển thành công!" : "Update dictionary name successfully!",
                                MessageBoxButtons.OK);
                _dictionaryName = textBox_DictionaryName.Text;
                loadToView();
            }
            else
            {
                MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Không thể cập nhật, xin hãy kiểm tra lại": "Can't update, please check again",
                                GlobalVariable.isVietnameseLanguage ? unSuccessVN : unSuccessEN,
                                MessageBoxButtons.OK);
            }
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            GlobalVariable.selectedDictionary = _dictionaryName;
            GlobalVariable.database.saveSettings(GlobalVariable.isVietnameseLanguage, _dictionaryName);
            MessageBox.Show(GlobalVariable.isVietnameseLanguage ? "Đã chọn từ điển: " + _dictionaryName : "Selected " + _dictionaryName + "dictionary",
                            GlobalVariable.isVietnameseLanguage ? "Áp dụng thành công" : "Successfully applied",
                            MessageBoxButtons.OK);
        }
    }
}
