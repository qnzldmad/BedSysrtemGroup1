using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bed_System
{
    public class rederegisterHandler
    {
        public int addReDeregister(MySqlConnection conn, rederegister rederegister)
        {
            string sql = "INSERT INTO rederegister (register_date, register_time, deregister_date, deregister_time)"
                + " VALUES ('" + rederegister.Register_date.ToString("yyyy-MM-dd") + "   ', '" + rederegister.Register_time.ToString("HH:mm:ss")
                + "   ', '" + rederegister.Deregister_date.ToString("yyyy-MM-dd") + "   ', '" + rederegister.Deregister_time.ToString("HH:mm:ss") + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }
}
