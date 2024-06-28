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
        public enum TableNames
        {
                    AccountTypes = 1,
                    Accounts = 2,
                    Bills = 3,
                    BudgetData = 4,
                    BudgetItems = 5,
                    Budgets = 6,
                    Categories = 7,
                    PaymentMethods = 8,
                    Transactions = 9,
                    UserDefinedApplicationSettings = 10,
                    User_Access = 11,
                    Users = 12        
        
        }



        private SQLiteConnection sqlite_conn;
        List<SQLiteParameter> parameters = new List<SQLiteParameter>();
        List<SQLiteField> _COLUMNS = new List<SQLiteField>();

        /// <summary>
        /// The SQLiteCRUD constructor. Creates a new SQLite database connection using the provided connection string. 
        /// {Eample connectionString = "Data Source=C:\\sqlite\\db\\mydatabase.db; Version=3;"}
        /// </summary>
        /// <param name="connectionString"></param>
        public SQLiteCRUD(string connectionString)// Create a new database connection:
        {
            sqlite_conn = new SQLiteConnection(connectionString);
            //sqlite_conn.Open();
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

            return result;
        }


        /// <summary>
        /// The FieldContains method. It checks if the specified field in the specified table contains the specified value.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fldName"></param>
        /// <param name="value"></param>
        /// <returns>Boolean value indicating if data is present.</returns>
        public bool FieldContains(string tableName, string fldName, string value)
        {
            bool result = false;

            Dictionary<string,string>condition = new Dictionary<string,string>();

            condition.Add(fldName, value);

            result = Count(tableName, condition) > 0 ? true : false;


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

            return count;
        }
          




        /// <summary>
        /// Given the Enum TableName returns the string value of the tablesName
        /// </summary>
        /// <param name="tbl"></param>
        /// <returns></returns>
        public string Tables(TableNames tbl)
        {
            string tblName = string.Empty;

            switch (tbl)
            {
                case TableNames.AccountTypes:
                    tblName = "AccountTypes";
                    break;
                case TableNames.Accounts:
                    tblName = "Accounts";
                    break;
                case TableNames.Bills:
                    tblName = "Bills";
                    break;
                case TableNames.BudgetData:
                    tblName = "BudgetData";
                    break;
                case TableNames.BudgetItems:
                    tblName = "BudgetItems";
                    break;
                case TableNames.Budgets:
                    tblName = "Budgets";
                    break;
                case TableNames.Categories:
                    tblName = "Categories";
                    break;
                case TableNames.PaymentMethods:
                    tblName = "PaymentMethods";
                    break;
                case TableNames.Transactions:
                    tblName = "Transactions";
                    break;
                case TableNames.UserDefinedApplicationSettings:
                    tblName = "UserDefinedApplicationSettings";
                    break;
                case TableNames.User_Access:
                    tblName = "User_Access";
                    break;
                case TableNames.Users:
                    tblName = "Users";
                    break;
            }
            return tblName;

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


     

        public void ClearAndVacuumTable(string tableName)
        {           
                string query = $"DELETE FROM {tableName};";
               Write(query);            
        }
         public void Vacuum()
        {
            // Vacuum the table
            Write("VACUUM;");
        }

    }
}

