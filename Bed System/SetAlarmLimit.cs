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
    public partial class SetAlarmLimit : Form
    {
        public SetAlarmLimit()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                mySqlConnection.Open();
                string loadPatient = "SELECT * FROM addpatient WHERE addpatient.p_id=" + int.Parse(AlarmPatientIdTextBox.Text);
                mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    AlarmPatientIdTextBox.Text = mySqlDataReader.GetString("p_id");
                    AlarmPatientNameLabel.Text = mySqlDataReader.GetString("p_firstName") + mySqlDataReader.GetString("p_lastName");
                }
                else
                {
                    MessageBox.Show("There is no such Patient ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO patientlimit(p_id, p_min_blood_sys, p_min_temperature, p_min_blood_dias, p_min_breathing_rate, p_min_pulse_rate, p_max_pulse, p_max_temperature, p_max_breathing, p_max_sys, p_max_dias) VALUES('" + AlarmPatientIdTextBox.Text + "','" + tbMinSys.Text + "','" + tbMinTemperature.Text + "'," + tbMinDias.Text + "'," + tbMinBreathing.Text + "," + tbminPulse.Text + "," + tbMaxSys.Text + "," + tbMaxTemperature.Text + "," + tbMaxDias.Text + "," + tbMaxBreathing.Text + "," + tbMaxPulse.Text + ",)";
            mySqlConnection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Record has been inserted");
                }
                else
                {
                    MessageBox.Show("Record has not been inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mySqlConnection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Hide();
            NurseMenu menu = new NurseMenu();
            menu.ShowDialog();
            this.Close();
        }
    }
}