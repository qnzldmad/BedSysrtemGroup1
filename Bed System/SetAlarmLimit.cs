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

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Hide();
            NurseMenu menu = new NurseMenu();
            menu.ShowDialog();
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseConnertor dbConn = new DatabaseConnertor();
            dbConn.connect();

            SetLimit limit = new SetLimit();
            limit.Id = int.Parse(AlarmIdTextBox.Text);
            limit.Name = AlarmPatientTextBox.Text;
            limit.Pulse = int.Parse(PulseRateUpDown.Text);
            limit.Breathing = int.Parse (BreathingRateUpDown.Text);
            limit.Blooddias = int.Parse (BloodDiasUpDown.Text);
            limit.Bloodsys = int.Parse(BloodSysUpDown.Text);
            limit.Temperature = int.Parse(TemperatureUpDown.Text);

            LimitHandler limHnd = new LimitHandler();
            int recordCnt = limHnd.SetNewLimit(dbConn.getConn(), limit);
            MessageBox.Show(recordCnt + " record has been iinserted !");

            SetAlarmLimit setNewlimit = new SetAlarmLimit();
            setNewlimit.Show();
            this.Close();
        }
    }
   
}
