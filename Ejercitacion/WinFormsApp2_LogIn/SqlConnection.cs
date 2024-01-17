using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Net;
using Microsoft.Data.Sqlite;

namespace WinFormsApp2_LogIn
{
    class SqlConnection
    {
        SqliteConnection sqlCon;
       
        public void Open()
        {
            string connectionString = "Data Source=.account.sqbpro;Version=3";
            sqlCon = new SqliteConnection("");

            // Abre la conexion
            sqlCon.Open();
        }
        public void Close()
        {
            // Cierra la conexión
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

    }
}




