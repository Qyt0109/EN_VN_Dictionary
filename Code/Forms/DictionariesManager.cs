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
    public partial class DictionariesManager : Form
    {
        public DictionariesManager()
        {
            InitializeComponent();
            LoadDictionaries();
        }

        private void button_AddNewDictionary_Click(object sender, EventArgs e)
        {
            DictionaryInfo dictionaryInfo = new DictionaryInfo();
            dictionaryInfo.FormClosed += new FormClosedEventHandler(LoadForm);
            dictionaryInfo.Show();
        }

        private void LoadDictionaries()
        {
            this.Text = GlobalVariable.isVietnameseLanguage ? "Quản lý từ điển" : "Dictionary manager";
            label_Search.Text = GlobalVariable.isVietnameseLanguage ? "Từ điển đã chọn:" : "Selected dictionary:";
            textBox_SelectedDictionary.Text = GlobalVariable.selectedDictionary;

            dataGridView_Dictionaries.Rows.Clear();
            dataGridView_Dictionaries.ColumnCount = 2;
            dataGridView_Dictionaries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Add header
            dataGridView_Dictionaries.Rows.Add(new string[] { GlobalVariable.isVietnameseLanguage? "Tên từ điển" : "Dictionary name", GlobalVariable.isVietnameseLanguage ? "Số lượng bản dịch" : "Translations count" });
            dataGridView_Dictionaries.Rows[0].Frozen = true;

            GlobalVariable.database.loadDB();
            foreach (var dictionary in GlobalVariable.database.getDictionaries())
            {
                // Add translation row to DataGridView
                dataGridView_Dictionaries.Rows.Add(new string[] { dictionary.name, dictionary.translations.Count().ToString() });
            }
        }

        private void dataGridView_Dictionaries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is clicked
            {
                DataGridViewRow row = dataGridView_Dictionaries.Rows[e.RowIndex];
                // Get the value of each cell in the clicked row
                string dictionaryName = row.Cells[0].Value.ToString();
                DictionaryInfo translationInfoForm = new DictionaryInfo(dictionaryName);
                translationInfoForm.FormClosed += new FormClosedEventHandler(LoadForm);
                translationInfoForm.Show();
            }
        }
        
        private void LoadForm(object sender, FormClosedEventArgs e)
        {
            LoadDictionaries();
        }
    }
}
