/*
 
                SQLite CRUD Class (SQLiteCRUD)

    
    This Class performs basic CRUD operations on an SQLite Database.
Class can be used in both Console applications and Desktop applications. 
It is not designed or intended to be an all inclusive class and custimization may be required for specific project.

Requirment :

            Reference to:System.Data.SQLite
            Nuget Package: System.Data.SQLite  vs 1.0.118
 
 
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography.Xml;
using System.Xml;
using static System.Windows.Forms.AxHost;
using System.Net;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SQLiteClassLib
{
    public struct SQLiteField
    {
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsAutoIncrement { get; set; }
        public bool IsNotNull { get; set; }
        public bool IsUnique { get; set; }
        public string DefaultValue { get; set; }
    }



    public class SQLiteCRUD
    {

        private SQLiteConnection sqlite_conn;
        List<SQLiteParameter> parameters = new List<SQLiteParameter>();
        List<SQLiteField> _COLUMNS = new List<SQLiteField>();

        /// <summary>
        /// The SQLiteCRUD constructor. Creates a new SQLite database connection using the provided connection string. 
        /// {Eample connectionString = "Data Source=C:\\sqlite\\db\\mydatabase.db; Version=3;"}
        /// </summary>
        /// <param name="connectionString"></param>
        public SQLiteCRUD(string connectionString) // Create a new database connection:
        {
            sqlite_conn = new SQLiteConnection(connectionString);


            string databasePath = new SQLiteConnectionStringBuilder(connectionString).DataSource;

            if (!File.Exists(databasePath))
            {
                CreateDatabaseAndTables();
            }
        }

        /// <summary>
        /// The OpenConnection method. Called Internally to Open Connection when needed if not already open.
        /// </summary>
        private void OpenConnection()
        {
            if (sqlite_conn.State != ConnectionState.Open)
            {
                sqlite_conn.Open();
            }
        }

        /// <summary>
        /// The CloseConnection method. Internally called to Closes the SQLite database connection if it is open.
        /// </summary>
        private void CloseConnection()
        {
            if (sqlite_conn.State != ConnectionState.Closed)
            {
                sqlite_conn.Close();
            }
        }


        public void TestConnection()
        {
            string message = "Connection to the database was successful.";

            OpenConnection();
            if (Console.OpenStandardInput(1) != Stream.Null)//Console Application
            {
                Console.WriteLine(message);
            }
            else// Windows appliaction
            {
                // If it's not a console application, it's likely a Windows application
                // You can handle the message appropriately here, such as showing a message box
                MessageBox.Show(message);
            }
        }


        /// <summary>
        ///  The Write method. Executes a non-query SQLite command (Insert, Update, Drop) by processing the query string.
        /// </summary>
        /// <param name="query">Uses a preBuilt SQL Querry string to perform operations</param>
        private void Write(string query)
        {
            if (!(sqlite_conn.State == ConnectionState.Open)) { OpenConnection(); }


            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlite_conn))
            {
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                cmd.ExecuteNonQuery();
            }


            CloseConnection();
        }

        /// <summary>
        /// The Read method. Executes a SQLite querry command that returns data using the provided query string.
        /// </summary>
        /// <param name="query">Uses a preBuilt SQL Querry string to perform operations</param>
        /// <returns>SQLiteDataReader Object wich is internally processes</returns>
        private SQLiteDataReader Read(string query)
        {
            if (!(sqlite_conn.State == ConnectionState.Open)) { OpenConnection(); }

            SQLiteDataReader reader;
            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlite_conn))
            {
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                reader = cmd.ExecuteReader();
            }

            return reader;
        }



        /// <summary>
        ///  Inserts Dictionary [Column Name, Value>] iterates through KVP in Dictionary and creates the insertion string with parameters.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnValues"></param>
        public void Insert_Into(string tableName, Dictionary<string, string> columnValues)
        {
            StringBuilder query = new StringBuilder();

            query.Append($"INSERT INTO {tableName} (");

            if (columnValues != null)
            {
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in columnValues)
                {
                    query.Append($"[{kvp.Key}]");
                    if (i < columnValues.Count - 1) { query.Append(", "); }
                    parameters.Add(new SQLiteParameter("@" + kvp.Key, kvp.Value));
                    i++;
                }
                query.Append(") VALUES(");

                i = 0;
                foreach (KeyValuePair<string, string> kvp in columnValues)
                {
                    query.Append($"@{kvp.Key}");
                    if (i < columnValues.Count - 1) { query.Append(", "); }
                    i++;
                }
                query.Append(");");
            }

            Debug.WriteLine(query.ToString());

            Write(query.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnValues"></param>
        /// <param name="conditions"></param>
        public void Update(string tableName, Dictionary<string, string> columnValues, Dictionary<string, string> conditions)
        {
            StringBuilder query = new StringBuilder();

            query.Append($"UPDATE {tableName} SET ");

            if (columnValues != null)
            {
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in columnValues)
                {
                    query.Append($"[{kvp.Key}] = @{kvp.Key}");
                    if (i < columnValues.Count - 1) { query.Append(", "); }
                    parameters.Add(new SQLiteParameter("@" + kvp.Key, kvp.Value));
                    i++;
                }
            }

            if (conditions != null && conditions.Count > 0)
            {
                query.Append(" WHERE ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in conditions)
                {
                    query.Append($"[{kvp.Key}] = @{kvp.Key}");
                    if (i < conditions.Count - 1) { query.Append(" AND "); }
                    parameters.Add(new SQLiteParameter("@" + kvp.Key, kvp.Value));
                    i++;
                }
            }

            query.Append(";");

            Write(query.ToString());
           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="fromTable"></param>
        /// <param name="conditions"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public SQLiteDataReader SelectReader(List<string> columns, string fromTable, Dictionary<string, string> conditions = null, Dictionary<string, string> orderBy = null)
        {
            SQLiteDataReader reader;

            StringBuilder query = new StringBuilder();

            parameters.Clear();

            query.Append("SELECT ");

            for (int i = 0; i < columns.Count; i++)
            {
                query.Append(columns[i]);
                if (i < columns.Count - 1) { query.Append(","); }
            }

            query.Append($" FROM {fromTable} ");

            if (conditions != null)
            {
                query.Append("WHERE ");

                int i = 0;
                foreach (KeyValuePair<string, string> kvp in conditions)
                {
                    query.Append($"{kvp.Key} = @{kvp.Key}");
                    if (i < conditions.Count - 1) { query.Append(" AND "); }
                    parameters.Add(new SQLiteParameter("@" + kvp.Key, kvp.Value));
                    i++;
                }
            }

            if (orderBy != null)
            {
                query.Append("ORDER BY ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in orderBy)
                {
                    query.Append($"{kvp.Key} {kvp.Value}");
                    if (i < orderBy.Count - 1) { query.Append(", "); }
                    i++;
                }
            }
            query.Append(";");

            reader = Read(query.ToString());

            return reader;
        }

        public Dictionary<string, string> SelectRow(string fromTable, Dictionary<string, string> conditions = null, Dictionary<string, string> orderBy = null)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            StringBuilder query = new StringBuilder();

            parameters.Clear();

            query.Append("SELECT * FROM " + fromTable + " ");

            if (conditions != null)
            {
                query.Append("WHERE ");

                int i = 0;
                foreach (KeyValuePair<string, string> kvp in conditions)
                {
                    query.Append($"{kvp.Key} = @{kvp.Key}");
                    if (i < conditions.Count - 1) { query.Append(" AND "); }
                    parameters.Add(new SQLiteParameter("@" + kvp.Key, kvp.Value));
                    i++;
                }
            }

            if (orderBy != null)
            {
                query.Append("ORDER BY ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in orderBy)
                {
                    query.Append($"{kvp.Key} {kvp.Value}");
                    if (i < orderBy.Count - 1) { query.Append(", "); }
                    i++;
                }
            }
            query.Append(";");


            using (SQLiteDataReader reader = Read(query.ToString()))
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (!result.ContainsKey(reader.GetName(i)))
                        {
                            result.Add(reader.GetName(i), reader.GetValue(i).ToString());
                        }
                    }
                }
            }

            CloseConnection();
            return result;
        }

        public Dictionary<string, string> SelectRow(string fromTable, string columnName, string columnValue, Dictionary<string, string> orderBy = null)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            StringBuilder query = new StringBuilder();
            parameters.Clear();

            query.Append("SELECT * FROM " + fromTable + " WHERE ");
            query.Append($"{columnName} = @{columnName}");
            parameters.Add(new SQLiteParameter("@" + columnName, columnValue));

            if (orderBy != null)
            {
                query.Append(" ORDER BY ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in orderBy)
                {
                    query.Append($"{kvp.Key} {kvp.Value}");
                    if (i < orderBy.Count - 1) { query.Append(", "); }
                    i++;
                }
            }
            query.Append(";");

            using (SQLiteDataReader reader = Read(query.ToString()))
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (!result.ContainsKey(reader.GetName(i)))
                        {
                            result.Add(reader.GetName(i), reader.GetValue(i).ToString());
                        }
                    }
                }
            }

            CloseConnection();
            return result;
        }



        public List<Dictionary<string, string>> SelectTable(string fromTable, Dictionary<string, string> conditions = null, Dictionary<string, string> orderBy = null)
        {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();

            StringBuilder query = new StringBuilder();

            parameters.Clear();

            query.Append("SELECT * FROM " + fromTable + " ");

            if (conditions != null)
            {
                query.Append("WHERE ");

                int i = 0;
                foreach (KeyValuePair<string, string> kvp in conditions)
                {
                    query.Append($"{kvp.Key} = @{kvp.Key}");
                    if (i < conditions.Count - 1) { query.Append(" AND "); }
                    parameters.Add(new SQLiteParameter("@" + kvp.Key, kvp.Value));
                    i++;
                }
            }

            if (orderBy != null)
            {
                query.Append("ORDER BY ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in orderBy)
                {
                    query.Append($"{kvp.Key} {kvp.Value}");
                    if (i < orderBy.Count - 1) { query.Append(", "); }
                    i++;
                }
            }
            query.Append(";");

            using (SQLiteDataReader reader = Read(query.ToString()))
            {
                while (reader.Read())
                {
                    Dictionary<string, string> row = new Dictionary<string, string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i).ToString());
                    }
                    result.Add(row);
                }
            }
            CloseConnection();
            return result;
        }

        public List<Dictionary<string, string>> SelectTable(string fromTable, List<string> columns, Dictionary<string, string> conditions = null, Dictionary<string, string> orderBy = null)
        {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();

            StringBuilder query = new StringBuilder();

            parameters.Clear();

            // Build the SELECT clause using the columns list
            query.Append("SELECT " + string.Join(", ", columns) + " FROM " + fromTable + " ");

            if (conditions != null)
            {
                query.Append("WHERE ");

                int i = 0;
                foreach (KeyValuePair<string, string> kvp in conditions)
                {
                    query.Append($"{kvp.Key} = @{kvp.Key}");
                    if (i < conditions.Count - 1) { query.Append(" AND "); }
                    parameters.Add(new SQLiteParameter("@" + kvp.Key, kvp.Value));
                    i++;
                }
            }

            if (orderBy != null)
            {
                query.Append("ORDER BY ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in orderBy)
                {
                    query.Append($"{kvp.Key} {kvp.Value}");
                    if (i < orderBy.Count - 1) { query.Append(", "); }
                    i++;
                }
            }
            query.Append(";");

            using (SQLiteDataReader reader = Read(query.ToString()))
            {
                while (reader.Read())
                {
                    Dictionary<string, string> row = new Dictionary<string, string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i).ToString());
                    }
                    result.Add(row);
                }
            }
            CloseConnection();
            return result;
        }

        public List<Dictionary<string, string>> SelectTable(string fromTable, List<string> columns, string column , string value, Dictionary<string, string> orderBy = null)
        {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();

            StringBuilder query = new StringBuilder();

            parameters.Clear();

            // Build the SELECT clause using the columns list
            query.Append("SELECT " + string.Join(", ", columns) + " FROM " + fromTable + " ");

            if (column != null && value != null)
            {
                query.Append("WHERE ");
                query.Append($"{column} = @{column}");
                parameters.Add(new SQLiteParameter("@" + column, value));
            }

            if (orderBy != null)
            {
                query.Append("ORDER BY ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in orderBy)
                {
                    query.Append($"{kvp.Key} {kvp.Value}");
                    if (i < orderBy.Count - 1) { query.Append(", "); }
                    i++;
                }
            }
            query.Append(";");

            using (SQLiteDataReader reader = Read(query.ToString()))
            {
                while (reader.Read())
                {
                    Dictionary<string, string> row = new Dictionary<string, string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i).ToString());
                    }
                    result.Add(row);
                }
            }
            CloseConnection();
            return result;
        }



        /// <summary>
        /// Selects a single column from a specified table and returns the results as a List<string>.
        /// </summary>
        /// <param name="column">The name of the column to select.</param>
        /// <param name="fromTable">The name of the table to select from.</param>
        /// <param name="conditions">A dictionary of conditions for the WHERE clause.</param>
        /// <param name="orderBy">A dictionary for the ORDER BY clause.</param>
        /// <returns>A List<string> containing the values of the selected column.</returns>
        public List<string> SelectList(string column, string fromTable, Dictionary<string, string> conditions = null, Dictionary<string, string> orderBy = null)
        {
            List<string> results = new List<string>();
            SQLiteDataReader reader;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT ").Append(column).Append(" FROM ").Append(fromTable);

            if (conditions != null && conditions.Count > 0)
            {
                query.Append(" WHERE ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in conditions)
                {
                    query.Append(kvp.Key).Append(" = '").Append(kvp.Value).Append("'");
                    if (i < conditions.Count - 1) { query.Append(" AND "); }
                    i++;
                }
            }

            if (orderBy != null && orderBy.Count > 0)
            {
                query.Append(" ORDER BY ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in orderBy)
                {
                    query.Append(kvp.Key).Append(" ").Append(kvp.Value);
                    if (i < orderBy.Count - 1) { query.Append(", "); }
                    i++;
                }
            }

            query.Append(";");

            reader = Read(query.ToString());

            while (reader.Read())
            {
                results.Add(reader[column].ToString());
            }
            reader.Close();
            CloseConnection();
            return results;
        }

        public List<string> SelectList(string column, string fromTable, string value, Dictionary<string, string> orderBy = null)
        {
            List<string> results = new List<string>();
            SQLiteDataReader reader;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT ").Append(column).Append(" FROM ").Append(fromTable);

            if (!string.IsNullOrEmpty(value))
            {
                query.Append(" WHERE ").Append(column).Append(" = '").Append(value).Append("'");
            }

            if (orderBy != null && orderBy.Count > 0)
            {
                query.Append(" ORDER BY ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in orderBy)
                {
                    query.Append(kvp.Key).Append(" ").Append(kvp.Value);
                    if (i < orderBy.Count - 1) { query.Append(", "); }
                    i++;
                }
            }

            query.Append(";");

            reader = Read(query.ToString());

            while (reader.Read())
            {
                results.Add(reader[column].ToString());
            }
            reader.Close();
            CloseConnection();
            return results;
        }

        public List<string> SelectList(string columnName, string fromTable, string column, string value, Dictionary<string, string> orderBy = null)
        {
            List<string> results = new List<string>();
            SQLiteDataReader reader;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT ").Append(columnName).Append(" FROM ").Append(fromTable);

            if (!string.IsNullOrEmpty(column) && !string.IsNullOrEmpty(value))
            {
                query.Append(" WHERE ").Append(column).Append(" = '").Append(value).Append("'");
            }

            if (orderBy != null && orderBy.Count > 0)
            {
                query.Append(" ORDER BY ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in orderBy)
                {
                    query.Append(kvp.Key).Append(" ").Append(kvp.Value);
                    if (i < orderBy.Count - 1) { query.Append(", "); }
                    i++;
                }
            }

            query.Append(";");

            reader = Read(query.ToString());

            while (reader.Read())
            {
                results.Add(reader[columnName].ToString());
            }
            reader.Close();
            CloseConnection();
            return results;
        }


        /// <summary>
        /// Selects a single value from a specified column and table based on conditions and returns it as a string.
        /// Returns a default value if no rows meet the conditions or if the table is empty.
        /// </summary>
        /// <param name="column">The name of the column to select.</param>
        /// <param name="fromTable">The name of the table to select from.</param>
        /// <param name="conditions">A dictionary of conditions for the WHERE clause.</param>
        /// <returns>A string containing the first value of the selected column that meets the conditions, or a default value.</returns>
        public string SelectString(string column, string fromTable, Dictionary<string, string> conditions = null)
        {
            string result = "No Data Found"; // Specify your default value here
            SQLiteDataReader reader;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT ").Append(column).Append(" FROM ").Append(fromTable);

            if (conditions != null && conditions.Count > 0)
            {
                query.Append(" WHERE ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in conditions)
                {
                    query.Append(kvp.Key).Append(" = '").Append(kvp.Value).Append("'");
                    if (i < conditions.Count - 1) { query.Append(" AND "); }
                    i++;
                }
            }

            query.Append(";");

            reader = Read(query.ToString());

            if (reader.Read())
            {
                result = reader[column].ToString();
            }
            reader.Close();
            CloseConnection();
            return result;
        }

        /// <summary>
        /// Using the column name, table name, and a dictionary of Where 'Column' = 'Value' conditions.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="fromTable"></param>
        /// <param name="where"></param>
        /// <returns>string of value found or No Data found if not.</returns>
        public string SelectString(string column, string fromTable, KeyValuePair<string, string> where)
        {
            string result = "No Data Found"; //  default value here
            SQLiteDataReader reader;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT ").Append(column).Append(" FROM ").Append(fromTable);

            if (!string.IsNullOrEmpty(where.Key) && !string.IsNullOrEmpty(where.Value))
            {
                query.Append(" WHERE ").Append(where.Key).Append(" = '").Append(where.Value).Append("'");
            }

            query.Append(";");

            reader = Read(query.ToString());

            if (reader.Read())
            {
                result = reader[column].ToString();
            }
            reader.Close();
            CloseConnection();
            return result;
        }

        /// <summary>
        /// Used to retrive a specific unique data items such as Keys or ID columns where there is only one possible return.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="fromTable"></param>
        /// <param name="value"></param>
        /// <returns>Value if found, No Data if none found and Multiples found if more than one item was found.</returns>
        public string SelectString(string column, string fromTable, string value)
        {
            string result = "No Data Found"; // Specify your default value here
            SQLiteDataReader reader;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT ").Append(column).Append(" FROM ").Append(fromTable);

            if (!string.IsNullOrEmpty(value))
            {
                query.Append(" WHERE ").Append(column).Append(" = '").Append(value).Append("'");
            }

            query.Append(";");

            reader = Read(query.ToString());

            if (reader.HasRows)
            {
               
                if (reader.Read())
                {                    
                    result = reader[column].ToString();
                }
            }

            reader.Close();
            CloseConnection();
            return result;
        }


        /// <summary>
        /// The FieldContains method. It checks if the specified field in the specified table contains the specified value.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fldName"></param>
        /// <param name="value"></param>
        /// <returns>Boolean value indicating if data is present.</returns>
        public bool Contains(string tableName, string fldName, string value)
        {
            bool result = false;

            Dictionary<string, string> condition = new Dictionary<string, string>();

            condition.Add(fldName, value);

            result = Count(tableName, condition) > 0 ? true : false;

            CloseConnection();
            return result;
        }

        public bool Contains(string tableName, Dictionary<string, string> conditions)
        {
            bool result = false;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT 1 FROM ").Append(tableName);

            if (conditions != null && conditions.Count > 0)
            {
                query.Append(" WHERE ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in conditions)
                {
                    query.Append(kvp.Key).Append(" = '").Append(kvp.Value).Append("'");
                    if (i < conditions.Count - 1) { query.Append(" AND "); }
                    i++;
                }
            }

            query.Append(" LIMIT 1;");

            using (SQLiteDataReader reader = Read(query.ToString()))
            {
                result = reader.HasRows;
            }
            CloseConnection();
            return result;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="fromTable"></param>
        /// <param name="conditions"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public DataTable GetDataTable(List<string> columns, string fromTable, Dictionary<string, string> conditions = null, Dictionary<string, string> orderBy = null)
        {
            DataTable dataTable = new DataTable();

            StringBuilder query = new StringBuilder();

            parameters.Clear();

            query.Append("SELECT ");

            for (int i = 0; i < columns.Count; i++)
            {
                query.Append(columns[i]);
                if (i < columns.Count - 1) { query.Append(","); }
            }

            query.Append($" FROM {fromTable} ");

            if (conditions != null)
            {
                query.Append("WHERE ");

                int i = 0;
                foreach (KeyValuePair<string, string> kvp in conditions)
                {
                    query.Append($"{kvp.Key} = @{kvp.Key}");
                    if (i < conditions.Count - 1) { query.Append(" AND "); }
                    parameters.Add(new SQLiteParameter("@" + kvp.Key, kvp.Value));
                    i++;
                }
            }

            if (orderBy != null)
            {
                query.Append("ORDER BY ");
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in orderBy)
                {
                    query.Append($"{kvp.Key} {kvp.Value}");
                    if (i < orderBy.Count - 1) { query.Append(", "); }
                    i++;
                }
            }
            query.Append(";");

            SQLiteDataReader reader = Read(query.ToString());

            dataTable.Load(reader);
            CloseConnection();
            return dataTable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromTable"></param>
        /// <param name="conditions"></param>
        /// <returns></returns>
        public int Count(string fromTable, Dictionary<string, string> conditions = null)
        {
            int count = 0;

            StringBuilder query = new StringBuilder();

            parameters.Clear();

            query.Append($"SELECT COUNT(*) FROM {fromTable}");

            if (conditions != null)
            {
                query.Append(" WHERE ");

                int i = 0;
                foreach (KeyValuePair<string, string> kvp in conditions)
                {
                    query.Append($"{kvp.Key} = @{kvp.Key}");
                    if (i < conditions.Count - 1) { query.Append(" AND "); }
                    parameters.Add(new SQLiteParameter("@" + kvp.Key, kvp.Value));
                    i++;
                }
            }

            query.Append(";");

            using (SQLiteDataReader reader = Read(query.ToString()))
            {
                if (reader.Read())
                {
                    count = Convert.ToInt32(reader[0]);
                }
            }

            CloseConnection();

            return count;
        }


        /// <summary>
        /// The ClearColumns method. Clears the _COLUMNS list, should be called before creating a new table.
        /// </summary>
        public void ClearColumns()
        {
            _COLUMNS.Clear();
        }

        /// <summary>
        /// The Add2Columns method. Adds a new Struct{SQLiteField of Column Data} to the List of _COLUMNS with specified properties.
        /// </summary>
        /// <param name="fieldName"> Coulnm Name for table</param>
        /// <param name="fieldType">The Typoe of Data</param>
        /// <param name="isPrimaryKey">is Field the primary key or part of the primary key</param>
        /// <param name="isAutoIncrement"> Is this field intended to be Auto Incremented. Can only be used if Field is Primary Key.</param>
        /// <param name="isNotNull">Indicates if the Field is allowed to be Null.</param>
        /// <param name="isUnique">Enforces data integrity by not allowing duplicate values in this field.</param>
        /// <param name="defaultValue">Default value to be used if one is not provided.</param>
        public void Add2Columns(string fieldName, string fieldType, bool isPrimaryKey = false, bool isAutoIncrement = false, bool isNotNull = false, bool isUnique = false, string defaultValue = null)
        {
            SQLiteField fieldInfo = new SQLiteField
            {
                FieldName = fieldName,
                FieldType = fieldType,
                IsPrimaryKey = isPrimaryKey,
                IsAutoIncrement = isAutoIncrement,
                IsNotNull = isNotNull,
                IsUnique = isUnique,
                DefaultValue = defaultValue
            };

            _COLUMNS.Add(fieldInfo);
        }

        /// <summary>
        ///  The CreateTable method. Creates a new table using the List(_Columns).
        /// </summary>
        /// <param name="tableName"></param>
        public void CreateTable(string tableName)
        {
            StringBuilder query = new StringBuilder();

            query.Append($"CREATE TABLE {tableName} (");

            for (int i = 0; i < _COLUMNS.Count; i++)
            {
                query.Append($"{_COLUMNS[i].FieldName} {_COLUMNS[i].FieldType}");

                if (_COLUMNS[i].IsPrimaryKey)
                    query.Append(" PRIMARY KEY");

                if (_COLUMNS[i].IsAutoIncrement)
                    query.Append(" AUTOINCREMENT");

                if (_COLUMNS[i].IsNotNull)
                    query.Append(" NOT NULL");

                if (_COLUMNS[i].IsUnique)
                    query.Append(" UNIQUE");

                if (!string.IsNullOrEmpty(_COLUMNS[i].DefaultValue))
                    query.Append($" DEFAULT {_COLUMNS[i].DefaultValue}");

                // Add a comma separator between fields, but not after the last field
                if (i < _COLUMNS.Count - 1)
                    query.Append(", ");
            }

            query.Append(");");

            Write(query.ToString());

            _COLUMNS.Clear();
        }

        /// <summary>
        ///  The AddColumns method. It inserts columns from the _COLUMNS list into the specified table.
        /// </summary>
        /// <param name="tableName"></param>
        public void AddColumns(string tableName)
        {
            // Check if table is empty
            string checkTableQuery = $"SELECT COUNT(*) FROM {tableName}";
            int count = Count(tableName);



            if (count == 0)
            {
                // If table is empty, add columns from _COLUMNS list
                foreach (var column in _COLUMNS)
                {
                    string addColumnQuery = $"ALTER TABLE {tableName} ADD COLUMN {column.FieldName} {column.FieldType}";
                    if (column.IsNotNull)
                        addColumnQuery += " NOT NULL";
                    if (column.IsUnique)
                        addColumnQuery += " UNIQUE";
                    if (!string.IsNullOrEmpty(column.DefaultValue))
                        addColumnQuery += $" DEFAULT {column.DefaultValue}";

                    Write(addColumnQuery);

                }
            }
            else
            {
                // If table is not empty, ensure there is a default value for each column where isNotNull is true
                foreach (var column in _COLUMNS)
                {
                    if (column.IsNotNull && string.IsNullOrEmpty(column.DefaultValue))
                    {
                        string defaultValue;

                        if (column.FieldType.ToLower() == "text")
                        {
                            defaultValue = "\" \"";
                        }
                        else if (column.FieldType.ToLower() == "date")
                        {
                            defaultValue = "\"1/1/2000\"";
                        }
                        else
                        {
                            defaultValue = "0";
                        }

                        string updateQuery = $"UPDATE {tableName} SET {column.FieldName} = {defaultValue} WHERE {column.FieldName} IS NULL";

                        Write(updateQuery);

                    }
                }
            }
        }

        /// <summary>
        ///  The DropTable method. It drops the specified table if there are no foreign key constraints.
        /// </summary>
        /// <param name="tableName"></param>
        public void DropTable(string tableName)
        {
            // Check for foreign key constraints
            string checkForeignKeyQuery = $"PRAGMA foreign_key_list({tableName})";
            using (SQLiteCommand cmd = new SQLiteCommand(checkForeignKeyQuery, sqlite_conn))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        // If there are no foreign key constraints, drop the table
                        string dropTableQuery = $"DROP TABLE {tableName}";
                        Write(dropTableQuery);
                    }

                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblCommonField"></param>
        /// <param name="tblCommonField_2"></param>
        /// <param name="tableAndColumn"></param>
        /// <returns></returns>
        public DataTable InnerJoin(Dictionary<string, string> tblCommonField, Dictionary<string, string> tblCommonField_2, Dictionary<string, string> tableAndColumn)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append($"SELECT ");

            if (tableAndColumn != null)//Append Table Names and Columns to sql statment
            {
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in tableAndColumn)
                {
                    sql.Append($"{kvp.Key}.{kvp.Value}");
                    if (i < tableAndColumn.Count - 1) { sql.Append(", "); }
                    i++;
                }
            }

            sql.Append($" FROM {tblCommonField.Keys.First()} INNER JOIN {tblCommonField_2.Keys.First()} ON {tblCommonField.Keys.First()}.{tblCommonField.Values.First()} = {tblCommonField_2.Keys.First()}.{tblCommonField_2.Values.First()}");

            SQLiteDataReader reader = Read(sql.ToString());

            // Load the data into the DataTable
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            return dataTable;
        }

        public long GetLastInsertID()
        {
            string query = "SELECT last_insert_rowid()";
            long userId;

            if (!(sqlite_conn.State == ConnectionState.Open)) { OpenConnection(); }

            using (SQLiteCommand cmd = new SQLiteCommand(query, sqlite_conn))
            {
                userId = (long)cmd.ExecuteScalar();
            }

            CloseConnection();
            return userId;
        }




        public void ClearAndVacuumTable(string tableName)
        {
            string query = $"DELETE FROM {tableName};";
            Write(query);
            Vacuum();
        }
        public void Vacuum()
        {
            // Vacuum the table
            Write("VACUUM;");
        }

        public void CreateDatabaseAndTables()
        {


            string assemblyPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string databaseDirectory = System.IO.Path.Combine(assemblyPath, "AppData", "Resources", "Database");
            System.IO.Directory.CreateDirectory(databaseDirectory); // This ensures that the directory exists

            string databaseName = System.IO.Path.Combine(databaseDirectory, "SteamRollerFinancialAssistant.db");

            SQLiteConnection.CreateFile(databaseName);

            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseName};Version=3;"))
            {
                connection.Open();

                string sql = @"
PRAGMA case_sensitive_like = OFF;

 CREATE TABLE Users (
 UserID INTEGER PRIMARY KEY,
 UserName TEXT COLLATE NOCASE NOT NULL UNIQUE,
 PasswordHash TEXT COLLATE NOCASE NOT NULL,
 IsActive BOOLEAN NOT NULL DEFAULT 1
);

CREATE TABLE Budgets (
 BudgetID INTEGER PRIMARY KEY,
 UserID INTEGER,
 BudgetNames TEXT COLLATE NOCASE NOT NULL,
 TotalAllocated REAL DEFAULT 0,
 IsActive BOOLEAN NOT NULL DEFAULT 1,
 FOREIGN KEY(UserID) REFERENCES Users(UserID)
);


CREATE TABLE Categories (
 CategoryID INTEGER PRIMARY KEY,
 CategoryName TEXT COLLATE NOCASE NOT NULL
);
   
  CREATE TABLE Allocations (
  AllocationID INTEGER PRIMARY KEY,
  BudgetID INTEGER,
  CategoryID INTEGER,
  Amount REAL NOT NULL,
  KeyColor	TEXT COLLATE NOCASE,
  FOREIGN KEY(BudgetID) REFERENCES Budgets(BudgetID),
  FOREIGN KEY(CategoryID) REFERENCES Categories(CategoryID)
 );

CREATE TABLE Bills (
BillID INTEGER PRIMARY KEY,
CategoryID INTEGER NOT NULL,
SubGroupID INTEGER NOT NULL,
CompanyName TEXT COLLATE NOCASE NOT NULL,
DisplayName TEXT COLLATE NOCASE,
PaymentMethodID INTEGER,
DueDay INTEGER NOT NULL DEFAULT 1,
AccountNumber TEXT COLLATE NOCASE,
Address TEXT COLLATE NOCASE,
State TEXT COLLATE NOCASE,
ZipCode TEXT COLLATE NOCASE,
PhoneNumber TEXT COLLATE NOCASE,
Website TEXT COLLATE NOCASE,
Recurring BOOLEAN DEFAULT 0,
IsPrimaryVendor BOOLEAN DEFAULT 0,
AutoPay BOOLEAN DEFAULT 0,
FOREIGN KEY(CategoryID) REFERENCES Categories(CategoryID),
FOREIGN KEY(PaymentMethodID) REFERENCES PaymentMethods(PaymentMethodID),
FOREIGN KEY(SubGroupID) REFERENCES CategorySubGroups(SubGroupID),
FOREIGN KEY(State) REFERENCES States(StateAbbreviation)
);

CREATE TABLE AccountTypes (
AccountTypeID INTEGER PRIMARY KEY,
AccountTypeName TEXT COLLATE NOCASE NOT NULL UNIQUE
);

CREATE TABLE UserAccounts (
UserAccountID INTEGER PRIMARY KEY,
UserID INTEGER,
AccountTypeID INTEGER,
BankName TEXT COLLATE NOCASE,
NickName TEXT COLLATE NOCASE,
Balance REAL,
AccountNumber TEXT COLLATE NOCASE,
PhoneNumber TEXT COLLATE NOCASE,
LogoFilePath TEXT COLLATE NOCASE,
IsActive BOOLEAN NOT NULL DEFAULT 1,
FOREIGN KEY(UserID) REFERENCES Users(UserID),
FOREIGN KEY(AccountTypeID) REFERENCES AccountTypes(AccountTypeID)
);

CREATE TABLE CategorySubGroups (
 SubGroupID INTEGER PRIMARY KEY,
 CategoryID INTEGER,
 SubCategoryName TEXT COLLATE NOCASE,
 IsActive BOOLEAN NOT NULL DEFAULT 1,
 FOREIGN KEY(CategoryID) REFERENCES Categories(CategoryID),
 UNIQUE(CategoryID, SubCategoryName)
 );

CREATE TABLE CreditCards (
CreditCardID INTEGER PRIMARY KEY,
BillID INTEGER,
APR REAL,
Balance REAL,
LogoFilePath TEXT COLLATE NOCASE,
IsActive BOOLEAN NOT NULL DEFAULT 1,
FOREIGN KEY(BillID) REFERENCES Bills(BillID)
);

CREATE TABLE Loans (
LoanID INTEGER PRIMARY KEY,
BillID INTEGER,
APR REAL,
Balance REAL,
TermMonths INTEGER,
StartDate TEXT,
EndDate TEXT,
LogoFilePath TEXT COLLATE NOCASE,
IsActive BOOLEAN NOT NULL DEFAULT 1,
FOREIGN KEY(BillID) REFERENCES Bills(BillID)
);

CREATE TABLE HouseholdBills (
HouseholdBillID INTEGER PRIMARY KEY,
BillID INTEGER,
LogoFilePath TEXT COLLATE NOCASE,
IsActive BOOLEAN NOT NULL DEFAULT 1,
FOREIGN KEY(BillID) REFERENCES Bills(BillID)
);       

CREATE TABLE TransactionTypes (
 TransactionTypeID INTEGER PRIMARY KEY,
 TransactionTypeName TEXT COLLATE NOCASE NOT NULL UNIQUE
 );
    
CREATE TABLE Transactions (
TransactionID INTEGER PRIMARY KEY,
BudgetID INTEGER,
TransactionTypeID INTEGER,
CategoryID INTEGER,
SubGroupID INTEGER,
Amount REAL,
VendorName TEXT COLLATE NOCASE,
PaymentMethodID INTEGER,
TransactionDate TEXT,
FOREIGN KEY(BudgetID) REFERENCES Budgets(BudgetID),
FOREIGN KEY(TransactionTypeID) REFERENCES TransactionTypes(TransactionTypeID),
FOREIGN KEY(CategoryID) REFERENCES Categories(CategoryID),
FOREIGN KEY(SubGroupID) REFERENCES CategorySubGroups(SubGroupID),
FOREIGN KEY(PaymentMethodID) REFERENCES PaymentMethods(PaymentMethodID)
 );

CREATE TABLE Reports (
ReportID INTEGER PRIMARY KEY,
BudgetID INTEGER,
ReportName TEXT COLLATE NOCASE,
ReportFilter TEXT COLLATE NOCASE,
IsActive BOOLEAN NOT NULL DEFAULT 1,
FOREIGN KEY(BudgetID) REFERENCES Budgets(BudgetID),
UNIQUE(BudgetID, ReportName)
);

CREATE TABLE PaymentMethods (
PaymentMethodID INTEGER PRIMARY KEY,
PaymentMethodName TEXT COLLATE NOCASE NOT NULL UNIQUE
);

CREATE TABLE States (
StateName TEXT NOT NULL,
StateAbbreviation TEXT PRIMARY KEY
);







INSERT INTO TransactionTypes (TransactionTypeName) VALUES 
('Income'), 
('Expense');


INSERT INTO AccountTypes (AccountTypeName) VALUES 
('Primary Checking'), 
('Checking'), 
('Primary Saving'), 
('Savings'), 
('Primary Credit Card'), 
('Credit Card');


INSERT INTO PaymentMethods (PaymentMethodName) VALUES 
('Cash'), 
('Check'), 
('Charge'), 
('ACH'), 
('Online Banking'),
('Debit Card'),
('Credit Card'),
('Mobile Payment'),
('Wire Transfer');


INSERT INTO States (StateName, StateAbbreviation) VALUES
('Alabama', 'AL'),
('Alaska', 'AK'),
('Arizona', 'AZ'),
('Arkansas', 'AR'),
('California', 'CA'),
('Colorado', 'CO'),
('Connecticut', 'CT'),
('Delaware', 'DE'),
('Florida', 'FL'),
('Georgia', 'GA'),
('Hawaii', 'HI'),
('Idaho', 'ID'),
('Illinois', 'IL'),
('Indiana', 'IN'),
('Iowa', 'IA'),
('Kansas', 'KS'),
('Kentucky', 'KY'),
('Louisiana', 'LA'),
('Maine', 'ME'),
('Maryland', 'MD'),
('Massachusetts', 'MA'),
('Michigan', 'MI'),
('Minnesota', 'MN'),
('Mississippi', 'MS'),
('Missouri', 'MO'),
('Montana', 'MT'),
('Nebraska', 'NE'),
('Nevada', 'NV'),
('New Hampshire', 'NH'),
('New Jersey', 'NJ'),
('New Mexico', 'NM'),
('New York', 'NY'),
('North Carolina', 'NC'),
('North Dakota', 'ND'),
('Ohio', 'OH'),
('Oklahoma', 'OK'),
('Oregon', 'OR'),
('Pennsylvania', 'PA'),
('Rhode Island', 'RI'),
('South Carolina', 'SC'),
('South Dakota', 'SD'),
('Tennessee', 'TN'),
('Texas', 'TX'),
('Utah', 'UT'),
('Vermont', 'VT'),
('Virginia', 'VA'),
('Washington', 'WA'),
('West Virginia', 'WV'),
('Wisconsin', 'WI'),
('Wyoming', 'WY'),
('District of Columbia', 'DC'),
('Puerto Rico', 'PR'),
('Guam', 'GU'),
('American Samoa', 'AS'),
('U.S. Virgin Islands', 'VI'),
('Northern Mariana Islands', 'MP');


INSERT INTO ""CategorySubGroups"" (""CategoryID"", ""SubCategoryName"", ""IsActive"") VALUES 
(1, 'Rent', 1),
(1, 'Mortgage', 1),
(1, 'Home repairs', 1),
(2, 'Car payments', 1),
(2, 'Ride Share', 1),
(2, 'Fuel', 1),
(2, 'Bus Fare', 1),
(2, 'Public transportation fares', 1),
(2, 'Vehicle maintenance', 1),
(3, 'Streaming services', 1),
(3, 'Movie tickets', 1),
(3, 'Concert tickets', 1),
(3, 'Hobbies', 1),
(3, 'Books/ Magazines', 1),
(4, 'Groceries', 1),
(4, 'Dining out', 1),
(4, 'Coffee', 1),
(4, 'Snacks', 1),
(4, 'AVI (Work Food System)', 1),
(4, 'Alcohol', 1),
(4, 'Takeout / Drive-Thru', 1),
(4, 'Delivery Service', 1),
(5, 'Prescription Refill', 1),
(5, 'Hospital Bill', 1),
(5, 'Dental care', 1),
(5, 'Eye care', 1),
(5, 'Co-Pay', 1),
(5, 'Equipment', 1),
(6, 'Electricity', 1),
(6, 'Water', 1),
(6, 'Gas', 1),
(6, 'Internet', 1),
(6, 'Cell phone', 1),
(6, 'Sewer', 1),
(6, 'Trash', 1),
(6, 'Home Phone', 1),
(7, 'Car', 1),
(7, 'Life', 1),
(7, 'Dental', 1),
(7, 'Vision', 1),
(7, 'Renters', 1),
(7, 'Home', 1),
(7, 'Flood', 1),
(7, 'Disability', 1),
(7, 'Health', 1),
(7, 'Homeowner''s', 1),
(7, 'Pet', 1),
(8, 'Income tax', 1),
(8, 'Sales tax', 1),
(8, 'Vehicle registration', 1),
(8, 'HOA Fees', 1),
(8, 'Property taxes', 1),
(8, 'RITA', 1),
(8, 'County', 1),
(8, 'City', 1),
(9, 'Hair Salon', 1),
(9, 'Gym memberships', 1),
(9, 'Nails', 1),
(9, 'Spa Treatment', 1),
(10, 'Tuition', 1),
(10, 'Textbooks', 1),
(10, 'School supplies', 1),
(10, 'Child care or babysitting', 1),
(11, 'Retirement contributions', 1),
(11, 'Emergency fund contributions', 1),
(11, 'Investment contributions', 1),
(11, '401K', 1),
(11, 'Roth IRA', 1),
(11, 'Stocks & Bonds', 1),
(12, 'Food', 1),
(12, 'Vet bills', 1),
(12, 'Vaccinations', 1),
(12, 'Toys and treats', 1),
(12, 'Clothing', 1),
(12, 'Clothes', 1),
(12, 'Shoes', 1),
(12, 'Accessories', 1),
(12, 'Boarding Fees', 1),
(12, 'Perscriptions & Refills', 1),
(13, 'Vacation expenses', 1),
(13, 'Hotel stays', 1),
(13, 'Flights', 1),
(13, 'Car rentals', 1),
(13, 'Baggage Fees', 1),
(13, 'Vallet Services', 1),
(14, 'Birthday gifts', 1),
(14, 'Holiday gifts', 1),
(14, 'Charitable donations', 1),
(14, 'Aniversary Gift', 1),
(14, 'Baby Gift', 1),
(14, 'Wedding Gift', 1),
(15, 'Clothes', 1),
(15, 'Shoes', 1),
(15, 'Accessories', 1),
(16, 'Personal Loan', 1),
(16, 'Auto Loan', 1),
(16, 'Mortgage', 1),
(17, 'Credit Card', 1);


INSERT INTO Categories (CategoryName) VALUES 
('Housing'),
('Transportation'),
('Entertainment'),
('Food'),
('Medical Care'),
('Utilities'),
('Insurance'),
('Taxes & Fees'),
('Personal Care'),
('Education & Child Care'),
('Savings & Investments'),
('Pets'),
('Clothing'),
('Travel & Leisure'),
('Gifts & Contributions'),
('Fixed Debt'),
('Variable Debt');

";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

    }






}

