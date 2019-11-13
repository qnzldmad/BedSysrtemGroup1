using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bed_System
{
    class NurseLoginDatabase
    {

        private MySqlConnection connection = new MySqlConnection("server = localhost; port=3306;username=root;password=;database=eahthospital");
        internal string nLoginID;
        internal int nAge;
        internal string nLastName;
        internal object nFirstName;
        internal int nurseID;

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}

   
    
