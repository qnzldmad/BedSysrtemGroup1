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
    public partial class ManagerLoginPage : Form
    {


        public ManagerLoginPage()
        {
            InitializeComponent();
            PasswordTextBox.MaxLength = 8;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MSLoginDatabase database = new MSLoginDatabase();

            string m_loginid = IdNumberTextBox.Text;
            string m_password = PasswordTextBox.Text;

            DataTable dataTable = new DataTable();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `manager` WHERE `m_loginid` = @usn and `m_password` = @pass ", database.getConnection());


            mySqlCommand.Parameters.Add("@usn", MySqlDbType.VarChar).Value = m_loginid;
            mySqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = m_password;

            mySqlDataAdapter.SelectCommand = mySqlCommand;

            mySqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                ManagerMenu managerMenu = new ManagerMenu();
                managerMenu.Show();
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

        private void ManagerLoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
