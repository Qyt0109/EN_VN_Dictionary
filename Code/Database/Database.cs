using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML;
using ClosedXML.Excel;

namespace EN_VN_Lib
{
    public class Database
    {
        private XLWorkbook _DatabaseExcelFile;
        private List<Dictionary> _Dictionaries = new List<Dictionary>();
        private List<Account> _Accounts = new List<Account>();


        public bool isDictionaryExsited(string dictionaryName)
        {
            if (_DatabaseExcelFile.Worksheets.Any(w => w.Name == dictionaryName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool addNewDictonary(string dictionaryName)
        {
            if (isDictionaryExsited(dictionaryName))
            {
                return false;
            }
            else
            {
                // Add new sheet to workbook
                IXLWorksheet dictionary = _DatabaseExcelFile.Worksheets.Add(dictionaryName);
                // Populate the new worksheet with data
                dictionary.Cell(1,1).Value = "EN";
                dictionary.Cell(1, 2).Value = "VN";
                // Save the changes to the existing Excel file
                _DatabaseExcelFile.Save();
                return true;
            }
            
        }

        public bool deleteDictionary(string dictionaryName)
        {
            if (isDictionaryExsited(dictionaryName))
            {
                //try
                //{
                    // Detele worksheet with a specific name
                    _DatabaseExcelFile.Worksheet(dictionaryName).Delete();
                    // Save the Excel file
                    _DatabaseExcelFile.Save();
                    return true;
                //}
                //catch
                //{
                //    return false;
                //}
            }
            else
            {
                return false;
            }
        }

        public bool updateDictionaryName(string dictionaryName, string newDictionaryName)
        {
            try
            {
                // Select the worksheet
                var dictionary = _DatabaseExcelFile.Worksheet(dictionaryName);
                dictionary.Name = newDictionaryName;
                _DatabaseExcelFile.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool addNewTranslation(string dictionaryName, string en, string vn)
        {
            if (translationRowExistedEN(dictionaryName, en) == 0)
            {
                // Select the worksheet
                var dictionary = _DatabaseExcelFile.Worksheet(dictionaryName);
                // Loop through each row until a blank row is found
                int rowNumber = 1;
                try
                {
                    while (!dictionary.Cell(rowNumber, 1).IsEmpty() || !dictionary.Cell(rowNumber, 2).IsEmpty())
                    {
                        rowNumber++;
                    }
                    // Fill data to the blank row
                    dictionary.Cell(rowNumber, 1).Value = en;
                    dictionary.Cell(rowNumber, 2).Value = vn;
                    // Save the Excel file
                    _DatabaseExcelFile.Save();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public int translationRowExistedEN(string dictionaryName, string en)
        {
            // Select the worksheet
            var dictonary = _DatabaseExcelFile.Worksheet(dictionaryName);
            // Find the row index where the first cell has a specific value
            int rowIndex = 1;
            while (!dictonary.Cell(rowIndex, 1).IsEmpty() && dictonary.Cell(rowIndex, 1).Value.ToString() != en)
            {
                rowIndex++;
            }
            if (dictonary.Cell(rowIndex, 1).Value.ToString() == en)
            {
                return rowIndex;
            }
            else
            {
                return 0;
            }
        }

        public bool deleteTranslationByEN(string dictionaryName, string en)
        {
            // Select the worksheet
            var dictionary = _DatabaseExcelFile.Worksheet(dictionaryName);
            int rowOfEN = translationRowExistedEN(dictionaryName, en);
            if (rowOfEN != 0)
            {
                dictionary.Row(rowOfEN).Delete();
                _DatabaseExcelFile.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateTranslationByEN(string dictionaryName, string en, string newEn, string newVn)
        {
            // Select the worksheet
            var dictionary = _DatabaseExcelFile.Worksheet(dictionaryName);
            int rowOfEN = translationRowExistedEN(dictionaryName, en);
            if (rowOfEN != 0)
            {
                dictionary.Cell(rowOfEN, 1).Value = newEn;
                dictionary.Cell(rowOfEN, 2).Value = newVn;
                _DatabaseExcelFile.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void loadSettings()
        {
            GlobalVariable.isVietnameseLanguage = _DatabaseExcelFile.Worksheets.FirstOrDefault().Rows().Skip(1).FirstOrDefault().Cell(1).GetValue<bool>();
            GlobalVariable.selectedDictionary = _DatabaseExcelFile.Worksheets.FirstOrDefault().Rows().Skip(1).FirstOrDefault().Cell(2).GetValue<string>();
        }

        public void saveSettings(bool isVietnameseLanguage, string selectedDictionary)
        {
            _DatabaseExcelFile.Worksheets.FirstOrDefault().Rows().Skip(1).FirstOrDefault().Cell(1).Value = isVietnameseLanguage;
            _DatabaseExcelFile.Worksheets.FirstOrDefault().Rows().Skip(1).FirstOrDefault().Cell(2).Value = selectedDictionary;
            _DatabaseExcelFile.Save();
            loadSettings();
        }

        public List<Account> getAccounts()
        {
            return _Accounts;
        }

        public List<Dictionary> getDictionaries()
        {
            return _Dictionaries;
        }

        public void loadDB()
        {
            _DatabaseExcelFile = null;
            _Accounts.Clear();
            _Dictionaries.Clear();
            this._DatabaseExcelFile = new XLWorkbook(GlobalVariable.databaseFilePath);
            foreach (var sheet in _DatabaseExcelFile.Worksheets)
            {
                if (sheet.Name != GlobalVariable.settingsSheetName)
                {
                    if (sheet.Name == GlobalVariable.accountSheetName)
                    {
                        var rows = sheet.RowsUsed().Skip(1).Where(r=>r.CellsUsed().Any(c => !string.IsNullOrEmpty(c.Value.ToString())));
                        foreach (var row in rows)
                        {
                            _Accounts.Add(new Account(row.Cell(1).GetValue<string>(), row.Cell(2).GetValue<string>(), row.Cell(3).GetValue<string>()));
                        }
                    }
                    else
                    {
                        Dictionary dictionary = new Dictionary();
                        dictionary.name = sheet.Name;
                        dictionary.order = sheet.Position;
                        var rows = sheet.RowsUsed().Skip(1).Where(r => r.CellsUsed().Any(c => !string.IsNullOrEmpty(c.Value.ToString()))).OrderBy(row => row.Cell(1).Value.ToString());
                        foreach (var row in rows)
                        {
                            dictionary.translations.Add(new Translation(row.Cell(1).GetValue<string>(), row.Cell(2).GetValue<string>()));
                        }
                        _Dictionaries.Add(dictionary);
                    }
                }
            }
        }
    }

    public class Dictionary
    {
        public int order;
        public string name;
        public List<Translation> translations = new List<Translation>();
    }

    public class Translation
    {
        //public int Id { get; set; }
        public string EN { get; set; }
        public string VN { get; set; }

        public Translation(string en, string vn)
        {
            //Id = id;
            EN = en;
            VN = vn;
        }
    }

    public class Account
    {
        //public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Account()
        {

        }
        public Account(string username, string password, string role)
        {
            //Id = id;
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
