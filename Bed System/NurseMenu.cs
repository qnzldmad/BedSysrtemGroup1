using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Bed_System
{
    public partial class NurseMenu : Form
    {
        public NurseMenu()
        {
            InitializeComponent();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseLoginForm login = new NurseLoginForm();
            login.ShowDialog();
            this.Close();
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchPatient search = new SearchPatient();
            search.ShowDialog();
            this.Close();
        }



        private void btnAlarmLimit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetAlarmLimit alarm = new SetAlarmLimit();
            alarm.ShowDialog();
            this.Close();
        }

        private void btnMuteAlarm_Click(object sender, EventArgs e)
        {
            this.Hide();
            MuteAlarm mute = new MuteAlarm();
            mute.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActiveBedside bedside = new ActiveBedside();
            bedside.ShowDialog();
            this.Close();
        }

        private void NurseIdLabel_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection("server = localhost; port=3306;username=root;password=;database=eahthospital");
            command.Connection = conn;
            command.CommandText = "SELECT COUNT(1) FROM TABLE";
            conn.Open();
            NurseIdLabel.Text = command.ExecuteScalar().ToString();
            conn.Close();
        }

        private void btnSearchPatient_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SearchPatient search = new SearchPatient();
            search.ShowDialog();
            this.Close();
        }

        private void btnPatientMonitored_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientMonitored search = new PatientMonitored();
            search.ShowDialog();
            this.Close();
        }
    }
}

