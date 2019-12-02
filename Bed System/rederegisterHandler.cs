using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bed_System
{
    public class rederegisterHandler
    {
        public int addReDeregister(MySqlConnection conn, rederegister rederegister)
        {
            string sql = "INSERT INTO rederegister (ms_id, register_date, register_time, deregister_date, deregister_time)"
                 + " VALUES (" + rederegister.Ms_id + "  , '" + rederegister.Register_date.ToString("yyyy-MM-dd") + "   ', '" + rederegister.Register_time
                 + "   ', '" + rederegister.Deregister_date.ToString("yyyy-MM-dd") + "   ', '" + rederegister.Deregister_time + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }

        public List<rederegister> getAllRegister(MySqlConnection conn)
        {
            List<rederegister> listregister = new List<rederegister>();
            string sql = "SELECT * FROM rederegister";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;
            myReader = sqlComm.ExecuteReader();
            while (myReader.Read())
            {
                rederegister rederegister = new rederegister();
                rederegister.Rederegister_id = (int)myReader.GetValue(0);
                rederegister.Ms_id = (int)myReader.GetValue(1);
                rederegister.Register_date = (DateTime)myReader.GetValue(2);
                rederegister.Register_time = (string)myReader.GetValue(3);
                rederegister.Deregister_date = (DateTime)myReader.GetValue(4);
                rederegister.Deregister_time = (string)myReader.GetValue(5);
                listregister.Add(rederegister);
            }
            return listregister;
        }
    }
}
