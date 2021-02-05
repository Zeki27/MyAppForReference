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

        public static MySqlCommand command;

        public static void CreateUser()
        {

        }

        #region LogIn
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
        #endregion

        #region CreateWebsiteNews

        public static void CreateWebsiteNews(string titlehu, string deschu, string titleen, string descen)
        {
            DateTime myDateTime = DateTime.Now;
            string onlyDate = myDateTime.Date.ToString("yyyy-MM-dd");

            string query= string.Format("INSERT INTO myrefappnews (`myrefappnewsnamehun`, `myrefappnewsnameeng`, `myrefappnewsdate`, `myrefappnewsdeschun`, `myrefappnewsdesceng`, `myrefappnewsuserid`) VALUES ('" + titlehu + "','" + titleen + "','" + onlyDate + "','" + deschu + "','" + descen + "'," + 1.ToString() + ")");

            MySqlConnection dbConn = SQLConnection.NewSQLConn();


            command = new MySqlCommand(query, dbConn);
            dbConn.Open();

            command.ExecuteNonQuery();

            dbConn.Close();

            MessageBox.Show("News Succesfuly Created!");

        }


        #endregion
    }
}
