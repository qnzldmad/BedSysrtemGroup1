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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseMenu search = new NurseMenu();
            search.ShowDialog();
            this.Close();
        }

        private void registerPictureBox_Click(object sender, EventArgs e)
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            databaseConnertor.connect();

            registers register = new registers();
            register.Register_date = this.datePicker.Value;
            register.Register_time = this.timePicker.Value;

            registerHandler rederegisterHandler = new registerHandler();
            int recordCnt1 = rederegisterHandler.addRegister(databaseConnertor.getconn(), register);
            MessageBox.Show(recordCnt1 + " record has been inserted !!");
        }

        private void deregisterPictureBox_Click(object sender, EventArgs e)
        {
            LoginIdLabel.Text = MedicalStaffMenu.passingtext1;
            datePicker.Format = DateTimePickerFormat.Time;
        }

        private void resetPictureBox_Click(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
        }

        private void resetPictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.resetPictureBox, "Reset Time");
            resetPictureBox.BackColor = Color.Gray;
        }

        private void resetPictureBox_MouseLeave(object sender, EventArgs e)
        {
            resetPictureBox.BackColor = Color.White;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            LoginIdLabel.Text = NurseLoginForm.passingtext;

            mySqlConnection.Open();
            string loadMlogin = "SELECT * FROM eahthospital.nurse WHERE s_loginid='" + LoginIdLabel.Text + "'";
            mySqlCommand = new MySqlCommand(loadMlogin, mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();


            if (mySqlDataReader.Read())
            {
                LoginIdLabel.Text = mySqlDataReader.GetString("s_id");
            }
            else
            {
                return;
            }
            mySqlConnection.Close();
        }
    }
}

       