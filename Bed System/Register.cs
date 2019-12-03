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

        public void populateDGV()
        {
            string selectQuery = "SELECT * FROM register";
            DataTable table = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

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
            register.S_id = int.Parse(LoginIdLabel.Text);
            register.Register_date = this.datePicker.Value;
            register.Register_time = tbTime.Text;
            register.Deregister_date = this.datePicker1.Value;
            register.Deregister_time = tbDtime.Text;

            registerHandler registerHandler = new registerHandler();
            int recordCnt1 = registerHandler.addRegister(databaseConnertor.getconn(), register);
            MessageBox.Show(recordCnt1 + " record has been inserted !!");

            this.Close();
            Register register1 = new Register();
            register1.Show();
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
                mySqlCommand = new MySqlCommand(query, mySqlConnection);

                if (mySqlCommand.ExecuteNonQuery() == 1)
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

        private void deregisterPictureBox_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE register SET s_id='" + LoginIdLabel.Text + "',register_date='" + datePicker.Value + "',register_time='" + tbTime.Text + "',deregister_date='" + datePicker1.Value + "',deregister_time='" + tbDtime.Text + "' WHERE id =" + int.Parse(lbRD.Text);
            executeMyQuery(updateQuery);
            populateDGV();
        }

        private void resetPictureBox_Click(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
            tbTime.Text = "";
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
            LoginIdLabel.Text = NurseMenu.passingtext;

            populateDGV();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Type dtp2 = dataGridView1.CurrentRow.Cells[2].Value.GetType();
            Type dtp1 = dataGridView1.CurrentRow.Cells[4].Value.GetType();
            if (dtp2 == typeof(DBNull))
            {
                datePicker.Value = DateTime.Now;
            }
            else if (dtp1 == typeof(DBNull))
            {
                datePicker1.Value = DateTime.Now;
            }
            else
            {
                lbRD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                datePicker.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
                tbTime.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                datePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                tbDtime.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }
    }
}

       