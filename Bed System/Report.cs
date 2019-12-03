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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='eahthospital';username=root;password=");

        private void Report_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM bed_active";
            DataTable table = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
