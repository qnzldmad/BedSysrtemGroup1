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
    public partial class NurseLoginForm : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
        MySqlDataReader mySqlDataReader;

        public NurseLoginForm()
        {
            InitializeComponent();
        }
        public static string passingtext;


        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.MaxLength = 8;
        }

        private void btnClear_Click(object sender, EventArgs e)

        {
            IdNumberTextBox.Text = " ";
            PasswordTextBox.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage main = new MainPage();
            main.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            NurseLoginDatabase database = new NurseLoginDatabase();

            String s_loginid = IdNumberTextBox.Text;
            String s_password = PasswordTextBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand Command = new MySqlCommand("SELECT * FROM `nurse` WHERE `s_loginid` = @usn and `s_password` = @pass ", database.getConnection());

            Command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = s_loginid;
            Command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = s_password;

            adapter.SelectCommand = Command;

            adapter.Fill(table);

            mySqlConnection.Open();
            string loadManager = "SELECT * FROM eahthospital.nurse WHERE s_loginid='" + IdNumberTextBox.Text + "'";
            Command = new MySqlCommand(loadManager, mySqlConnection);

            mySqlDataReader = Command.ExecuteReader();

            if (mySqlDataReader.Read())
            {
                label3.Text = mySqlDataReader.GetString("s_id");
                label4.Text = mySqlDataReader.GetString("s_firstName");
                label7.Text = mySqlDataReader.GetString("s_lastName");
                label8.Text = mySqlDataReader.GetString("s_age");
            }

            else
            {
                return;
            }
            mySqlConnection.Close();

            if (table.Rows.Count > 0)
            {
                NurseLoginDatabase nurseOne = new NurseLoginDatabase();
                nurseOne.nurseID = int.Parse(label3.Text);
                nurseOne.nFirstName = label4.Text;
                nurseOne.nLastName = label7.Text;
                nurseOne.nAge = int.Parse(label8.Text);
                nurseOne.nLoginID = IdNumberTextBox.Text;

                MessageBox.Show("Nurse Information" + "\n" + "\n" + "ID: " + nurseOne.nurseID + "\n" +
                   "Name: " + nurseOne.nFirstName + " " + nurseOne.nLastName + "\n" + "Age:" + nurseOne.nAge + "\n" + "Login ID: "
                   + nurseOne.nLoginID + "\n");

                passingtext = IdNumberTextBox.Text;
                this.Close();
                NurseMenu nurseMenu = new NurseMenu();
                nurseMenu.Show();
            }
            else
            {

                if (s_loginid.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (s_password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void NurseLoginForm_Load(object sender, EventArgs e)
        {
            panel3.Hide();
        }
    }
}
