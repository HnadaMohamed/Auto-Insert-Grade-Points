using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DatabaseManager
    {
        public static MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringManar"].ConnectionString);

        public static void OpenConnection()
        {

            if (cnx.State != ConnectionState.Open)
            {

                cnx.Open();



            }

        }

        public static void CloseConnection()
        {

            if (cnx.State == ConnectionState.Open)
                cnx.Close();
        }
    }
}
