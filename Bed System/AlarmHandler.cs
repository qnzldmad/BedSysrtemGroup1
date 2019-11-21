using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed_System
{
    class AlarmHandler
    {
        public int addNewAlarm(MySqlConnection conn, Alarm alarm)
        {
            string sql = "INSERT INTO patientlimit (p_id, p_pulse_rate, p_blood_sys, p_blood_dias, p_temperature, p_breathing_rate)"
                + "VALUES ('" + alarm.Name + "', " + alarm.Blooddias
                + "  , '" + alarm.Bloodsys + "' , " + alarm.Temperature
                + " , " + alarm.Breathingrate + " , " + alarm.Pulserate + " ')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }
}
