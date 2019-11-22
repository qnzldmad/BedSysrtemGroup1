using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bed_System
{
    public class realtimeHandler
    {
        public int addRealTime(MySqlConnection conn, realtimeclass realtimeclass)
        {
            string sql = "INSERT INTO patientmedicaldetails (p_id, p_systolic, p_diastolic, p_breathing, p_pulse, p_temperater)"
                + " VALUES (" + realtimeclass.P_id + "  ," + realtimeclass.P_systolic + "   , " + realtimeclass.P_diastolic
                + "   , " + realtimeclass.P_breathing + "   , " + realtimeclass.P_pulse + "   , " + realtimeclass.P_temperature + ")";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }
}
