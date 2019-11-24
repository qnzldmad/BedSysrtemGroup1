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
    public partial class ActiveBedside : Form
    {
        public ActiveBedside()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseMenu mute = new NurseMenu();
            mute.ShowDialog();
            this.Close();
        }

        private void ActiveBedside_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            string loadPatient = "SELECT * FROM bed_status WHERE bed_status.id=" + int.Parse(bedNumberTextBox.Text);
            mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (mySqlDataReader.Read())
            {
                bedNumberTextBox.Text = mySqlDataReader.GetString("id");
                lblBed.Text = mySqlDataReader.GetString("status") ;
            }
            else
            {
                MessageBox.Show("There is no such Bed Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mySqlConnection.Close();
        }

       
    }
}
