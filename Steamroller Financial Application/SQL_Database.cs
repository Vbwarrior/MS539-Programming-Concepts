/*
 using (SQLiteDataReader reader = db.FetchData(db.SqlStringBuilder(sqlCode: "Budget_1")))
            {
                while (reader.Read())
                {
                    xCombobox.Items.Add(reader["Group"].ToString());
                }
            }
*/

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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing.Drawing2D;

//namespace Steamroller_Financial_Application
//{
//    public class SQL_Database
//    {
//        public enum TABLE
//        {
//            AccountTypes,
//            BudgetAccounts,
//            BudgetCategories,
//            PaymentMethods,
//            Transactions,
//            User_Access,
//            Users,
//            Vendors,

//        }

//        public enum MODE
//        {
//            Selecting,
//            Adding,
//            Updating
//        }



//        SQLiteConnection sql3_conn;
//        GlobalDataAndFunctions Globals = new GlobalDataAndFunctions();
//        List<SQLiteParameter> parameters = new List<SQLiteParameter>();

//        public SQL_Database()
//        {
//            OpenConnection();
//        }

//        public SQLiteConnection OpenConnection()
//        {

//            sql3_conn = new SQLiteConnection("Data Source=FinancialData.db; Version = 3; New = True; Compress = True;");
//            try
//            {
//                sql3_conn.Open();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Database Connection Error\nSystem Message:\n" + ex.Message);
//            }

//            return sql3_conn;
//        }

//        /// <summary>
//        /// Send the Command string to execute (Adding, Updating, Deleting)
//        /// </summary>
//        /// <param name="sql">SqlStringBuilder string </param>
//        /// <returns> returns false if failure detected</returns>
//        public bool ExecuteCommand(string sql)
//        {
//            try
//            {
//                SQLiteCommand myCommand = new SQLiteCommand(sql, sql3_conn);
//                if (parameters.Count > 0)
//                {
//                    foreach (var parameter in parameters)
//                    {
//                        myCommand.Parameters.Add(parameter);
//                    }

//#if DEBUG
//                    Debug.WriteLine("SQL Command: " + myCommand.CommandText);
//                    foreach (SQLiteParameter param in myCommand.Parameters)
//                    {
//                        Debug.WriteLine($"Parameter: {param.ParameterName}, Value: {param.Value}");
//                    }
//#endif
//                    // Clear the parameters list after use
//                    parameters.Clear();
//                }
//                myCommand.ExecuteNonQuery();
//                return true;
//            }
//            catch (System.Exception ex)
//            {
//#if DEBUG
//                MessageBox.Show(ex.Message);
//                Debug.WriteLine(ex.Message);
//#endif
//                return false;
//            }

//        }

//        public SQLiteDataReader FetchData(string sqlQuery)
//        {
//            SQLiteCommand command = new SQLiteCommand(sqlQuery, sql3_conn);
//            try
//            {


//                if (sql3_conn.State != ConnectionState.Open)
//                {
//                    sql3_conn.Open();
//                }

//                command = new SQLiteCommand(sqlQuery, sql3_conn);
//                if (parameters.Count > 0)
//                {
//                    foreach (var parameter in parameters)
//                    {
//                        command.Parameters.Add(parameter);
//                    }
//                    // Clear the parameters list after use
//                    parameters.Clear();
//                }
//                return command.ExecuteReader();
//            }
//            catch (System.Exception ex)
//            {
//#if DEBUG
//                MessageBox.Show(ex.Message);
//                Debug.WriteLine(ex.Message);
//#endif
//                return command.ExecuteReader();
//            }
//        }

//        /// <summary>
//        /// Generate an SQL string for Adding or Updating using the given parameters, conversion from string may be required
//        /// </summary>
//        /// <param name="tbl">Enum of existing tables in DB</param>
//        /// <param name="mode">Enum of existing modes in DB</param>
//        /// <param name="fldName1">Either Single or comma seperated field names</param>
//        /// <param name="fldName2">Single Field Name used when targeting specific fields</param>
//        /// <param name="Value1">Either Single or comma seperated values</param>
//        /// <param name="Value2">Single Value for use when targeting specific records</param>
//        /// <returns>Statment to run SQL Query</returns>
//        public string SqlStringBuilder(string tblName, int mode = 0, string fldName1 = "", string fldName2 = "", string Value1 = "", string Value2 = "", string condition = "", string orderBy = "")
//        {
//            {/*Modes:
//             0 - Select All
//                1 - Insert New Record
//                2 - Update Record
//                3- Delete Record
//                4- Mark as inactive
//                5++ User Defined
//             */
//            }//Mode Details