/*
 
   /// <summary>
        /// The Insert_Into method. Inserts a new row into the specified table using the provided column-value pairs.
        /// </summary>
        /// <param name="tableName"> Name of the table to insert data.</param>
        /// <param name="columnValues">List of Key Value Pairs Where Key:[Column Name] Value:[Value to insert]</param>
        public void Insert_Into(string tableName, Dictionary<string,string>columnValues)
        {
            StringBuilder query = new StringBuilder();

            query.Append($"INSERT INTO {tableName} (");

            if (columnValues != null)
            {

                for (int i = 0; i < columnValues.Count; i++)
                {
                    query.Append($"[{columnValues[i].Key}]");
                    if (i < columnValues.Count - 1) { query.Append(", "); }

                    parameters.Add(new SQLiteParameter("@" + columnValues[i].Key, columnValues[i].Value));
                }
                query.Append(") VALUES(");

                for (int i = 0; i < columnValues.Count; i++)
                {
                    query.Append($"@{columnValues[i].Value}");
                    if (i < columnValues.Count - 1) { query.Append(", "); }


                }
                query.Append(");");


            }

            Write(query.ToString());
        }




        /// <summary>
        ///  The Update method. Updates the specified table with the provided column-value pairs where the conditions are met.
        /// </summary>
        /// <param name="tableName">Name of the table to insert data.</param>
        /// <param name="columnValues">List of Key Value Pairs Where Key:[Column Name] Value:[Value to insert]</param>
        /// <param name="conditions">List of Key Value Pairs Where Key:[Column Name] Value:[Value to insert]</param>
        public void Update(string tableName, Dictionary<string,string>columnValues, Dictionary<string,string>conditions)
        {
            StringBuilder query = new StringBuilder();

            query.Append($"UPDATE {tableName} SET ");

            if (columnValues != null)
            {
                for (int i = 0; i < columnValues.Count; i++)
                {
                    query.Append($"[{columnValues[i].Key}] = @{columnValues[i].Key}");
                    if (i < columnValues.Count - 1) { query.Append(", "); }

                    parameters.Add(new SQLiteParameter("@" + columnValues[i].Key, columnValues[i].Value));
                }
            }

            if (conditions != null && conditions.Count > 0)
            {
                query.Append(" WHERE ");

                for (int i = 0; i < conditions.Count; i++)
                {
                    query.Append($"[{conditions[i].Key}] = @{conditions[i].Key}");
                    if (i < conditions.Count - 1) { query.Append(" AND "); }

                    parameters.Add(new SQLiteParameter("@" + conditions[i].Key, conditions[i].Value));
                }
            }

            query.Append(";");

            Write(query.ToString());
        }

  /// <summary>
        ///  The Select method. It selects specified columns from the specified table where the conditions are met and orders the result as specified.
        /// </summary>
        /// <param name="columns">List of strings containing Column Names</param>
        /// <param name="fromTable"> Name of the table to retrive data from.</param>
        /// <param name="conditions">List of Key Value Pairs Where Key:[Column Name] Value:[Value]</param>
        /// <param name="orderBy">List of Key Value Pairs Where Key:[Column Name] Value:[Order By Type (ASC | DESC)]</param>
        /// <returns>SQLiteDataReader Object to be used by calling method to extract data.</returns>
        public SQLiteDataReader Select(List<string> columns, string fromTable, Dictionary<string,string>conditions = null, Dictionary<string,string>orderBy = null)
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

                for (int i = 0; i < conditions.Count; i++)
                {
                    query.Append(conditions[i].Key + " = @" + conditions[i].Key);
                    if (i < conditions.Count - 1) { query.Append(" AND "); }

                    parameters.Add(new SQLiteParameter("@" + conditions[i].Key, conditions[i].Value));
                }
            }

            if (orderBy != null)
            {
                query.Append("ORDER BY ");
                for (int i = 0; i < orderBy.Count; i++)
                {
                    query.Append($"{orderBy[i]} {orderBy[i].Value}");
                    if (i < conditions.Count - 1) { query.Append(", "); }
                }
            }
            query.Append(";");

            reader = Read(query.ToString());

            return reader;

        }


        /// <summary>
        /// The GetDataTable method. It gets a DataSet of specified columns from the specified table where the conditions are met and orders the result as specified.
        /// </summary>
        /// <param name="columns">List of strings containing Column Names</param>
        /// <param name="fromTable">Name of the table to retrive data from.</param>
        /// <param name="conditions">List of Key Value Pairs Where Key:[Column Name] Value:[Value to insert]</param>
        /// <param name="orderBy">List of Key Value Pairs Where Key:[Column Name] Value:[Order By Type (ASC | DESC)]</param>
        /// <returns>DataSet Object with data from query if any found.</returns>
        public DataTable GetDataTable(List<string> columns, string fromTable, Dictionary<string,string>conditions = null, Dictionary<string,string>orderBy = null)
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

                for (int i = 0; i < conditions.Count; i++)
                {
                    query.Append(conditions[i].Key + " = @" + conditions[i].Key);
                    if (i < conditions.Count - 1) { query.Append(" AND "); }

                    parameters.Add(new SQLiteParameter("@" + conditions[i].Key, conditions[i].Value));
                }
            }

            if (orderBy != null)
            {
                query.Append("ORDER BY ");
                for (int i = 0; i < orderBy.Count; i++)
                {
                    query.Append($"{orderBy[i]} {orderBy[i].Value}");
                    if (i < conditions.Count - 1) { query.Append(", "); }
                }
            }
            query.Append(";");

            SQLiteDataReader reader = Read(query.ToString());

            dataTable.Load(reader);

            return dataTable;
        }

        /// <summary>
        /// The Count method. It counts the number of rows in the specified table where the conditions are met.
        /// </summary>
        /// <param name="fromTable"></param>
        /// <param name="conditions"></param>
        /// <returns>Integer value of count of rows. Zero indicates no data found.</returns>
        public int Count(string fromTable, Dictionary<string,string>conditions = null)
        {
            // sqliteString = $"SELECT COUNT(*) FROM {tblNames} WHERE {fldName1} = @value1";

            int count = 0;

            StringBuilder query = new StringBuilder();

            parameters.Clear();

            query.Append($"SELECT COUNT(*) FROM {fromTable}");

            if (conditions != null)
            {
                query.Append(" WHERE ");

                for (int i = 0; i < conditions.Count; i++)
                {
                    query.Append(conditions[i].Key + " = @" + conditions[i].Key);
                    if (i < conditions.Count - 1) { query.Append(" AND "); }

                    parameters.Add(new SQLiteParameter("@" + conditions[i].Key, conditions[i].Value));
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

            return count;
        }

      
        /// <summary>
        /// InnerJoin Method: Creates a DataTable by joining on a common field between two tables.
        /// </summary>
        /// <param name="tblCommonField"> Commonly known as the From Table</param>
        /// <param name="tblCommonField_2">Joining Tabl </param>
        /// <param name="tableAndColumn">List of KVP of the Table.Column Names to put in DataTable. Where Key= Table Name & Value = Field Name. </param>
        /// <returns>DataTable of Combined Table Columns from both tables</returns>
        public DataTable InnerJoin(Dictionary<string, string> tblCommonField, Dictionary<string, string> tblCommonField_2, Dictionary<string,string>tableAndColumn)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append($"SELECT ");

            if (tableAndColumn != null)//Append Table Names and Columns to sql statment
            {
                for (int i = 0; i < tableAndColumn.Count; i++)
                {
                    sql.Append(tableAndColumn[i].Key + "." + tableAndColumn[i].Value);
                    if (i < tableAndColumn.Count - 1) { sql.Append(", "); }
                }
            }

            sql.Append($" FROM {tblCommonField.Key} INNER JOIN {tblCommonField_2.Key} ON {tblCommonField.Key + "." + tblCommonField.Value} = {tblCommonField_2.Key + "." + tblCommonField_2.Value}");

            SQLiteDataReader reader = Read(sql.ToString());

            // Load the data into the DataTable
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            return dataTable;
        }








  */
