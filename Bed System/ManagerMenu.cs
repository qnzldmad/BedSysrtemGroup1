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
    public partial class ManagerMenu : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;

        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void ManagerMenu_Load(object sender, EventArgs e)
        {
            addPanel.Hide();
            checkPanel.Hide();
            searchPanel.Hide();
            addInfor.Hide();
            searchInfor.Hide();

            addPanel.Width = 458;
            addPanel.Height = 274;
            addPanel.Location = new Point(21, 158);
            checkPanel.Width = 458;
            checkPanel.Height = 274;
            checkPanel.Location = new Point(21, 158);
            searchPanel.Width = 458;
            searchPanel.Height = 274;
            searchPanel.Location = new Point(21, 158);
            addInfor.Width = 450;
            addInfor.Height = 234;
            addInfor.Location = new Point(24, 195);
            searchInfor.Width = 450;
            searchInfor.Height = 234;
            searchInfor.Location = new Point(24, 195);
        }

        private void addStaff_Click(object sender, EventArgs e)
        {
            addPanel.Show();
            checkPanel.Hide();
            searchPanel.Hide();
            addInfor.Hide();
            searchInfor.Hide();

            addStaff.BorderStyle = BorderStyle.Fixed3D;
            checkStaff.BorderStyle = BorderStyle.None;
            database.BorderStyle = BorderStyle.None;
            exit.BorderStyle = BorderStyle.None;
        }

        private void addStaff_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.addStaff, "Add Staff");
            addStaff.BackColor = Color.Gray;
        }

        private void addStaff_MouseLeave(object sender, EventArgs e)
        {
            addStaff.BackColor = Color.LightGray;
        }

        private void checkStaff_Click(object sender, EventArgs e)
        {
            addPanel.Hide();
            checkPanel.Hide();
            searchPanel.Show();
            addInfor.Hide();
            searchInfor.Hide();

            addStaff.BorderStyle = BorderStyle.None;
            checkStaff.BorderStyle = BorderStyle.Fixed3D;
            database.BorderStyle = BorderStyle.None;
            exit.BorderStyle = BorderStyle.None;
        }

        private void checkStaff_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.checkStaff, "Check Staff");
            checkStaff.BackColor = Color.Gray;
        }

        private void checkStaff_MouseLeave(object sender, EventArgs e)
        {
            checkStaff.BackColor = Color.LightGray;
        }

        private void database_Click(object sender, EventArgs e)
        {
            addPanel.Hide();
            checkPanel.Show();
            searchPanel.Hide();
            addInfor.Hide();
            searchInfor.Hide();

            addStaff.BorderStyle = BorderStyle.None;
            checkStaff.BorderStyle = BorderStyle.None;
            database.BorderStyle = BorderStyle.Fixed3D;
            exit.BorderStyle = BorderStyle.None;
        }

        private void database_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.database, "Database");
            database.BackColor = Color.Gray;
        }

        private void database_MouseLeave(object sender, EventArgs e)
        {
            database.BackColor = Color.LightGray;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMedicalStaff_Click(object sender, EventArgs e)
        {
            addPanel.Show();
            checkPanel.Hide();
            searchPanel.Hide();
            addInfor.Show();
            searchInfor.Hide();
            btnSaveN.Hide();
            lbPN.Hide();
            btnSave.Show();
            cbPositon.Show();
        }

        private void btnAddNurse_Click(object sender, EventArgs e)
        {
            addPanel.Show();
            checkPanel.Hide();
            searchPanel.Hide();
            addInfor.Show();
            searchInfor.Hide();
            btnSave.Hide();
            cbPositon.Hide();
            btnSaveN.Show();
            lbPN.Show();
        }

        private void addInfor_Paint(object sender, PaintEventArgs e)
        {
            btnSave.Location = new Point(370, 208);
            btnSaveN.Location = new Point(370, 208);
            lbPN.Location = new Point(130, 187);
            cbPositon.Location = new Point(130, 187);
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dtpDOB.Value;
            DateTime to = DateTime.Now;
            TimeSpan timeSpan = to - from;
            double days = timeSpan.TotalDays;
            lbAge.Text = (days / 365).ToString("0");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpDOB.Value;
            const string after = "yyyyMMdd";
            string password = dateTime.ToString(after);

            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            databaseConnertor.connect();

            addMedicalstaffs addMedicalstaffs = new addMedicalstaffs();
            addMedicalstaffs.Ms_position = cbPositon.Text;
            addMedicalstaffs.Ms_firstName = tbFN.Text;
            addMedicalstaffs.Ms_lastName = tbLN.Text;
            addMedicalstaffs.Ms_dob = this.dtpDOB.Value;
            addMedicalstaffs.Ms_age = int.Parse(lbAge.Text);
            addMedicalstaffs.Ms_email = tbEmail.Text;
            addMedicalstaffs.Ms_contact = int.Parse(tbContact.Text);
            addMedicalstaffs.Ms_loginid = tbFN.Text + tbLN.Text;
            addMedicalstaffs.Ms_password = password;

            addMedicalstaffshandler addMedicalstaffsHandler = new addMedicalstaffshandler();
            int recordCnt = addMedicalstaffsHandler.addNewMedicalStaff(databaseConnertor.getconn(), addMedicalstaffs);
            MessageBox.Show(recordCnt + " record has been inserted !!");
        }

        private void btnSaveN_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpDOB.Value;
            const string after = "yyyyMMdd";
            string password = dateTime.ToString(after);

            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            databaseConnertor.connect();

            addNurses addNurses = new addNurses();
            addNurses.S_position = lbPN.Text;
            addNurses.S_firstName = tbFN.Text;
            addNurses.S_lastName = tbLN.Text;
            addNurses.S_dob = this.dtpDOB.Value;
            addNurses.S_age = int.Parse(lbAge.Text);
            addNurses.S_email = tbEmail.Text;
            addNurses.S_contact = int.Parse(tbContact.Text);
            addNurses.S_loginid = tbFN.Text + tbLN.Text;
            addNurses.S_password = password;

            addNursesHandler addNursesHandler = new addNursesHandler();
            int recordCnt = addNursesHandler.addNewNurse(databaseConnertor.getconn(), addNurses);
            MessageBox.Show(recordCnt + " record has been inserted !!");
        }

        private void btnSearchMedical_Click(object sender, EventArgs e)
        {
            addPanel.Hide();
            checkPanel.Hide();
            searchPanel.Show();
            addInfor.Hide();
            searchInfor.Show();
            searchStaff.Show();
            searchNurse.Hide();
        }

        private void btnSearchNurse_Click(object sender, EventArgs e)
        {
            addPanel.Hide();
            checkPanel.Hide();
            searchPanel.Show();
            addInfor.Hide();
            searchInfor.Show();
            searchStaff.Hide();
            searchNurse.Show();
        }

        private void searchInfor_Paint(object sender, PaintEventArgs e)
        {
            searchStaff.Location = new Point(258, 37);
            searchNurse.Location = new Point(258, 37);
        }

        private void searchStaff_Click(object sender, EventArgs e)
        {
            if (rbID.Checked)
            {
                mySqlConnection.Open();
                string loadStaff = "SELECT * FROM eahthospital.medicalstaff WHERE ms_id=" + int.Parse(tbSearch.Text);
                mySqlCommand = new MySqlCommand(loadStaff, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    lbID.Text = mySqlDataReader.GetString("ms_id");
                    lbN.Text = mySqlDataReader.GetString("ms_firstName") + mySqlDataReader.GetString("ms_lastName");
                    lbA.Text = mySqlDataReader.GetInt32("ms_age").ToString();
                    lbC.Text = mySqlDataReader.GetInt32("ms_contact").ToString();
                    lbE.Text = mySqlDataReader.GetString("ms_email");
                    dtpS.Value = mySqlDataReader.GetMySqlDateTime("ms_dob").Value;
                    lbPosition.Text = mySqlDataReader.GetString("ms_position");
                }
                else
                {
                    MessageBox.Show("There is no such Staff ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();

            }
            else if (rbName.Checked)
            {
                mySqlConnection.Open();
                string loadNurse = "SELECT * FROM eahthospital.medicalstaff WHERE ms_firstName ='" + tbSearch.Text + "' OR ms_lastName='" + tbSearch.Text + "'";
                mySqlCommand = new MySqlCommand(loadNurse, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    lbID.Text = mySqlDataReader.GetString("ms_id");
                    lbN.Text = mySqlDataReader.GetString("ms_firstName") + mySqlDataReader.GetString("ms_lastName");
                    lbA.Text = mySqlDataReader.GetInt32("ms_age").ToString();
                    lbC.Text = mySqlDataReader.GetInt32("ms_contact").ToString();
                    lbE.Text = mySqlDataReader.GetString("ms_email");
                    dtpS.Value = mySqlDataReader.GetMySqlDateTime("ms_dob").Value;
                    lbPosition.Text = mySqlDataReader.GetString("ms_position");
                }
                else
                {
                    MessageBox.Show("There is no such Staff Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();
            }
            else if (!rbID.Checked || !rbName.Checked)
            {
                MessageBox.Show("Please Select an Option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchNurse_Click(object sender, EventArgs e)
        {
            if (rbID.Checked)
            {
                mySqlConnection.Open();
                string loadPatient = "SELECT * FROM eahthospital.nurse WHERE s_id=" + int.Parse(tbSearch.Text);
                mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    lbID.Text = mySqlDataReader.GetString("s_id");
                    lbN.Text = mySqlDataReader.GetString("s_firstName") + mySqlDataReader.GetString("s_lastName");
                    lbA.Text = mySqlDataReader.GetInt32("s_age").ToString();
                    lbC.Text = mySqlDataReader.GetInt32("s_contact").ToString();
                    lbE.Text = mySqlDataReader.GetString("s_email");
                    dtpS.Value = mySqlDataReader.GetMySqlDateTime("s_dob").Value;
                    lbPosition.Text = mySqlDataReader.GetString("s_position");
                }
                else
                {
                    MessageBox.Show("There is no such Nurse ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();

            }
            else if (rbName.Checked)
            {
                mySqlConnection.Open();
                string loadPatient = "SELECT * FROM eahthospital.nurse WHERE s_firstName ='" + tbSearch.Text + "' OR s_lastName='" + tbSearch.Text + "'";
                mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                {
                    lbID.Text = mySqlDataReader.GetString("s_id");
                    lbN.Text = mySqlDataReader.GetString("s_firstName") + mySqlDataReader.GetString("s_lastName");
                    lbA.Text = mySqlDataReader.GetInt32("s_age").ToString();
                    lbC.Text = mySqlDataReader.GetInt32("s_contact").ToString();
                    lbE.Text = mySqlDataReader.GetString("s_email");
                    dtpS.Value = mySqlDataReader.GetMySqlDateTime("s_dob").Value;
                    lbPosition.Text = mySqlDataReader.GetString("s_position");
                }
                else
                {
                    MessageBox.Show("There is no such nurse Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();
            }
            else if (!rbID.Checked || !rbName.Checked)
            {
                MessageBox.Show("Please Select an Option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbID.Text = "";
            lbN.Text = "";
            lbA.Text = "";
            lbC.Text = "";
            lbE.Text = "";
            dtpS.Value = DateTime.Now;
            lbPosition.Text = "";
        }
    }
}
