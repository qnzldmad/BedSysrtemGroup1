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
    public partial class Medical_Staff_Login_Page : Form
    {
        public Medical_Staff_Login_Page()
        {
            InitializeComponent();   
        }
        public static string passingtext;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MSLoginDatabase database = new MSLoginDatabase();

            string ms_loginid = IdNumberTextBox.Text;
            string ms_password = PasswordTextBox.Text;

            DataTable dataTable = new DataTable();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `medicalstaff` WHERE `ms_loginid` = @usn and `ms_password` = @pass ", database.getConnection());

            mySqlCommand.Parameters.Add("@usn", MySqlDbType.VarChar).Value = ms_loginid;
            mySqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = ms_password;

            mySqlDataAdapter.SelectCommand = mySqlCommand;

            mySqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                passingtext = IdNumberTextBox.Text;
                MedicalStaffMenu medicalStaffMenu = new MedicalStaffMenu();
                medicalStaffMenu.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Login ID and Password, Please try again!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            IdNumberTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.MaxLength = 8;
        }

        private void Medical_Staff_Login_Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}
