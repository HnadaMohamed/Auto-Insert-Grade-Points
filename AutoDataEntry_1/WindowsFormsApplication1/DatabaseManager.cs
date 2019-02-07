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
         static int aer = 0;
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

        public static string fct_sql(List<Examen_inscription_note> list_note )
        {
            string sql_= "";

            int i = 0;
            if (list_note.Count != 0)
            {

                sql_ = "INSERT INTO examen_inscription_note (inscription_id, examen_id,moyenne) VALUES ";
                foreach (var item in list_note)
                {
                    //ex.inscription_id.ToString(), ex.moyenne.ToString(), ex.examen_id
                    sql_ += "(" + item.inscription_id.ToString() + "," + item.examen_id.ToString() + "," + item.moyenne.ToString().Replace(",", ".") + ") ";

                    if (list_note.Count - 1 != i)
                    {
                        sql_ += " , ";
                    }
                    else if (list_note.Count - 1 == i)
                    {
                        sql_ += " ; ";
                    }


                    i++;
                }
            }

          //  MessageBox.Show(sql_);

            return sql_;
        }

        public static void insert_note_list(List<Examen_inscription_note> list_note)
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

                //moyenne = moyenne.Replace(",", ".");

                //MessageBox.Show(moyenne);
                //sql = "INSERT INTO examen_inscription_note (inscription_id, examen_id,moyenne) VALUES (" + inscription_id + "," + examen_id + "," + moyenne + ");";
                //sql = "INSERT INTO examen_inscription_note (inscription_id, examen_id,moyenne) VALUES ";

                sql = fct_sql(list_note);
                if (sql != "")
                {

                    

                    mysqlComm = new MySqlCommand(sql, DatabaseManager.cnx);
                    mysqlComm.ExecuteNonQuery();

                    mysqlComm = null;
                }
                
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

        }

        public static string find_note(string inscription_id, string moyenne, string examen_id)
        {
            string sql_ = "";
            try
            {
                sql = "select COUNT(id) as count_id from examen_inscription_note where inscription_id = " + Int32.Parse(inscription_id) + " and examen_id = " + examen_id+ ";";
                //sql = "INSERT INTO examen_inscription_note (inscription_id, examen_id,moyenne) VALUES ";
                mysqlComm = new MySqlCommand(sql, DatabaseManager.cnx);
                dr = mysqlComm.ExecuteReader();


                if (dr.Read())
                {
                    if (dr["count_id"].ToString().Equals("0"))
                    {
                        sql_ = "INSERT INTO examen_inscription_note (inscription_id, examen_id,moyenne) VALUES (" + Int32.Parse(inscription_id) + "," + examen_id + "," + moyenne + ");";
                       // MessageBox.Show(sql_);

                    }
                    else
                    {

                        sql_ = "UPDATE examen_inscription_note set moyenne = " + moyenne + " where inscription_id = " + Int32.Parse(inscription_id) + " and examen_id = " + examen_id + ";";
                       // MessageBox.Show(sql_);

                    }
                }

                mysqlComm = null;
                dr.Close();
                dr = null;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

            return sql_;
        }

        public static void insert_note(string inscription_id , string moyenne ,string examen_id)
        {
            try
            {
                moyenne = moyenne.Replace(",", ".");

                //MessageBox.Show(moyenne);
                //sql = "INSERT INTO examen_inscription_note (inscription_id, examen_id,moyenne) VALUES (" +Int32.Parse(inscription_id) + "," + examen_id + "," + moyenne + ");";
                //sql = "INSERT INTO examen_inscription_note (inscription_id, examen_id,moyenne) VALUES ";

                sql = find_note(inscription_id, moyenne, examen_id);

                if (sql != "")
                {
                    mysqlComm = new MySqlCommand(sql, DatabaseManager.cnx);
                    mysqlComm.ExecuteNonQuery();

                    mysqlComm = null;
                }
                else
                {
                    MessageBox.Show("la requette est vide !");
                }
               
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
                

                sql = "SELECT * FROM `examen` where Personnel_id = " + id_champs[1] + " and UniteMatiere_id =" + id_champs[2] + " and type_id = " + id_champs[3] + " and periode_id = " + id_champs[4] + " and annee_scolaire_id = " + id_champs[5];
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
                    aer = 1;
                    //MessageBox.Show("examen = rien");
                    insert_examen(id_champs);
                }

                if ( aer==0) {
                    dr.Close();
                    dr = null;
                }
                
                


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
                //MessageBox.Show("Personnel_id, UniteMatiere_id, type_id, periode_id, annee_scolaire_id) VALUES(" + id_champs[1] + ", " + id_champs[2] + ", " + id_champs[3] + ", " + id_champs[4] + ", " + id_champs[5] + ");");
                sql = "INSERT INTO examen (Personnel_id,UniteMatiere_id,type_id,periode_id,annee_scolaire_id) VALUES ("+ id_champs [1]+ "," + id_champs[2] + "," + id_champs[3] + "," + id_champs[4] + "," + id_champs[5] + ");";
                mysqlComm = new MySqlCommand(sql, DatabaseManager.cnx);
                mysqlComm.ExecuteNonQuery();

                //INSERT INTO examen (Personnel_id,UniteMatiere_id,type_id,periode_id,annee_scolaire_id) VALUES (39,843,430,433,256)
                //find examen_id
                sql = "SELECT * FROM `examen` where Personnel_id = " + id_champs[1] + " and UniteMatiere_id =" + id_champs[2] + " and type_id = " + id_champs[3] + " and periode_id = " + id_champs[4] + " and annee_scolaire_id = " + id_champs[5];
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
                //examen_id = "rien";
            }
        }


        public static string get_password(string login)
        {
            string password="";

            sql = "SELECT PASSWORD FROM `utilisateurs` where (username='" + login + "' or email='" + login+"') and typeUser in ('tuteur','eleve','Prospect','personnel') and  enabled = 1 ";
            mysqlComm = new MySqlCommand(sql, DatabaseManager.cnx);
            dr = mysqlComm.ExecuteReader();

            if (dr.Read())
            {
                password = dr["PASSWORD"].ToString();
            }
            dr.Close();
            dr = null;
            return password;

        }
    }
}
