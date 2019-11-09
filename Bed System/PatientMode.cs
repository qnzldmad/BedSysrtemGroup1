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
    public partial class PatientMode : Form
    {
        public PatientMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;

        private void searchpipb_click(object sender, EventArgs e)
        {
            mySqlConnection.Open();

            string loadPatient = "SELECT * FROM eahthospital.addpatient WHERE p_id=" + int.Parse(tbPID.Text);
            mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (mySqlDataReader.Read())
            {
                lbName.Text = mySqlDataReader.GetString("p_firstName") + mySqlDataReader.GetString("p_lastName");
                lbAge.Text = mySqlDataReader.GetInt32("p_age").ToString();
                lbContact.Text = mySqlDataReader.GetInt32("p_contact").ToString();
                dtpdob.Value = mySqlDataReader.GetMySqlDateTime("p_dob").Value;
                lbgender.Text = mySqlDataReader.GetString("p_gender");
            }
            else
            {
                MessageBox.Show("There is no data for this Patient ID");
            }

            mySqlConnection.Close();

            mySqlConnection.Open();

            string loadDetails = "SELECT * FROM eahthospital.patientmedicaldetails WHERE p_id=" + int.Parse(tbPID.Text);
            mySqlCommand = new MySqlCommand(loadDetails, mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (mySqlDataReader.Read())
            {
                lbSy.Text = mySqlDataReader.GetInt32("p_systolic").ToString();
                lbDi.Text = mySqlDataReader.GetInt32("p_diastolic").ToString();
                lbBr.Text = mySqlDataReader.GetInt32("p_breathing").ToString();
                lbPu.Text = mySqlDataReader.GetInt32("p_pulse").ToString();
                lbTe.Text = mySqlDataReader.GetInt32("p_temperater").ToString();
            }
            else
            {
                MessageBox.Show("There is no data for this Patient ID");
            }

            mySqlConnection.Close();
        }
    }
}
