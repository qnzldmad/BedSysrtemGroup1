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
    public partial class PatientInfoSystem : Form
    {
        public PatientInfoSystem()
        {
            InitializeComponent();
        }

        private void addPatientPB_click(object sender, EventArgs e)
        {
            addPatientPanel.Show();
            informPanel.Hide();
            medicalPanel.Hide();
            addDetailPanel.Hide();
            searchPanel.Hide();

            addPatientPB.BorderStyle = BorderStyle.Fixed3D;
            medicalDetailPB.BorderStyle = BorderStyle.None;
            displayPB.BorderStyle = BorderStyle.None;
            searchPB.BorderStyle = BorderStyle.None;
        }

        private void PatientInfoSystem_Load(object sender, EventArgs e)
        {
            addPatientPanel.Hide();
            informPanel.Hide();
            medicalPanel.Hide();
            addDetailPanel.Hide();
            searchPanel.Hide();

            addPatientPanel.Width = 588;
            addPatientPanel.Height = 377;
            addPatientPanel.Location = new Point(12, 182);
            informPanel.Width = 291;
            informPanel.Height = 377;
            informPanel.Location = new Point(12, 182);
            medicalPanel.Width = 291;
            medicalPanel.Height = 377;
            medicalPanel.Location = new Point(309, 182);
            addDetailPanel.Width = 588;
            addDetailPanel.Height = 377;
            addDetailPanel.Location = new Point(12, 182);
            searchPanel.Width = 588;
            searchPanel.Height = 377;
            searchPanel.Location = new Point(12, 182);

            dateTimePicker2.Format = DateTimePickerFormat.Time;
        }

        private void medicalDetailPB_click(object sender, EventArgs e)
        {
            addPatientPanel.Hide();
            informPanel.Hide();
            medicalPanel.Hide();
            addDetailPanel.Show();
            searchPanel.Hide();

            addPatientPB.BorderStyle = BorderStyle.None;
            medicalDetailPB.BorderStyle = BorderStyle.Fixed3D;
            displayPB.BorderStyle = BorderStyle.None;
            searchPB.BorderStyle = BorderStyle.None;
        }

        private void displayPB_click(object sender, EventArgs e)
        {
            addPatientPanel.Hide();
            informPanel.Show();
            medicalPanel.Show();
            addDetailPanel.Hide();
            searchPanel.Hide();

            addPatientPB.BorderStyle = BorderStyle.None;
            medicalDetailPB.BorderStyle = BorderStyle.None;
            displayPB.BorderStyle = BorderStyle.Fixed3D;
            searchPB.BorderStyle = BorderStyle.None;
        }

        private void searchPB_click(object sender, EventArgs e)
        {
            addPatientPanel.Hide();
            informPanel.Hide();
            medicalPanel.Hide();
            addDetailPanel.Hide();
            searchPanel.Show();

            addPatientPB.BorderStyle = BorderStyle.None;
            medicalDetailPB.BorderStyle = BorderStyle.None;
            displayPB.BorderStyle = BorderStyle.None;
            searchPB.BorderStyle = BorderStyle.Fixed3D;

            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            databaseConnertor.connect();
            addPatientHandler addPatientHandler = new addPatientHandler();

            patientDAT.DataSource = addPatientHandler.getAllPatient(databaseConnertor.getconn());

            DatabaseConnertor database = new DatabaseConnertor();
            databaseConnertor.connect();
            pmdetailsHandler pmdetailsHandler = new pmdetailsHandler();

            dataGridView1.DataSource = pmdetailsHandler.getAlldetails(databaseConnertor.getconn());
        }

        private void exitPB_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dobDTP_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dobDTP.Value;
            DateTime to = DateTime.Now;
            TimeSpan timeSpan = to - from;
            double days = timeSpan.TotalDays;
            ageLabel.Text = (days / 365).ToString("0");
        }

        private void addPatientPB_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.addPatientPB, "Add Patient");
            addPatientPB.BackColor = Color.Gray;
        }

        private void addPatientPB_MouseLeave(object sender, EventArgs e)
        {
            addPatientPB.BackColor = Color.White;
        }

        private void medicalDetailPB_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.medicalDetailPB, "Add Medical Details");
            medicalDetailPB.BackColor = Color.Gray;
        }

        private void medicalDetailPB_MouseLeave(object sender, EventArgs e)
        {
            medicalDetailPB.BackColor = Color.White;
        }

        private void displayPB_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.displayPB, "Display Patient Details");
            displayPB.BackColor = Color.Gray;
        }

        private void displayPB_MouseLeave(object sender, EventArgs e)
        {
            displayPB.BackColor = Color.White;
        }

        private void searchPB_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.searchPB, "Search Patient");
            searchPB.BackColor = Color.Gray;
        }

        private void searchPB_MouseLeave(object sender, EventArgs e)
        {
            searchPB.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            systolicTB.Text = "";
            diastolicTB.Text = "";
            breathingTB.Text = "";
            pulseTB.Text = "";
            temperatureTB.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firstNameTB.Text = "";
            lastNameTB.Text = "";
            ageLabel.Text = "";
            dobDTP.Value = DateTime.Now;
            contactTB.Text = "";
            emergencyContactTB.Text = "";
            genderCB.Text = "";
            addressTB.Text = "";
            tbFloor.Text = "";
            tbBed.Text = "";
            dtpAdmission.Value = DateTime.Now;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            databaseConnertor.connect();

            addPatient addPatient = new addPatient();
            addPatient.P_firstName = firstNameTB.Text;
            addPatient.P_lastName = lastNameTB.Text;
            addPatient.P_age = int.Parse(ageLabel.Text);
            addPatient.P_dob = this.dobDTP.Value;
            addPatient.P_contact = int.Parse(contactTB.Text);
            addPatient.P_emergencyContact = int.Parse(emergencyContactTB.Text);
            addPatient.P_gender = genderCB.Text;
            addPatient.P_address = addressTB.Text;
            addPatient.P_floor = tbFloor.Text;
            addPatient.P_bedNum = int.Parse(tbBed.Text);
            addPatient.P_admission = this.dtpAdmission.Value;

            addPatientHandler addPatientHandler = new addPatientHandler();
            int recordCnt = addPatientHandler.addNewPatient(databaseConnertor.getconn(), addPatient);
            MessageBox.Show(recordCnt + " record has been inserted !!");
        }

        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        private void patientSearchPB_click(object sender, EventArgs e)
        {
            if (rbSI.Checked)
            {
                mySqlConnection.Open();

                string loadPatient = "SELECT * FROM eahthospital.addpatient WHERE p_id=" + int.Parse(txtsearchpatient.Text);
                mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    patientIDTB.Text = mySqlDataReader.GetString("p_id");
                    pNameTB.Text = mySqlDataReader.GetString("p_firstName") + mySqlDataReader.GetString("p_lastName");
                    pAgeTB.Text = mySqlDataReader.GetInt32("p_age").ToString();
                    pContactTB.Text = mySqlDataReader.GetInt32("p_contact").ToString();
                    pEContactTB.Text = mySqlDataReader.GetInt32("p_emergencyContact").ToString();
                    dobTB.Value = mySqlDataReader.GetMySqlDateTime("p_dob").Value;
                    genderTB.Text = mySqlDataReader.GetString("p_gender");
                    addTB.Text = mySqlDataReader.GetString("p_address");
                }
                else
                {
                    MessageBox.Show("There is no data for this Patient ID");
                }

                mySqlConnection.Close();
            }
            else if (rbSN.Checked)
            {
                mySqlConnection.Open();
                string loadPatient = "SELECT * FROM eahthospital.addpatient WHERE p_firstName ='" + txtsearchpatient.Text + "' OR p_lastName='" + txtsearchpatient.Text + "'";
                mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    patientIDTB.Text = mySqlDataReader.GetString("p_id");
                    pNameTB.Text = mySqlDataReader.GetString("p_firstName") + mySqlDataReader.GetString("p_lastName");
                    pAgeTB.Text = mySqlDataReader.GetInt32("p_age").ToString();
                    pContactTB.Text = mySqlDataReader.GetInt32("p_contact").ToString();
                    pEContactTB.Text = mySqlDataReader.GetInt32("p_emergencyContact").ToString();
                    dobTB.Value = mySqlDataReader.GetMySqlDateTime("p_dob").Value;
                    genderTB.Text = mySqlDataReader.GetString("p_gender");
                    addTB.Text = mySqlDataReader.GetString("p_address");
                }
                else
                {
                    MessageBox.Show("There is no data for this Patient Name");
                }
            }
            else if (!rbSI.Checked || !rbSN.Checked)
            {
                MessageBox.Show("Please Select an Option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            databaseConnertor.connect();

            pmdetails pmdetails = new pmdetails();
            pmdetails.P_id = int.Parse(patientIDTB.Text);
            pmdetails.P_systolic = int.Parse(systolicTB.Text);
            pmdetails.P_diastolic = int.Parse(diastolicTB.Text);
            pmdetails.P_breathing = int.Parse(breathingTB.Text);
            pmdetails.P_pulse = int.Parse(pulseTB.Text);
            pmdetails.P_temperater1 = double.Parse(temperatureTB.Text);

            pmdetailsHandler pmdetailsHandler = new pmdetailsHandler();
            int recordCnt2 = pmdetailsHandler.addNewDetails(databaseConnertor.getconn(), pmdetails);
            MessageBox.Show(recordCnt2 + " record has been inserted !!");
        }

        private void resetpb_click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void resetpb_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.resetpb, "Reset Time");
            resetpb.BackColor = Color.Gray;
        }

        private void resetpb_MouseLeave(object sender, EventArgs e)
        {
            resetpb.BackColor = Color.White;
        }
        
        private void piSearchpb_Click(object sender, EventArgs e)
        {
            if (rbSearchID.Checked)
            {
                mySqlConnection.Open();

                string loadPatient = "SELECT * FROM eahthospital.addpatient WHERE p_id=" + int.Parse(patientNameTB.Text);
                mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    patientIDLabel.Text = mySqlDataReader.GetString("p_id");
                    patientNameLabel.Text = mySqlDataReader.GetString("p_firstName") + mySqlDataReader.GetString("p_lastName");
                    patientAgeLabel.Text = mySqlDataReader.GetInt32("p_age").ToString();
                    contactLabel.Text = mySqlDataReader.GetInt32("p_contact").ToString();
                    emergencyContactLabel.Text = mySqlDataReader.GetInt32("p_emergencyContact").ToString();
                    dtodob.Value = mySqlDataReader.GetMySqlDateTime("p_dob").Value;
                    genderLabel.Text = mySqlDataReader.GetString("p_gender");
                    lbFloor.Text = mySqlDataReader.GetString("p_floor");
                    lbBed.Text = mySqlDataReader.GetInt32("p_bedNum").ToString();
                    dtpAdmissions.Value = mySqlDataReader.GetMySqlDateTime("p_admission").Value;
                    lbAdd.Text = mySqlDataReader.GetString("p_address");
                }
                else
                {
                    MessageBox.Show("There is no personal information data for this Patient ID");
                }

                mySqlConnection.Close();

                mySqlConnection.Open();

                string loadDetails = "SELECT * FROM eahthospital.patientmedicaldetails WHERE p_id=" + int.Parse(patientNameTB.Text);
                mySqlCommand = new MySqlCommand(loadDetails, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    systolicLabel.Text = mySqlDataReader.GetInt32("p_systolic").ToString();
                    diastolicLabel.Text = mySqlDataReader.GetInt32("p_diastolic").ToString();
                    breathingLabel.Text = mySqlDataReader.GetInt32("p_breathing").ToString();
                    pulseLabel.Text = mySqlDataReader.GetInt32("p_pulse").ToString();
                    temperatureLabel.Text = mySqlDataReader.GetInt32("p_temperater").ToString();
                }
                else
                {
                    MessageBox.Show("There is no medical details data for this Patient ID");
                }

                mySqlConnection.Close();
            }
            else if (rbSearchN.Checked)
            {
                mySqlConnection.Open();
                string loadPatient = "SELECT * FROM eahthospital.addpatient WHERE p_firstName ='" + patientNameTB.Text + "' OR p_lastName='" + patientNameTB.Text + "'";
                mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    patientIDLabel.Text = mySqlDataReader.GetString("p_id");
                    patientNameLabel.Text = mySqlDataReader.GetString("p_firstName") + mySqlDataReader.GetString("p_lastName");
                    patientAgeLabel.Text = mySqlDataReader.GetInt32("p_age").ToString();
                    contactLabel.Text = mySqlDataReader.GetInt32("p_contact").ToString();
                    emergencyContactLabel.Text = mySqlDataReader.GetInt32("p_emergencyContact").ToString();
                    dtodob.Value = mySqlDataReader.GetMySqlDateTime("p_dob").Value;
                    genderLabel.Text = mySqlDataReader.GetString("p_gender");
                    lbFloor.Text = mySqlDataReader.GetString("p_floor");
                    lbBed.Text = mySqlDataReader.GetInt32("p_bedNum").ToString();
                    dtpAdmissions.Value = mySqlDataReader.GetMySqlDateTime("p_admission").Value;
                }
                else
                {
                    MessageBox.Show("There is no personal information data for this Patient Name");
                }
                mySqlConnection.Close();

                mySqlConnection.Open();
                string loadDetails = "SELECT * FROM patientmedicaldetails INNER JOIN addpatient ON addpatient.p_id = patientmedicaldetails.p_id WHERE addpatient.p_firstName='" + patientNameTB.Text + "' OR p_lastName='" + patientNameTB.Text + "'";
                mySqlCommand = new MySqlCommand(loadDetails, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    systolicLabel.Text = mySqlDataReader.GetInt32("p_systolic").ToString();
                    diastolicLabel.Text = mySqlDataReader.GetInt32("p_diastolic").ToString();
                    breathingLabel.Text = mySqlDataReader.GetInt32("p_breathing").ToString();
                    pulseLabel.Text = mySqlDataReader.GetInt32("p_pulse").ToString();
                    temperatureLabel.Text = mySqlDataReader.GetInt32("p_temperater").ToString();
                }
                else
                {
                    MessageBox.Show("There is no medical details data for this Patient Name");
                }
                mySqlConnection.Close();
            }
            else if (!rbSearchID.Checked || !rbSearchN.Checked)
            {
                MessageBox.Show("Please Select an Option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
