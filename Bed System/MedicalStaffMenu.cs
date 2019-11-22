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
    public partial class MedicalStaffMenu : Form
    {
        public MedicalStaffMenu()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;

        public static string passingtext1;
        public static string passingtext2;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void deRegisterPB_click(object sender, EventArgs e)
        {
            passingtext1 = medicalIDLabel.Text;
            passingtext2 = medicalStaffID.Text;
            DeRegister deRegister = new DeRegister();
            deRegister.Show();
        }

        private void setPatientPB_click(object sender, EventArgs e)
        {
            PatientInfoSystem patientInfoSystem = new PatientInfoSystem();
            patientInfoSystem.Show();
        }

        private void selectModulePB_click(object sender, EventArgs e)
        {
            this.Hide();
            SelectModule select = new SelectModule();
            select.ShowDialog();
            this.Close();

        }

        private void deRegisterPB_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.deRegisterPB, "Register / Deregister");
            deRegisterPB.BackColor = Color.Gray;
        }

        private void setPatientPB_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.setPatientPB, "Set/Display Patient Details");
            setPatientPB.BackColor = Color.Gray;
        }

        private void selectModulePB_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.selectModulePB, "Select Modules");
            selectModulePB.BackColor = Color.Gray;
        }

        private void deRegisterPB_MouseLeave(object sender, EventArgs e)
        {
            deRegisterPB.BackColor = Color.White;
        }

        private void setPatientPB_MouseLeave(object sender, EventArgs e)
        {
            setPatientPB.BackColor = Color.White;
        }

        private void selectModulePB_MouseLeave(object sender, EventArgs e)
        {
            selectModulePB.BackColor = Color.White;
        }


        private void MedicalStaffMenu_Load(object sender, EventArgs e)
        {
            medicalIDLabel.Text = Medical_Staff_Login_Page.passingtext;

            mySqlConnection.Open();
            string loadMlogin = "SELECT * FROM eahthospital.medicalstaff WHERE ms_loginid='" + medicalIDLabel.Text + "'";
            mySqlCommand = new MySqlCommand(loadMlogin, mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (mySqlDataReader.Read())
            {
                medicalStaffID.Text = mySqlDataReader.GetString("ms_id");
            }

            else
            {
                return;
            }
            mySqlConnection.Close();

        }
    }
}
