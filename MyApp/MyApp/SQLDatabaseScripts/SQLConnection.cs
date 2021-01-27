using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MyApp
{
    class SQLConnection
    {
        #region SQL properties
        public static MySqlConnection dbConn;
        //public static MySqlCommand command;

        public static string server = "localhost";
        public static string user = "root";
        public static string password = "";
        public static string database = "myrefappdb";
        public static string SslMode = "none";


        public string Username { get; private set; }
        public string Password { get; private set; }

        private SQLConnection(string u, string p)
        {
            Username = u;
            Password = p;
        }

        public static void InitializeDb()
        {
            MySqlConnection connString = new MySqlConnection("server =" + server + ";user id=" + user + "; password = " + password + ";database =" + database + ";SslMode =" + SslMode + ";");
            //MySqlConnection connString = new MySqlConnection("server=localhost;user id=root;database=exampledatabase;SslMode=none;");
            dbConn = connString;
        }
        #endregion

        //gets the new prameters from the frmModifySQLConn 
        public static void ModifyConParam(string serv, string usid, string pass, string db, string ssl)
        {
            server = serv;
            user = usid;
            password = pass;
            database = db;
            SslMode = ssl;
            MySqlConnection connString = new MySqlConnection("server =" + server + ";user id=" + user + "; password = " + password + ";database =" + database + ";SslMode =" + SslMode + ";");
            dbConn = connString;
        }

        public static MySqlConnection NewSQLConn()
        {
            MySqlConnection con = new MySqlConnection("server =" + server + ";user id=" + user + "; password = " + password + ";database =" + database + ";SslMode =" + SslMode + ";");
            return con;
        }


        //delete
        /*
        #region Create a new
        public static Class Register(string u, string p)
        {
            String query = string.Format("insert into login (username, password) values('{0}', '{1}')", u, p);

            command = new MySqlCommand(query, dbConn);

            dbConn.Open();

            command.ExecuteNonQuery();
            string Username = command.LastInsertedId.ToString();

            Class acc = new Class(u, p);

            dbConn.Close();

            return acc;
        }
        #endregion

        public static List<Class> GetSources()
        {
            List<Class> sour = new List<Class>();

            string query = "select * from login";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string u = reader["username"].ToString();
                string p = reader["password"].ToString();

                Class s = new Class(u, p);
                sour.Add(s);
            }

            dbConn.Close();

            return sour;
        }
        public void Update(string u, string p)
        {
            String query = string.Format("update login set username='{0}', password='{1}' where username='{0}'", u, p);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            cmd.ExecuteNonQuery();

            dbConn.Close();
        }

        public static Class Insert(string u, string p)
        {
            String query = string.Format("insert into login(username, password) values('{0}', '{1}')", u, p);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            cmd.ExecuteNonQuery();
            string Username = cmd.LastInsertedId.ToString();

            Class sour = new Class(u, p);

            dbConn.Close();

            return sour;
        }
        public void Delete()
        {
            String query = string.Format("delete from login where username='{0}'", Username);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();

            cmd.ExecuteNonQuery();

            dbConn.Close();

        }
        */
    }
}
