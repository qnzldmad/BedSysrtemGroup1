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
    public partial class SearchPatient : Form
    {
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseMenu menu = new NurseMenu();
            menu.ShowDialog();
            this.Close();
        }

        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                mySqlConnection.Open();
                string loadPatient = "SELECT * FROM eahthospital.addpatient WHERE p_id=" + int.Parse(SearchTextBox.Text);
                mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    IdLabel.Text = mySqlDataReader.GetString("p_id");
                    NameLabel.Text = mySqlDataReader.GetString("p_firstName") + mySqlDataReader.GetString("p_lastName");
                    AgeLabel.Text = mySqlDataReader.GetInt32("p_age").ToString();
                    BedNumLabel.Text = mySqlDataReader.GetInt32("p_bedNum").ToString();
                    PhoneLabel.Text = mySqlDataReader.GetInt32("p_contact").ToString();
                    GenderLabel.Text = mySqlDataReader.GetString("p_gender");
                    BirthdatePicker.Value = mySqlDataReader.GetMySqlDateTime("p_dob").Value;
                    AdmissionPicker.Value = mySqlDataReader.GetMySqlDateTime("p_admission").Value;
                }
                else
                {
                    MessageBox.Show("There is no such Patient ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();

                mySqlConnection.Open();
                string loadDetails = "SELECT * FROM patientmedicaldetails WHERE patientmedicaldetails.p_id=" + int.Parse(SearchTextBox.Text);
                mySqlCommand = new MySqlCommand(loadDetails, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    systolicLabel.Text = mySqlDataReader.GetInt32("p_systolic").ToString();
                    diastolicLabel.Text = mySqlDataReader.GetInt32("p_diastolic").ToString();
                    breathingLabel.Text = mySqlDataReader.GetInt32("p_breathing").ToString();
                    pulseLabel.Text = mySqlDataReader.GetInt32("p_pulse").ToString();
                    TemperatureLabel.Text = mySqlDataReader.GetInt32("p_temperater").ToString();

                }
                else
                {
                    MessageBox.Show("There is no data for this Patient ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();

                mySqlConnection.Open();
                string loadBed = "SELECT * FROM addpatient WHERE addpatient.p_id=" + int.Parse(SearchTextBox.Text);
                mySqlCommand = new MySqlCommand(loadBed, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    BedNumLabel.Text = mySqlDataReader.GetInt32("p_bedNum").ToString();
                    FloorLabel.Text = mySqlDataReader.GetInt32("p_floor").ToString();

                }
                else
                {
                    MessageBox.Show("There is no data for this Patient ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();
            }
            else if (radioButton1.Checked)
            {
                mySqlConnection.Open();
                string loadPatient = "SELECT * FROM eahthospital.addpatient WHERE p_firstName ='" + SearchTextBox.Text + "' OR p_lastName='" + SearchTextBox.Text + "'";
                mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    IdLabel.Text = mySqlDataReader.GetString("p_id");
                    NameLabel.Text = mySqlDataReader.GetString("p_firstName") + mySqlDataReader.GetString("p_lastName");
                    AgeLabel.Text = mySqlDataReader.GetInt32("p_age").ToString();
                    PhoneLabel.Text = mySqlDataReader.GetInt32("p_contact").ToString();
                    BirthdatePicker.Value = mySqlDataReader.GetMySqlDateTime("p_dob").Value;
                    AdmissionPicker.Value = mySqlDataReader.GetMySqlDateTime("p_admission").Value;
                    GenderLabel.Text = mySqlDataReader.GetString("p_gender");
                }
                else
                {
                    MessageBox.Show("There is no such Patient Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();

                mySqlConnection.Open();
                string loadDetails = "SELECT * FROM patientmedicaldetails INNER JOIN addpatient ON addpatient.p_id = patientmedicaldetails.p_id WHERE addpatient.p_firstName='" + SearchTextBox.Text + "' OR p_lastName='" + SearchTextBox.Text + "'";
                mySqlCommand = new MySqlCommand(loadDetails, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    systolicLabel.Text = mySqlDataReader.GetInt32("p_systolic").ToString();
                    diastolicLabel.Text = mySqlDataReader.GetInt32("p_diastolic").ToString();
                    breathingLabel.Text = mySqlDataReader.GetInt32("p_breathing").ToString();
                    pulseLabel.Text = mySqlDataReader.GetInt32("p_pulse").ToString();
                    TemperatureLabel.Text = mySqlDataReader.GetInt32("p_temperater").ToString();
                }
                else
                {
                    MessageBox.Show("There is no data for this Patient Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();

                mySqlConnection.Open();
                string loadBed = "SELECT* FROM eahthospital.addpatient WHERE p_firstName = '" + SearchTextBox.Text + "' OR p_lastName = '" + SearchTextBox.Text + "'";
                mySqlCommand = new MySqlCommand(loadDetails, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    BedNumLabel.Text = mySqlDataReader.GetInt32("p_bedNum").ToString();
                    FloorLabel.Text = mySqlDataReader.GetInt32("p_floor").ToString();

                }
                else
                {
                    MessageBox.Show("There is no data for this Patient ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();
            }
            else if (!radioButton2.Checked || !radioButton1.Checked)
            {
                MessageBox.Show("Please Select an Option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
            else if (radioButton1.Checked)
            {
                if (!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
