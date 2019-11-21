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
    public partial class PatientMonitored : Form
    {
        public PatientMonitored()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM addpatient", connection);

                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "addpatient");
                dataGridView1.DataSource = ds.Tables["addpatient"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM patientmedicaldetails", connection);

                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "patientmedicaldetails");
                dataGridView2.DataSource = ds.Tables["patientmedicaldetails"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseMenu search = new NurseMenu();
            search.ShowDialog();
            this.Close(); ;
        }
    }
}