//            string sqlStatment = string.Empty;
//            int xCount;
//            if (Value1 != "") { parameters.Add(new SQLiteParameter("Value1", Value1)); }
//            //Adds string arrays as individual items into parametes list
//            if (!string.IsNullOrEmpty(Value2) && Value2.Contains(','))
//            {
//                string[] values = Value2.Split(',');
//                for (int i = 0; i < values.Length; i++)
//                {
//                    xCount = i + 2;//Ofsett for Feild2 
//                    parameters.Add(new SQLiteParameter("Value" + xCount, values[i]));
//                }

//            }
//            else
//            {
//                parameters.Add(new SQLiteParameter("Value2", Value2));
//            }

//            if (!string.IsNullOrEmpty(condition) && !condition.Contains("WHERE "))
//            {
//                condition = "WHERE " + condition;

//            }

//            switch (tblName)
//            {
//                case "AccountTypes":

//                    switch (mode)
//                    {
//                        case 0://Select
//                            break;
//                        case 1://Insert New Record
//                            break;
//                        case 2://Update Record
//                            break;
//                        case 3://Delete Record
//                            break;
//                        case 4://Mark As Inactive
//                            break;

//                    }

//                    break;

//                case "Accounts":
//                    switch (mode)
//                    {
//                        case 0://Select
//                            break;
//                        case 1://Insert New Record
//                            break;
//                        case 2://Update Record
//                            break;
//                        case 3://Delete Record
//                            break;
//                        case 4://Mark As Inactive
//                            break;

//                    }

//                    break;

//                case "Bills":
//                    switch (mode)
//                    {
//                        case 0://Select
//                            break;
//                        case 1://Insert New Record
//                            sqlStatment = $"INSERT INTO Bills ([Active], [Name], [NickName], [Address], [City], [State], [ZipCode], [PhoneNumber], [PrimaryPaymentMethod], [AccountType], [Balance], [APR], [Website], [Type], [DueDay], [Recurring],[PreferedPaymentMethod], [AccountNumber], [Image] VALUES(@Value2);";
//                            break;
//                        case 2://Update Record
//                            break;
//                        case 3://Delete Record
//                            break;
//                        case 4://Mark As Inactive
//                            break;

//                    }

//                    break;
               
//                case "BudgetData":
//                    switch (mode)
//                    {
//                        case 0://Select
//                            break;
//                        case 1://Insert New Record
//                            break;
//                        case 2://Update Record
//                            break;
//                        case 3://Delete Record
//                            break;
//                        case 4://Mark As Inactive
//                            break;

//                    }

//                    break;

//                case "BudgetItems":
//                    switch (mode)
//                    {
//                        case 0://Select
//                            break;
//                        case 1://Insert New Record
//                            break;
//                        case 2://Update Record
//                            break;
//                        case 3://Delete Record
//                            break;
//                        case 4://Mark As Inactive
//                            break;

//                    }

//                    break;

//                case "Budgets":
//                    switch (mode)
//                    {
//                        case 0://Select
//                            if (!string.IsNullOrEmpty(condition)){ condition += "=@Value1"; }
//                            sqlStatment = $"SELECT {fldName1} FROM Budgets {condition};";
//                            break;
//                        case 1://Insert New Record
//                            sqlStatment =$"INSERT INTO Budgets ([isActive], [BudgetName]) VALUES (1, @Value1);";
//                            break;
//                        case 2://Update Record
//                            break;
//                        case 3://Delete Record
//                            break;
//                        case 4://Mark As Inactive
//                            break;
//                        case 5://Load_Budget_By_ID
//                            sqlStatment = $"SELECT BudgetID FROM Budgets WHERE BudgetID=@Value1;";
//                            break;
//                    }

//                    break;

//                case "Categories":
//                    switch (mode)
//                    {
//                        case 0://Select
//                            break;
//                        case 1://Insert New Record
//                            break;
//                        case 2://Update Record
//                            break;
//                        case 3://Delete Record
//                            break;
//                        case 4://Mark As Inactive
//                            break;

