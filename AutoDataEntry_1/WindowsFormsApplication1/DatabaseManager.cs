using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WindowsFormsApplication1
{
    class DatabaseManager
    {
        public static MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringManar"].ConnectionString);
        static MySqlCommand mysqlComm;
        static MySqlDataReader dr;

        static string examen_id , sql;

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

        
        public static void insert_note(string inscription_id , string moyenne ,int examen_id)
        {
            try
            {
                //inscription_id = qrcode d'eleve

                //find_examen_id(qrcode_principale);

                //if (examen_id == "rien")
                //{
                //    MessageBox.Show("L'examen n'existe pas .", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}


                sql = "INSERT INTO examen_inscription_note (inscription_id, examen_id,moyenne,remarque) VALUES (" + inscription_id + "," + examen_id + "," + moyenne + ",'passable')";
                mysqlComm = new MySqlCommand(sql, DatabaseManager.cnx);
                mysqlComm.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

        }

        public  static string find_examen_id(string qrcode_principale)
        {
            //string name_image = "119;195;555;528;526;12/02/2018";
            //string[] id_champs = name_image.Split(';');

            string[] id_champs = qrcode_principale.Split(';');

            try
            {
                //sql = "SELECT * FROM `examen` where Personnel_id = 206 and UniteMatiere_id = 804 and type_id = 528 and periode_id = 526";

                sql = "SELECT * FROM `examen` where Personnel_id = " + id_champs[0] + " and UniteMatiere_id =" + id_champs[1] + " and type_id = " + id_champs[2] + " and periode_id = " + id_champs[3];
                mysqlComm = new MySqlCommand(sql, DatabaseManager.cnx);
                dr = mysqlComm.ExecuteReader();

                if (dr.Read())
                {
                    examen_id = dr["id"].ToString();
                }
                else
                {
                    dr.Close();
                    dr = null;

                    MessageBox.Show("examen = rien");
                    insert_examen(id_champs);
                }

                dr.Close();
                dr = null;


            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

            return examen_id.ToString();
        }

        private static void insert_examen(string[] id_champs)
        {
            try
            {
                //sql = "INSERT INTO examen (Personnel_id, UniteMatiere_id,type_id,periode_id) VALUES (206, 804, 528, 526)";

                sql = "INSERT INTO examen (Personnel_id, UniteMatiere_id,type_id,periode_id) VALUES (" + id_champs[0] + ", " + id_champs[1] + ", " + id_champs[2] + ", " + id_champs[3] + ")";
                mysqlComm = new MySqlCommand(sql, DatabaseManager.cnx);
                mysqlComm.ExecuteNonQuery();

                //INSERT INTO examen (Personnel_id, UniteMatiere_id,type_id,periode_id) VALUES (1,62,430,430)
                //find examen_id
                sql = "SELECT * FROM `examen` where Personnel_id = " + id_champs[0] + " and UniteMatiere_id =" + id_champs[1] + " and type_id = " + id_champs[2] + " and periode_id = " + id_champs[3];
                mysqlComm = new MySqlCommand(sql, DatabaseManager.cnx);
                dr = mysqlComm.ExecuteReader();

                if (dr.Read())
                {
                    examen_id = dr["id"].ToString();
                }
                dr.Close();
                dr = null;

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }
    }
}
