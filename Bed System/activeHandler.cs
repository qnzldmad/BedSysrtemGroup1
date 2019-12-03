using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bed_System
{
    public class activeHandler
    {
        public int addActive(MySqlConnection conn, active active)
        {
            string sql = "INSERT INTO bed_active (ms_name, bed_number, emergency_datetime, staff_checkdatetime, systolic, diastolic, pulse, breathing, temperature)"
                + " VALUES ('" + active.Ms_name + "', " + active.Bed_number + ", '" + active.Emergency_datetime.ToString("yyyy-MM-dd HH:mm:ss")
                + "'   , '" + active.Staff_checkdatetime.ToString("yyyy-MM-dd HH:mm:ss") + "'  , " + active.Systolic + "  ," + active.Diastolic
                + "  , " + active.Pulse + "  , " + active.Breathing + "  , " + active.Temperature + ")";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }
}
