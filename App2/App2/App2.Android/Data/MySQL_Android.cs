using System.IO;
using App2.Data;
using App2.Droid.Data;
using MySql.Data.MySqlClient;
using Xamarin.Forms;

[assembly: Dependency(typeof(MySQL_Android))]

namespace App2.Droid.Data
{
    public class MySQL_Android : IMySQL
    {
        public MySQL_Android() { }

        public MySqlConnection GetMySqlConnection()
        {
           /*
                MySqlConnection conn = new MySqlConnection("server=db4free.net;port=3307;database=h21db;user id=hamadvideos;password=hamadvideos;charset=utf8");

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        tvTips.Text = " Successfully connected";
                        MySqlCommand cmd = new MySqlCommand("insert into testTest(username,userpass) values(@user,@pass)", conn);
                        cmd.Parameters.AddWithValue("@user", userPar);
                        cmd.Parameters.AddWithValue("@pass", passPar);
                        cmd.ExecuteNonQuery();
                        tvTips.Text = "Successfully Signup";
                    }

                }
                catch (MySqlException ex)
                {
                    tvTips.Text = ex.ToString();
                }
                finally
                {
                    conn.Close();
                }
            */
        }
    }
}