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
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            databaseConnertor.connect();

            setalarm setalarm = new setalarm();
            setalarm.P_id = int.Parse(AlarmPatientIdTextBox.Text);
            setalarm.P_min_pulse_rate = int.Parse(tbminPulse.Text);
            setalarm.P_max_pulse = int.Parse(tbMaxPulse.Text);
            setalarm.P_min_temperature = int.Parse(tbMinTemperature.Text);
            setalarm.P_max_temperature = int.Parse(tbMaxTemperature.Text);
            setalarm.P_min_breathing_rate = int.Parse(tbMinBreathing.Text);
            setalarm.P_max_breathing = int.Parse(tbMaxBreathing.Text);
            setalarm.P_min_blood_sys = int.Parse(tbMinSys.Text);
            setalarm.P_max_sys = int.Parse(tbMaxSys.Text);
            setalarm.P_min_blood_dias = int.Parse(tbMinDias.Text);
            setalarm.P_max_dias = int.Parse(tbMaxDias.Text);

            setalarmHandler setalarmHandler = new setalarmHandler();
            int recordCnt = setalarmHandler.addSetAlarm(databaseConnertor.getconn(), setalarm);
            MessageBox.Show(recordCnt + " record has been inserted !!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}