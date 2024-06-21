using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Reflection;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Steamroller_Financial_Application
{
    public class SQL_Database
    {
        public enum TABLE
        {
            AccountTypes,
            BudgetAccounts,
            BudgetCategories,
            PaymentMethods,
            Transactions,
            User_Access,
            Users,
            Vendors,
            
        }

        public enum MODE
        {
            Selecting,
            Adding,
            Updating
        }



        SQLiteConnection sql3_conn;
        GlobalDataAndFunctions Globals = new GlobalDataAndFunctions();

        public SQL_Database()
        {
            OpenConnection();
        }

        public SQLiteConnection OpenConnection()
        {

            sql3_conn = new SQLiteConnection("Data Source=FinancialData.db; Version = 3; New = True; Compress = True;");
            try
            {
                sql3_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error\nSystem Message:\n" + ex.Message);
            }

            return sql3_conn;
        }

        /// <summary>
        /// Send the Command string to execute (Adding, Updating, Deleting)
        /// </summary>
        /// <param name="sql">sqlCommands string </param>
        /// <returns> returns false if failure detected</returns>
        public bool ExecuteCommand(string sql)
        {
            try
            {
                SQLiteCommand myCommand = new SQLiteCommand(sql, sql3_conn);
                myCommand.ExecuteNonQuery();

                return true;
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

        }







        public SQLiteDataReader FetchData(string sqlQuery)
        {
            if (sql3_conn.State != ConnectionState.Open)
            {
                sql3_conn.Open();

            }

            SQLiteCommand command = new SQLiteCommand(sqlQuery, sql3_conn);
            return command.ExecuteReader();
        }



        /// <summary>
        /// Generate an SQL string for Adding or Updating using the given parameters, conversion from string may be required
        /// </summary>
        /// <param name="tbl">Enum of existing tables in DB</param>
        /// <param name="mode">Enum of existing modes in DB</param>
        /// <param name="fldName1">Either Single or comma seperated field names</param>
        /// <param name="fldName2">Single Field Name used when targeting specific fields</param>
        /// <param name="Value1">Either Single or comma seperated values</param>
        /// <param name="Value2">Single Value for use when targeting specific records</param>
        /// <returns>Statment to run SQL Query</returns>
        public string sqlCommands(string sqlCode, string fldName1 = "", string fldName2 = "", string Value1 = "", string Value2 = "", string condition = "", string orderBy = "")
        {
            string sqlStatment = string.Empty;


            switch (sqlCode)
            {


                case "Budget_1":
                    sqlStatment = "SELECT DISTINCT [Group] FROM BudgetCategories ORDER BY [Group] ASC;";
                    break;
                case "Budget_2":
                    sqlStatment = "SELECT  [Group], [SubGroup], [Active] FROM BudgetCategories;";
                    break;
                case "Budget_3":
                    sqlStatment = $"SELECT  [SubGroup]  FROM BudgetCategories WHERE [Group] = '{Value1}' ORDER BY  [SubGroup]  ASC;";
                    break;
                case "Budget_4":
                    sqlStatment = $"INSERT INTO [BudgetCategories] ([Active],[Group], [SubGroup]) VALUES (1,'{Value1}', '{Value2}');";
                    break;
                case "NewSearch":
                    sqlStatment = $"INSERT INTO [UserDefinedApplicationSettings]  ([isActive], [Parent], [Type], [Property], [Value]) VALUES (1, 'frmReports', 'Reports', {null}, '{Value1}');";
                    break;

            }





            return sqlStatment;
        }


    }
}
