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
            string sql = "INSERT INTO patientrealtime (p_id, p_systolic, p_diastolic, p_breathing, p_pulse, p_temperature)"
                + " VALUES (" + realtimeclass.P_id + "  ," + realtimeclass.P_systolic + "   , " + realtimeclass.P_diastolic
                + "   , " + realtimeclass.P_breathing + "   , " + realtimeclass.P_pulse + "   , " + realtimeclass.P_temperature + ")";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }

        public List<realtimeclass> getAlldetails(MySqlConnection conn)
        {
            List<realtimeclass> listdetail = new List<realtimeclass>();
            string sql = "SELECT * FROM patientrealtime";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;
            myReader = sqlComm.ExecuteReader();
            while (myReader.Read())
            {
                realtimeclass realtimeclass = new realtimeclass();
                realtimeclass.Pm_id = (int)myReader.GetValue(0);
                realtimeclass.P_id = (int)myReader.GetValue(1);
                realtimeclass.P_systolic = (int)myReader.GetValue(2);
                realtimeclass.P_diastolic = (int)myReader.GetValue(3);
                realtimeclass.P_breathing = (int)myReader.GetValue(4);
                realtimeclass.P_pulse = (int)myReader.GetValue(5);
                realtimeclass.P_temperature = (int)myReader.GetValue(6);
                listdetail.Add(realtimeclass);
            }
            return listdetail;
        }
    }
}
