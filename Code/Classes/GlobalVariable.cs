using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_VN_Lib
{
    public class GlobalVariable
    {
        #region systemsettings
        public static bool isVietnameseLanguage;
        public static string selectedDictionary;
        #endregion
        public static string databaseFilePath = "..\\..\\Database\\MainDatabase.xlsx";
        public static string settingsSheetName = "Settings";
        public static int settingsSheetOrder = 0;
        public static string accountSheetName = "Accounts";
        public static int accountSheetOrder = 1;
        public static Account loggedInAccount = null;
        public static Database database = new Database();
    }
}
