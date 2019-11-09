using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bed_System
{
    public class pmdetailsHandler
    {
        public int addNewDetails(MySqlConnection conn, pmdetails pmdetails)
        {
            string sql = "INSERT INTO patientmedicaldetails (p_id, p_systolic, p_diastolic, p_breathing, p_pulse, p_temperater)"
                + " VALUES (" + pmdetails.P_id + " , " + pmdetails.P_systolic + "   , " + pmdetails.P_diastolic
                + "   , " + pmdetails.P_breathing + ", " + pmdetails.P_pulse + "   , " + pmdetails.P_temperater1 + ")";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }

        public List<pmdetails> getAlldetails(MySqlConnection conn)
        {
            List<pmdetails> listdetail = new List<pmdetails>();
            string sql = "SELECT * FROM patientmedicaldetails";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;
            myReader = sqlComm.ExecuteReader();
            while (myReader.Read())
            {
                pmdetails aDetail = new pmdetails();
                aDetail.Pm_id = (int)myReader.GetValue(0);
                aDetail.P_id = (int)myReader.GetValue(1);
                aDetail.P_systolic = (int)myReader.GetValue(2);
                aDetail.P_diastolic = (int)myReader.GetValue(3);
                aDetail.P_breathing = (int)myReader.GetValue(4);
                aDetail.P_pulse = (int)myReader.GetValue(5);
                aDetail.P_temperater1 = (int)myReader.GetValue(6);
                listdetail.Add(aDetail);
            }
            return listdetail;
        }
    }
}
