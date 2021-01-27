using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyApp
{
    class SQLCommands
    {
        public static bool _loggedIn = false;

        //public static MySqlCommand command;

        public static void CreateUser()
        {

        }
        public static void UserLogIn(string email, string pw)
        {
            if (!_loggedIn)
            {
                MySqlConnection con = SQLConnection.NewSQLConn();
                MySqlDataAdapter adp = new MySqlDataAdapter("select count(*) from myrefappusers where user_e_mail='" + email + "' and password='" + pw + "'", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    _loggedIn = true;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password\nPlease try Again.");
                }
            }
        }
        public static void Read()
        {

        }

        public static void Update()
        {

        }

        public static void Delete()
        {

        }

    }
}
