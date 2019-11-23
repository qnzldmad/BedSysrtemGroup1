using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bed_System
{
    public class addMedicalstaffshandler
    {
        public int addNewMedicalStaff(MySqlConnection conn, addMedicalstaffs addMedicalStaff)
        {
            string sql = "INSERT INTO medicalstaff (ms_position, ms_firstName, ms_lastName, ms_age, ms_dob, ms_contact, ms_email, ms_loginid, ms_password)"
                + " VALUES ('" + addMedicalStaff.Ms_position + "', '" + addMedicalStaff.Ms_firstName + "', '" + addMedicalStaff.Ms_lastName
                + "   ', " + addMedicalStaff.Ms_age + ", '" + addMedicalStaff.Ms_dob.ToString("yyyy-MM-dd")
                + "   ', " + addMedicalStaff.Ms_contact + "   , '" + addMedicalStaff.Ms_email
                + "'   , '" + addMedicalStaff.Ms_loginid + "   ', '" + addMedicalStaff.Ms_password + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }
}
