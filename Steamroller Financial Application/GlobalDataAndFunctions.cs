using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Reflection;
using System.Drawing;

namespace Steamroller_Financial_Application
{
    public class GlobalDataAndFunctions
    {
        //Add Variables and functions to be used by Application 


        // SQLite Specific Variables
        //public static SQLiteCRUD db = new SQLiteCRUD();
        public static string executableLocation = Assembly.GetExecutingAssembly().Location;
        public static string path = System.IO.Path.GetDirectoryName(executableLocation);
        public static string dbName = "FinancialData.db";
        public static string conn = $"Data Source={System.IO.Path.Combine(path, dbName)};Version=3;";
        public static SQLiteConnection connection = new SQLiteConnection(conn);
        public Color CalendarDayMouseEnterOriginalColor;
        public  string BudgetID = "0";//Default fo testing
        public  string UserName = string.Empty;
         private static Random _random = new Random();
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



        public  Color RandomColors()
        {
            double saturation = 0.5;
            double value = .95;
            double hue = _random.NextDouble() * 360;
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }
    










    }
}
