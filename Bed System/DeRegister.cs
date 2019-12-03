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
    public partial class DeRegister : Form
    {
        public DeRegister()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='eahthospital';username=root;password=");
        MySqlCommand MySqlCommand;

        public void populateDGV()
        {
            string selectQuery = "SELECT * FROM rederegister";
            DataTable table = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void DeRegister_Load(object sender, EventArgs e)
        {
            medicalIDLabel.Text = MedicalStaffMenu.passingtext1;
            lbMedicalID.Text = MedicalStaffMenu.passingtext2;

            populateDGV();
        }

        private void pbExit_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbRegister_Click(object sender, EventArgs e)
        {

            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            databaseConnertor.connect();

            rederegister rederegister = new rederegister();
            rederegister.Ms_id = int.Parse(lbMedicalID.Text);
            rederegister.Register_date = this.dateTimePicker2.Value;
            rederegister.Register_time = tbTime.Text;
            rederegister.Deregister_date = this.dateTimePicker1.Value;
            rederegister.Deregister_time = tbDtime.Text;

            rederegisterHandler rederegisterHandler = new rederegisterHandler();
            int recordCnt1 = rederegisterHandler.addReDeregister(databaseConnertor.getconn(), rederegister);
            MessageBox.Show(recordCnt1 + " record has been inserted !!");

            this.Close();
            DeRegister deRegister = new DeRegister();
            deRegister.Show();
        }

        private void resetPB_click(object sender, EventArgs e)
        {
            tbTime.Text = "";
            dateTimePicker2.Value = DateTime.Now;
        }

        private void resetPB_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.resetPB, "Reset Time");
            resetPB.BackColor = Color.Gray;
        }

        private void resetPB_MouseLeave(object sender, EventArgs e)
        {
            resetPB.BackColor = Color.White;
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

        private void pbDeregister_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE rederegister SET ms_id='" + lbMedicalID.Text + "',register_date='" + dateTimePicker1.Value + "',register_time='" + tbTime.Text + "',deregister_date='" + dateTimePicker2.Value + "',deregister_time='" + tbDtime.Text + "' WHERE rederegister_id =" + int.Parse(lbRD.Text);
            executeMyQuery(updateQuery);
            populateDGV();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Type dtp2 = dataGridView1.CurrentRow.Cells[2].Value.GetType();
            Type dtp1 = dataGridView1.CurrentRow.Cells[4].Value.GetType();
            if (dtp2 == typeof(DBNull))
            {
                dateTimePicker2.Value = DateTime.Now;
            }
            else if (dtp1 == typeof(DBNull))
            {
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                lbRD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
                tbTime.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                tbDtime.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }
    }
}
