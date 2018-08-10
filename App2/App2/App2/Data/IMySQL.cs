using System.Data;
using MySql.Data.MySqlClient;

namespace App2.Data
{
    public interface IMySQL
    {
        MySqlConnection GetMySqlConnection();
    }
}
