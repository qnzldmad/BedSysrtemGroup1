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

            if (table.Rows.Count > 0)
            {
                NurseLoginDatabase nurseOne = new NurseLoginDatabase();
                nurseOne.nurseID = int.Parse(s_password);
                nurseOne.nFirstName = s_loginid;
                nurseOne.nLastName = "Rea";
                nurseOne.nAge = 26;
                nurseOne.nLoginID = IdNumberTextBox.Text;

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


    }
}
