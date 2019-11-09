using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bed_System
{
    public class DatabaseConnertor
    {
        MySqlConnection conn;

        public string connect()
        {
            string connStr = "server=localhost;user=dbcli;database=eahthospital;port=3306;password=dbcli123";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            return "Done";
        }

        public MySqlConnection getconn()
        {
            return conn;
        }

        
    }
}
