﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GenericDBView
{
    public static partial class DB
    {
        public static SqlConnection Conn = new SqlConnection("server=.; database=master; integrated security=sspi;");

        public static string ConnectionString(string dbName = "master")
        {
            return string.Format("server=.; database={0}; integrated security=sspi;", dbName);
        }

        public static SqlConnection GetConnection(string db)
        {
            return new SqlConnection(ConnectionString(db));
        }

        public static string GetSqlString(string tableName)
        {
            return string.Format("SELECT * FROM {0}", tableName);
        }

        public static List<string> GetDBList()
        {
            var _list = new List<string>();
            using (var head = new SqlDataAdapter("SELECT name FROM sys.databases", Conn))
            {
                var dt = new DataTable();
                head.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    _list.Add((string) row["name"]);
                }
            }
            return _list;
        }

        public static List<string> GetTableList(string dbName = "master")
        {
            var _list = new List<string>();
            var con = ConnectionString(dbName);

            var cmdString = @"select name FROM SYS.TABLES WHERE NAME !='sysdiagrams'";
            using (var head = new SqlDataAdapter(cmdString, con))
            {
                var dt = new DataTable();
                head.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    _list.Add((string) row["name"]);
                }

                return _list;
            }
        }

        public static DataTable GetTable(string tableName, string dbName = "master")
        {
            var cmdString = GetSqlString(tableName);
            var conn = GetConnection(dbName);
            var dt = new DataTable(tableName);

            using (var head = new SqlDataAdapter(cmdString, conn))
            {
                head.Fill(dt);
            }

            return dt;
        }
    }
}