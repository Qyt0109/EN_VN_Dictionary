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
    public partial class DictionaryForm : Form
    {
        bool isAdmin = false;
        public DictionaryForm()
        {
            InitializeComponent();
            LoadDictionary();
            checkPermission();
        }

        private void checkPermission()
        {
            isAdmin = GlobalVariable.loggedInAccount == null ? false : GlobalVariable.loggedInAccount.Role == "Admin";
            button_DictionaryManager.Visible = isAdmin;
            button_AddNewTranslation.Visible = isAdmin;
            if (isAdmin)
            {
                dataGridView_Translations.CellDoubleClick -= dataGridView_Translations_CellDoubleClick;
                dataGridView_Translations.CellDoubleClick += dataGridView_Translations_CellDoubleClick;
            }
            else
            {
                dataGridView_Translations.CellDoubleClick -= dataGridView_Translations_CellDoubleClick;
            }
        }

        private void button_Setting_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.FormClosed += new FormClosedEventHandler(LoadForm);
            settingsForm.Show();
        }

        private void LoadForm(object sender, FormClosedEventArgs e)
        {
            LoadDictionary();
            checkPermission();
        }

        private void LoadDictionary()
        {
            this.Text = GlobalVariable.isVietnameseLanguage ? "Từ điển Anh-Việt" : "English-Vietnamese dictionary";
            label_Search.Text = GlobalVariable.isVietnameseLanguage ? "Tìm kiếm:" : "Search:";
            dataGridView_Translations.Rows.Clear();
            dataGridView_Translations.ColumnCount = 2;
            dataGridView_Translations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Add header
            dataGridView_Translations.Rows.Add(new string[] { GlobalVariable.isVietnameseLanguage ? "Tiếng Anh" : "English", GlobalVariable.isVietnameseLanguage ? "Tiếng Việt":"Vietnamese" });
            dataGridView_Translations.Rows[0].Frozen = true;

            GlobalVariable.database.loadDB();
            foreach (var translation in GlobalVariable.database.getDictionaries().Where(d => d.name == GlobalVariable.selectedDictionary).FirstOrDefault().translations)
            {
                // Add translation row to DataGridView
                dataGridView_Translations.Rows.Add(new string[] { translation.EN, translation.VN });
            }
        }

        private void Search(string searchText)
        {
            this.Text = GlobalVariable.isVietnameseLanguage ? "Từ điển Anh-Việt" : "English-Vietnamese dictionary";
            label_Search.Text = GlobalVariable.isVietnameseLanguage ? "Tìm kiếm:" : "Search:";
            dataGridView_Translations.Rows.Clear();
            dataGridView_Translations.ColumnCount = 2;
            dataGridView_Translations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Add header
            dataGridView_Translations.Rows.Add(new string[] { GlobalVariable.isVietnameseLanguage ? "Tiếng Anh" : "English", GlobalVariable.isVietnameseLanguage ? "Tiếng Việt" : "Vietnamese" });
            dataGridView_Translations.Rows[0].Frozen = true;

            var selectedDictionary = GlobalVariable.database.getDictionaries().Where(dic => dic.name == GlobalVariable.selectedDictionary).FirstOrDefault();
            foreach (var translation in selectedDictionary.translations.Where(trans => trans.EN.ToLower().StartsWith(searchText.ToLower())))
            {
                // Add translation row to DataGridView
                dataGridView_Translations.Rows.Add(new string[] { translation.EN, translation.VN });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DictionariesManager dictionariesListForm = new DictionariesManager();
            dictionariesListForm.FormClosed += new FormClosedEventHandler(LoadForm);
            dictionariesListForm.Show();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(textBox_Search.Text);
        }

        private void dataGridView_Translations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0) // Check if a valid row is clicked
            {
                DataGridViewRow row = dataGridView_Translations.Rows[e.RowIndex];
                // Get the value of each cell in the clicked row
                string en = row.Cells[0].Value.ToString();
                string vn = row.Cells[1].Value.ToString();
                TranslationInfoForm translationInfoForm = new TranslationInfoForm(en, vn);
                translationInfoForm.FormClosed += new FormClosedEventHandler(LoadForm);
                translationInfoForm.Show();
            }
        }

        private void button_AddNewTranslation_Click(object sender, EventArgs e)
        {
            TranslationInfoForm translationInfoForm = new TranslationInfoForm();
            translationInfoForm.FormClosed += new FormClosedEventHandler(LoadForm);
            translationInfoForm.Show();
        }
    }
}
