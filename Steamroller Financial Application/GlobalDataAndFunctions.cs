using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Reflection;

namespace Steamroller_Financial_Application
{
    public class GlobalDataAndFunctions
    {
        //Add Variables and functions to be used by Application 


        // SQLite Specific Variables
        //public static SQL_Database db = new SQL_Database();
        public static string executableLocation = Assembly.GetExecutingAssembly().Location;
        public static string path = System.IO.Path.GetDirectoryName(executableLocation);
        public static string dbName = "FinancialData.db";
        public static string conn = $"Data Source={System.IO.Path.Combine(path, dbName)};Version=3;";
        public static SQLiteConnection connection = new SQLiteConnection(conn);
        public Color CalendarDayMouseEnterOriginalColor;



        /// <summary>
        /// Load all globals varibles into dictionary and parse values to correct type for usage
        /// </summary>
        /// <returns></returns>
        public  Dictionary<string,string> LoadDictionary()
        {
            Dictionary<string, string> dictTemp = new Dictionary<string, string>();

            dictTemp.Add("intCreditCardPicture", "0");
            dictTemp.Add("intLeftSideBarWidth", "0");
            dictTemp.Add("intRightSideBarWidth", "0");
            dictTemp.Add("intSizeMode", "1");//Used in Generic Form Timmer
            dictTemp.Add("intStepSize", "10");//Used in Generic Form Timmer
            dictTemp.Add("boolHorizontalDirection", "false");//Used in Generic Form Timmer
            dictTemp.Add("intEndSize", "0");//Used in Generic Form Timmer
            dictTemp.Add("myControl", string.Empty);//Used in Generic Form Timmer
         









            return dictTemp;
        }




















    }
}
