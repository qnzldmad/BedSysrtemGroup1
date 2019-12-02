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
                + " VALUES ("+ register.S_id + "  ,'" + register.Register_date.ToString("yyyy-MM-dd") + "   ', '" + register.Register_time
                + "   ', '" + register.Deregister_date.ToString("yyyy-MM-dd") + "   ', '" + register.Deregister_time + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }

        public List<registers> getAllRegister(MySqlConnection conn)
        {
            List<registers> listregister = new List<registers>();
            string sql = "SELECT * FROM register";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;
            myReader = sqlComm.ExecuteReader();
            while (myReader.Read())
            {
                registers registers = new registers();
                registers.Register_id = (int)myReader.GetValue(0);
                registers.S_id = (int)myReader.GetValue(1);
                registers.Register_date = (DateTime)myReader.GetValue(2);
                registers.Register_time = (string)myReader.GetValue(3);
                registers.Deregister_date = (DateTime)myReader.GetValue(4);
                registers.Deregister_time = (string )myReader.GetValue(5);
                listregister.Add(registers);
            }
            return listregister;
        }
    }
}
