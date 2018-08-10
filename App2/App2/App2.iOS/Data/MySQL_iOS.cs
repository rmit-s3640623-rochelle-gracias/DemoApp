using System.IO;
using App2.Data;
using App2.iOS.Data;
using MySql.Data.MySqlClient;
using Xamarin.Forms;

[assembly: Dependency(typeof(MySQL_iOS))]

namespace App2.iOS.Data
{
    public class MySQL_iOS : IMySQL
    {
        public MySQL_iOS() { }

        public MySqlConnection GetMySqlConnection()
        {
            var filename = "TestDB.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, filename);
            var connection = new MySqlConnection(path);
            return connection;
        }

    }
}