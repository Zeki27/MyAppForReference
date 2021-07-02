using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApp.Models;
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

        #region CV Read data

        #region Personal info

        public static List<mdlPersonalInfo> GetPersInfo()
        {
            List<mdlPersonalInfo> sour = new List<mdlPersonalInfo>();

            string query = "SELECT * FROM myrefapppersonalinf";

            MySqlConnection dbConn = SQLConnection.NewSQLConn();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                dbConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int piid = Int32.Parse(reader["pi_id"].ToString());
                    string piname = reader["pi_name"].ToString();
                    string pibirthp = reader["pi_birthp"].ToString();
                    DateTime myDateTime = DateTime.Parse(reader["pi_birtht"].ToString());
                    string pibirtht = myDateTime.Date.ToString("yyyy-MM-dd");
                    string piaddress = reader["pi_address"].ToString();
                    string piphone = reader["pi_phonen"].ToString();
                    string piemail = reader["pi_email"].ToString();
                    int piuid = Int32.Parse(reader["pi_uid"].ToString());

                    mdlPersonalInfo s = new mdlPersonalInfo(piid, piname, pibirthp, pibirtht, piaddress, piphone, piemail, piuid);
                    sour.Add(s);
                }

                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the personal info reading in sql /b error: " + e.Message);
                throw;
            }
            
            return sour;
        }
        #endregion

        #region Education
        public static List<mdlEducation> GetEducation()
        {
            List<mdlEducation> sour = new List<mdlEducation>();

            string query = "SELECT * FROM myrefappeduc";

            MySqlConnection dbConn = SQLConnection.NewSQLConn();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                dbConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int eduid = Int32.Parse(reader["edu_id"].ToString());
                    string edustart = reader["edu_startdate"].ToString();
                    string eduend = reader["edu_enddate"].ToString();
                    string edusnamehun = reader["edu_schoolnamehun"].ToString();
                    string edusnameeng = reader["edu_schoolnameeng"].ToString();
                    string edunamehun = reader["edu_eduhun"].ToString();
                    string edunameeng = reader["edu_edueng"].ToString();
                    int eduuid = Int32.Parse(reader["edu_uid"].ToString());

                    mdlEducation s = new mdlEducation(eduid, edustart, eduend, edusnamehun, edusnameeng, edunamehun, edunameeng, eduuid);
                    sour.Add(s);
                }

                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the education reading in sql /b error: " + e.Message);
                throw;
            }

            return sour;
        }
        #endregion

        #region Workplace
        public static List<mdlWork> GetWorkPlace()
        {
            List<mdlWork> sour = new List<mdlWork>();

            string query = "SELECT * FROM myrefappworkp";

            MySqlConnection dbConn = SQLConnection.NewSQLConn();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                dbConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int workid = Int32.Parse(reader["wp_id"].ToString());
                    string workstart = reader["wp_startdate"].ToString();
                    string workend = reader["wp_enddate"].ToString();
                    string worknamehun = reader["wp_wpnamehun"].ToString();
                    string worknameeng = reader["wp_wpnameeng"].ToString();
                    string rolehun = reader["wp_rolehun"].ToString();
                    string roleeng = reader["wp_roleeng"].ToString();
                    int workuid = Int32.Parse(reader["wp_uid"].ToString());

                    mdlWork s = new mdlWork(workid, workstart, workend, worknamehun, worknameeng, rolehun, roleeng, workuid);
                    sour.Add(s);
                }

                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the Workplace reading in sql /b error: " + e.Message);
                throw;
            }

            return sour;
        }
        #endregion

        #region Experience
        public static List<mdlExp> GetExperience()
        {
            List<mdlExp> sour = new List<mdlExp>();

            string query = "SELECT * FROM myrefappexp";

            MySqlConnection dbConn = SQLConnection.NewSQLConn();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                dbConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int expid = Int32.Parse(reader["exp_id"].ToString());
                    string expnamehun = reader["exp_deschun"].ToString();
                    string expnameeng = reader["exp_desceng"].ToString();
                    int expuid = Int32.Parse(reader["exp_uid"].ToString());

                    mdlExp s = new mdlExp(expid, expnamehun, expnameeng, expuid);
                    sour.Add(s);
                }

                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the experience reading in sql /b error: " + e.Message);
                throw;
            }

            return sour;
        }
        #endregion

        #region Language
        public static List<mdlLang> GetLanguage()
        {
            List<mdlLang> sour = new List<mdlLang>();

            string query = "SELECT * FROM myrefapplang";

            MySqlConnection dbConn = SQLConnection.NewSQLConn();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                dbConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int langid = Int32.Parse(reader["lang_id"].ToString());
                    string langnamehun = reader["lang_namehun"].ToString();
                    string langnameeng = reader["lang_nameeng"].ToString();
                    string langlevelhun = reader["lang_levelhun"].ToString();
                    string langleveleng = reader["lang_leveleng"].ToString();
                    int languid = Int32.Parse(reader["lang_uid"].ToString());

                    mdlLang s = new mdlLang(langid, langnamehun, langnameeng, langlevelhun, langleveleng, languid);
                    sour.Add(s);
                }

                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the language reading in sql /b error: " + e.Message);
                throw;
            }

            return sour;
        }
        #endregion

        #region Driving license
        public static List<mdlDrivLic> GetDrivingLicense()
        {
            List<mdlDrivLic> sour = new List<mdlDrivLic>();

            string query = "SELECT * FROM myrefappdrivlic";

            MySqlConnection dbConn = SQLConnection.NewSQLConn();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                dbConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int dlid = Int32.Parse(reader["dl_id"].ToString());
                    string dlcat = reader["dl_cat"].ToString();
                    DateTime myAcDateTime = DateTime.Parse(reader["dl_acdate"].ToString());
                    string dlacdate = myAcDateTime.Date.ToString("yyyy-MM-dd");
                    DateTime myExDateTime = DateTime.Parse(reader["dl_expdate"].ToString());
                    string dlexdate = myExDateTime.Date.ToString("yyyy-MM-dd");
                    int dluid = Int32.Parse(reader["dl_uid"].ToString());

                    mdlDrivLic s = new mdlDrivLic(dlid, dlcat, dlacdate, dlexdate, dluid);
                    sour.Add(s);
                }

                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the driving license reading in sql /b error: " + e.Message);
                throw;
            }

            return sour;
        }
        #endregion

        #region Personal description
        public static List<mdlPersonalDesc> GetPersDesc()
        {
            List<mdlPersonalDesc> sour = new List<mdlPersonalDesc>();

            string query = "SELECT * FROM myrefapppersonaldesc";

            MySqlConnection dbConn = SQLConnection.NewSQLConn();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                dbConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int pdid = Int32.Parse(reader["pd_id"].ToString());
                    string pdhun = reader["pd_deschun"].ToString();
                    string pdeng = reader["pd_desceng"].ToString();
                    int pduid = Int32.Parse(reader["pd_uid"].ToString());

                    mdlPersonalDesc s = new mdlPersonalDesc(pdid, pdhun, pdeng, pduid);
                    sour.Add(s);
                }

                dbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("There was some error running the personal description reading in sql /b error: " + e.Message);
                throw;
            }

            return sour;
        }
        #endregion


        #endregion

        #region CV Write data

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
