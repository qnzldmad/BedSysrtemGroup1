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
using System.Net;
using System.Collections.Specialized;
using System.IO;



namespace Bed_System
{
    public partial class emergencymonitoring : Form
    {
        public emergencymonitoring()
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

        private void pbSearch_Click(object sender, EventArgs e)
        {
            {
                mySqlConnection.Open();
                string loadMedical = "SELECT * FROM medicalstaff WHERE medicalstaff.ms_id=" + int.Parse(tbId.Text);
                mySqlCommand = new MySqlCommand(loadMedical, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    lblPhone.Text = mySqlDataReader.GetString("ms_contact");
                    lblName.Text = mySqlDataReader.GetString("ms_firstName") + mySqlDataReader.GetString("ms_lastName");
                }
                else
                {
                    MessageBox.Show("There is no such Patient ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                Stream s = client.OpenRead(string.Format("https://platform.clickatell.com/messages/http/send?apiKey=zRF8Sd70SUilWVUoI5_9ug==&to=60196557862&content=message:"+tbMessage.Text, lblPhone.Text, tbMessage.Text));
                StreamReader reader = new StreamReader(s);
                string result = reader.ReadToEnd();
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    }
    }
}


    

