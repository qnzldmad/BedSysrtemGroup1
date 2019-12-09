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
    public partial class ReportNurse : Form
    {
        public ReportNurse()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='eahthospital';username=root;password=");
        MySqlCommand MySqlCommand;

        public void populateDGVS()
        {
            string selectQuery = "SELECT * FROM register";
            DataTable table = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(table);
            dataGridView3.DataSource = table;
        }

        private void ReportNurse_Load(object sender, EventArgs e)
        {
            populateDGVS();
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

        private void btnEditNurse_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE register SET s_id='" + lbStaffID.Text + "',register_date='" + dateTimePicker1.Value + "',register_time='" + tbTime.Text + "',deregister_date='" + dateTimePicker2.Value + "',deregister_time='" + tbDtime.Text + "' WHERE id =" + int.Parse(lbRD.Text);
            executeMyQuery(updateQuery);
            populateDGVS();
        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            Type dtp2 = dataGridView3.CurrentRow.Cells[2].Value.GetType();
            Type dtp1 = dataGridView3.CurrentRow.Cells[4].Value.GetType();
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
                lbRD.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                lbStaffID.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker2.Value = Convert.ToDateTime(dataGridView3.CurrentRow.Cells[2].Value);
                tbTime.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView3.CurrentRow.Cells[4].Value);
                tbDtime.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
