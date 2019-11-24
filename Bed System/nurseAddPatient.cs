using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bed_System
{
    public partial class nurseAddPatient : Form
    {
        public nurseAddPatient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            databaseConnertor.connect();

            addPatient addPatient = new addPatient();
            addPatient.P_firstName = tbFN.Text;
            addPatient.P_lastName = tbLN.Text;
            addPatient.P_age = int.Parse(lbAge.Text);
            addPatient.P_dob = this.dtpDob.Value;
            addPatient.P_contact = int.Parse(tbContact.Text);
            addPatient.P_emergencyContact = int.Parse(tbEmergency.Text);
            addPatient.P_gender = cbGender.Text;
            addPatient.P_address = tbAddress.Text;
            addPatient.P_bedNum = int.Parse(tbBed.Text);
            addPatient.P_floor = tbFloor.Text;

            addPatientHandler addPatientHandler = new addPatientHandler();
            int recordCnt = addPatientHandler.addNewPatient(databaseConnertor.getconn(), addPatient);
            MessageBox.Show(recordCnt + " record has been inserted !!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dtpDob.Value;
            DateTime to = DateTime.Now;
            TimeSpan timeSpan = to - from;
            double days = timeSpan.TotalDays;
            lbAge.Text = (days / 365).ToString("0");
        }
    }
}
