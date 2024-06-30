using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Reflection;
using System.Drawing;
using SQLiteClassLib;
using System.Security.Cryptography;



namespace Steamroller_Financial_Application
{
    public class GlobalDataAndFunctions
    {
        //Add properties and functions to be used by Application         
        private List<string> dataList = new List<string>();//Holds the Shared List Data
        public Color CalendarDayMouseEnterOriginalColor { get; set; }
        public string UserName { get; set; } = string.Empty;
        public Random Random { get; set; } = new Random();
        public long UserID { get; set; } = 0;
        public int IntCreditCardPicture { get; set; } = 0;
        public int IntLeftSideBarWidth { get; set; } = 0;
        public int IntRightSideBarWidth { get; set; } = 0;
        public int IntSizeMode { get; set; } = 1; // Used in Generic Form Timer
        public int IntStepSize { get; set; } = 10; // Used in Generic Form Timer
        public bool BoolHorizontalDirection { get; set; } = false; // Used in Generic Form Timer
        public int IntEndSize { get; set; } = 0; // Used in Generic Form Timer
        public string MyControl { get; set; } = string.Empty; // Used in Generic Form Timer

        public  Color RandomColors()
        {
            double saturation = 0.5;
            double value = .95;
            double hue = Random.NextDouble() * 360;
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

        /// <summary>
        /// Used for passing List object between forms (Form to InputForm)
        /// </summary>
        public List<string> DataList
        {
            get { return dataList; }
            set
            {
                dataList.Clear();
                dataList = value;
            }
        }

        public string CreateSha256Hash(string rawData)
        {

            using (SHA256 sha256Hash = SHA256.Create())// Create a SHA256  
            {

                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  // ComputeHash - returns byte array  


                StringBuilder builder = new StringBuilder();  // Convert byte array to a string   
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }



        public string ColorToString(Color color)
        {
            return $"{color.R},{color.G},{color.B}";
        }

        public Color StringToColor(string colorString)
        {
            string[] RGB = colorString.Split(',');
            int R = int.Parse(RGB[0]);
            int G = int.Parse(RGB[1]);
            int B = int.Parse(RGB[2]);

            return Color.FromArgb(R, G, B);
        }




    }
}
