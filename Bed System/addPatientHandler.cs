using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bed_System
{
    public class addPatientHandler
    {
        public int addNewPatient(MySqlConnection conn, addPatient addPatient)
        {
            string sql = "INSERT INTO addPatient (p_firstName, p_lastName, p_age, p_dob, p_contact, p_emergencyContact, p_gender, p_address, p_bedNum, p_floor, p_admission)"
                + " VALUES ('" + addPatient.P_firstName + "', '" + addPatient.P_lastName
                + "   ', " + addPatient.P_age + ", '" + addPatient.P_dob.ToString("yyyy-MM-dd") 
                + "   ', " + addPatient.P_contact + "   , " + addPatient.P_emergencyContact 
                + "   , '" + addPatient.P_gender + "   ', '" + addPatient.P_address + "   ', " + addPatient.P_bedNum + "  , '" + addPatient.P_floor + "'   , '"
                + addPatient.P_admission +"')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }

        public List<addPatient> getAllPatient(MySqlConnection conn)
        {
            List<addPatient> listLabr = new List<addPatient>();
            string sql = "SELECT * FROM addpatient";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;
            myReader = sqlComm.ExecuteReader();
            while (myReader.Read())
            {
                addPatient aLabr = new addPatient();
                aLabr.P_id = (int)myReader.GetValue(0);
                aLabr.P_firstName = (string)myReader.GetValue(1);
                aLabr.P_lastName = (string)myReader.GetValue(2);
                aLabr.P_age = (int)myReader.GetValue(3);
                aLabr.P_dob = (DateTime)myReader.GetValue(4);
                aLabr.P_contact = (int)myReader.GetValue(5);
                aLabr.P_emergencyContact = (int)myReader.GetValue(6);
                aLabr.P_gender = (string)myReader.GetValue(7);
                aLabr.P_address = (string)myReader.GetValue(8);
                aLabr.P_bedNum = (int)myReader.GetValue(9);
                aLabr.P_floor = (string)myReader.GetValue(10);
                aLabr.P_admission = (DateTime)myReader.GetValue(11);
                listLabr.Add(aLabr);
            }
            return listLabr;
        }
    }
}
