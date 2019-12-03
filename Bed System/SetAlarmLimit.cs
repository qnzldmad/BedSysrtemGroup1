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
    public partial class SetAlarmLimit : Form
    {
        public SetAlarmLimit()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='eahthospital';username=root;password=");
        MySqlCommand MySqlCommand;
        MySqlDataReader mySqlDataReader;

        public void populateDGV()
        {
            string selectQuery = "SELECT * FROM patientlimit";
            DataTable table = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void SetAlarmLimit_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            plId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            AlarmPatientIdTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbminP.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbmaxP.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbminT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbmaxT.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            tbminB.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbmaxB.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            tbminS.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbmaxS.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tbminD.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbmaxD.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        public void openConnection()
        {
            if (mySqlConnection.State == ConnectionState.Closed)
            {
                mySqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (mySqlConnection.State == ConnectionState.Open)
            {
                mySqlConnection.Close();
            }
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                MySqlCommand = new MySqlCommand(query, mySqlConnection);

                if (MySqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }

                else
                {
                    MessageBox.Show("Quert No Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            databaseConnertor.connect();

            setalarm setalarm = new setalarm();
            setalarm.P_id = int.Parse(AlarmPatientIdTextBox.Text);
            setalarm.P_min_pulse_rate = int.Parse(tbminP.Text);
            setalarm.P_max_pulse = int.Parse(tbmaxP.Text);
            setalarm.P_min_temperature = int.Parse(tbminT.Text);
            setalarm.P_max_temperature = int.Parse(tbmaxT.Text);
            setalarm.P_min_breathing_rate = int.Parse(tbminB.Text);
            setalarm.P_max_breathing = int.Parse(tbmaxB.Text);
            setalarm.P_min_blood_sys = int.Parse(tbminS.Text);
            setalarm.P_max_sys = int.Parse(tbmaxS.Text);
            setalarm.P_min_blood_dias = int.Parse(tbminD.Text);
            setalarm.P_max_dias = int.Parse(tbmaxD.Text);

            setalarmHandler setalarmHandler = new setalarmHandler();
            int recordCnt = setalarmHandler.addSetAlarm(databaseConnertor.getconn(), setalarm);
            MessageBox.Show(recordCnt + " record has been inserted !!");
            this.Close();
            SetAlarmLimit setAlarmLimit = new SetAlarmLimit();
            setAlarmLimit.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE patientlimit SET p_id=" + AlarmPatientIdTextBox.Text + ",p_min_blood_sys=" + tbminS.Text + ",p_min_temperature=" + tbminT.Text + ",p_min_blood_dias=" + tbminD.Text + ",p_min_breathing_rate=" + tbminB.Text + ",p_min_pulse_rate=" + tbminP.Text + ",p_max_pulse=" + tbmaxP.Text + ",p_max_sys=" + tbmaxS.Text + ",p_max_dias=" + tbmaxD.Text + ",p_max_temperature=" + tbmaxT.Text + ",p_max_breathing=" + tbmaxB.Text + " WHERE sa_id =" + int.Parse(plId.Text);
            executeMyQuery(updateQuery);
            populateDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM patientlimit WHERE sa_id= " + int.Parse(plId.Text);
            executeMyQuery(deleteQuery);
            populateDGV();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (AlarmPatientIdTextBox.Text == "")
            {
                MessageBox.Show("Please insert Patient ID");
            }
            else
            {
                mySqlConnection.Open();
                string loadPatient = "SELECT * FROM addpatient WHERE addpatient.p_id=" + int.Parse(AlarmPatientIdTextBox.Text);
                MySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

                mySqlDataReader = MySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    AlarmPatientIdTextBox.Text = mySqlDataReader.GetString("p_id");
                    AlarmPatientNameLabel.Text = mySqlDataReader.GetString("p_firstName") + mySqlDataReader.GetString("p_lastName");
                }
                else
                {
                    MessageBox.Show("There is no such Patient ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}