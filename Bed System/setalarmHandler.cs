using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bed_System
{
    public class setalarmHandler
    {
        public int addSetAlarm(MySqlConnection conn, setalarm setalarm)
        {
            string sql = "INSERT INTO patientlimit (p_id, p_min_blood_sys, p_min_temperature, p_min_blood_dias, p_min_breathing_rate, p_min_pulse_rate, p_max_pulse, p_max_sys, p_max_dias, p_max_temperature, p_max_breathing)"
                + " VALUES (" + setalarm.P_id + "  ," + setalarm.P_min_blood_sys + "   , " + setalarm.P_min_temperature
                + "   , " + setalarm.P_min_blood_dias + "   , " + setalarm.P_min_breathing_rate + "   , " + setalarm.P_min_pulse_rate
                + "   , " + setalarm.P_max_pulse + "   , " + setalarm.P_max_sys + "   , " + setalarm.P_max_dias + "   , " + setalarm.P_max_temperature
                + "   , " + setalarm.P_max_breathing + ")";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }
}
