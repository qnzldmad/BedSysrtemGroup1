using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bed_System
{
    public class addNursesHandler
    {
        public int addNewNurse(MySqlConnection conn, addNurses addNurse)
        {
            string sql = "INSERT INTO nurse (s_position, s_firstName, s_lastName, s_age, s_dob, s_contact, s_email, s_loginid, s_password)"
                + " VALUES ('" + addNurse.S_position + "', '" + addNurse.S_firstName + "', '" + addNurse.S_lastName
                + "   ', " + addNurse.S_age + ", '" + addNurse.S_dob.ToString("yyyy-MM-dd")
                + "   ', " + addNurse.S_contact + "   , '" + addNurse.S_email
                + "'   , '" + addNurse.S_loginid + "   ', '" + addNurse.S_password + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }
}