//                    }

//                    break;

//                case "PaymentMethods":
//                    switch (mode)
//                    {
//                        case 0://Select
//                            break;
//                        case 1://Insert New Record
//                            break;
//                        case 2://Update Record
//                            break;
//                        case 3://Delete Record
//                            break;
//                        case 4://Mark As Inactive
//                            break;

//                    }

//                    break;

//                case "Transactions":
//                    switch (mode)
//                    {
//                        case 0://Select
//                            break;
//                        case 1://Insert New Record
//                            sqlStatment = $"INSERT INTO [Transactions] ([Amount], [Date], [PaymentMenthod], [VendorName], [Category], [Item],[isPastDue] VALUES (@Value1);";
//                            break;
//                        case 2://Update Record
//                            break;
//                        case 3://Delete Record
//                            break;
//                        case 4://Mark As Inactive
//                            break;

//                    }

//                    break;

//                case "UserDefinedApplicationSettings":
//                    switch (mode)
//                    {
//                        case 0://Select
//                            sqlStatment = "SELECT * FROM [UserDefinedApplicationSettings] ;";
//                            break;
//                        case 1://Insert New Record
//                            sqlStatment = "INSERT INTO UserDefinedApplicationSettings (isActive, Parent, Type, Property, Value) VALUES(@Value2, @Value3, @Value4, @Value5, @Value6);";//Send comma seperated values as string using Value2
//                            break;
//                        case 2://Update Record //UPDATE table_name SET column1 = $newvalue$ WHERE condition;
//                            sqlStatment = $"UPDATE UserDefinedApplicationSettings SET {fldName1} = @Value1 WHERE {condition};";
//                            break;
//                        case 3://Delete Record
//                            sqlStatment = $"DELETE FROM [UserDefinedApplicationSettings] WHERE {condition} = @Value1;";
//                            break;
//                        case 4://Mark As Inactive

//                            break;
//                        case 5://Select Specific Report
//                            sqlStatment = $"SELECT [Value] FROM [UserDefinedApplicationSettings] WHERE [isActive] = 1 AND [Parent] = 'frmReports' AND [Type] = 'Report';";
//                            break;
//                    }

//                    break;

//                case "Users":

//                    switch (mode)
//                    {
//                        case 0://Select 
//                            if (!string.IsNullOrEmpty(condition)) { condition += "=@Value1"; }
//                            sqlStatment = $"SELECT {fldName1} FROM Users {condition};"; //                                                      
//                            break;
//                        case 1://Insert New Record
//                          sqlStatment = "INSERT INTO Users ([isActive], [UserName], [Password]) VALUES (1, @Value1, @Value2);";
//                            break;
//                        case 2://Update Record
//                            break;
//                        case 3://Delete Record
//                            break;
//                        case 4://Mark As Inactive
//                            break;
//                        case 5://Check4DuplicateUsers
//                            sqlStatment = "SELECT COUNT(*) FROM Users WHERE UPPER(UserName) = UPPER(@Value1)";
//                            break;
//                            case 6:
//                            sqlStatment = $"SELECT * FROM Users WHERE UserName=@Value1 AND Password = @Value2;";
//                            break;
//                    }

//                    break;

//                case "User_Access":
//                    switch (mode)
//                    {
//                        case 0://Select
//                            sqlStatment = $"SELECT [Value] FROM [UserDefinedApplicationSettings] WHERE [isActive] = 1 AND [Parent] = 'frmReports' AND [Type] = 'Report';";
//                            break;
//                        case 1://Insert New Record
//                            sqlStatment = $"INSERT INTO [User_Access]  ([UserName], [BudgetID], [DefaultBudgetID]) VALUES( @Value1, @Value2, @Value2);";
//                            break;
//                        case 2://Update Record
//                            break;
//                        case 3://Delete Record

//                            break;
//                        case 4://Mark As Inactive
//                            break;
//                        case 5:  //Get_Default_Budget
//                            sqlStatment = $"SELECT DefaultBudgetID FROM User_Access WHERE UserName=@Value1;";
//                            break;
                       
//                    }

//                    break;



//            }

//            return sqlStatment;
//        }

//    }
//}
