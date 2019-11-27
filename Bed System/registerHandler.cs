using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bed_System
{
    class registerHandler
    {
        public int addRegister(MySqlConnection conn, registers register)
        {
            string sql = "INSERT INTO register (s_id, register_date, register_time, deregister_date, deregister_time)"
                + " VALUES ("+ register.S_id + "  ,'" + register.Register_date.ToString("yyyy-MM-dd") + "   ', '" + register.Register_time.ToString("HH:mm:ss")
                + "   ', '" + register.Deregister_date.ToString("yyyy-MM-dd") + "   ', '" + register.Deregister_time.ToString("HH:mm:ss") + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }
}
