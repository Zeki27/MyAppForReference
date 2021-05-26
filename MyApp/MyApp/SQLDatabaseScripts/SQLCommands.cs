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

        #region CV Create data

        #region Personal info
        public static void CreatePersInfo(string name, string birthp, DateTime birtht, string address, string phonen, string email, int userid) 
        {
            string onlyDate = birtht.Date.ToString("yyyy-MM-dd");

            string query = string.Format("INSERT INTO myrefapppersonalinf('pi_name','pi_birthp','pi_birtht','pi_address','pi_phonen','pi_email','pi_uid')" +
                "VALUES ('" + name + "','"+ birthp + "','" + onlyDate + "','" + address + "','" + phonen + "','" + email + "', " + userid + ")");
            try
            {
                MySqlConnection dbConn = SQLConnection.NewSQLConn();

                command = new MySqlCommand(query, dbConn);
                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the personal info creation in sql /b error: " + e.Message);
                throw;
            }
        }
        #endregion

        #region Education

        public static void CreateEduc(string startdate, string enddate, string schoolnamehun, string schoolnameeng, string eduhun, string edueng, int uid)
        {
            string query = string.Format("INSERT INTO myrefappeduc('edu_startdate','ude_enddate','edu_schoolnamehun','edu_schoolnameeng','edu_eduhun','edu_edueng','edu_uid')" +
                "VALUES ('" + startdate + "','" + enddate + "','" + schoolnamehun + "','" + schoolnameeng + "','" + eduhun + "','" + edueng + "', " + uid + ")");
            try
            {
                MySqlConnection dbConn = SQLConnection.NewSQLConn();

                command = new MySqlCommand(query, dbConn);
                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the education creation in sql /b error: " + e.Message);
                throw;
            }
        }

        #endregion

        #region Work

        public static void CreateWork(string startdate, string enddate, string wpnamehun, string wpnameeng, string rolehun, string roleeng, int uid)
        {
            string query = string.Format("INSERT INTO myrefappworkp('wp_startdate','wp_enddate','wp_wpnamehun','wp_wpnameeng','wp_rolehun','wp_roleeng','wp_uid')" +
                "VALUES ('" + startdate + "','" + enddate + "','" + wpnamehun + "','" + wpnameeng + "','" + rolehun + "','" + roleeng + "', " + uid + ")");
            try
            {
                MySqlConnection dbConn = SQLConnection.NewSQLConn();

                command = new MySqlCommand(query, dbConn);
                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the workplace creation in sql /b error: " + e.Message);
                throw;
            }
        }

        #endregion

        #region Experience

        public static void CreateExp(string deschun, string desceng, int uid)
        {
            string query = string.Format("INSERT INTO myrefappexp('exp_deschun','exp_desceng','exp_uid')" +
                "VALUES ('" + deschun + "','" + desceng + "', " + uid + ")");
            try
            {
                MySqlConnection dbConn = SQLConnection.NewSQLConn();

                command = new MySqlCommand(query, dbConn);
                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the experience creation in sql /b error: " + e.Message);
                throw;
            }
        }

        #endregion

        #region Language

        public static void CreateLang(string namehun, string nameeng, string levelhun, string leveleng, int uid)
        {
            string query = string.Format("INSERT INTO myrefapplang('lang_namehun','lang_nameeng','lang_levelhun','lang_leveleng','lang_uid')" +
                "VALUES ('" + namehun + "','" + nameeng + "','" + levelhun + "','" + leveleng + "'," + uid + ")");
            try
            {
                MySqlConnection dbConn = SQLConnection.NewSQLConn();

                command = new MySqlCommand(query, dbConn);
                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the language creation in sql /b error: " + e.Message);
                throw;
            }
        }

        #endregion

        #region Driving license

        public static void CreateDrive(string cat, DateTime acdate, DateTime expdate, int uid)
        {
            string query = string.Format("INSERT INTO myrefappdrivlic('dl_cat','dl_acdate','dl_expdate','dl_uid')" +
                "VALUES ('" + cat + "','" + acdate + "','" + expdate + "'," + uid + ")");
            try
            {
                MySqlConnection dbConn = SQLConnection.NewSQLConn();

                command = new MySqlCommand(query, dbConn);
                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the driving license creation in sql /b error: " + e.Message);
                throw;
            }
        }

        #endregion

        #region Description

        public static void CreateDesc(string deschun, string desceng, int uid)
        {
            string query = string.Format("INSERT INTO myrefapppersonaldesc('pd_deschun','pd_desceng','pd_uid')" +
                "VALUES ('" + deschun + "','" + desceng + "', " + uid + ")");
            try
            {
                MySqlConnection dbConn = SQLConnection.NewSQLConn();

                command = new MySqlCommand(query, dbConn);
                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the description creation in sql /b error: " + e.Message);
                throw;
            }
        }

        #endregion

        #endregion

    }
}
