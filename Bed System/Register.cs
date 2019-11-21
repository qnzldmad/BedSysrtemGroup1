using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bed_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
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
            register.Register_date = this.datePicker.Value;
            register.Register_time = this.timePicker.Value;

            registerHandler rederegisterHandler = new registerHandler();
            int recordCnt1 = rederegisterHandler.addRegister(databaseConnertor.getconn(), register);
            MessageBox.Show(recordCnt1 + " record has been inserted !!");
        }

        private void deregisterPictureBox_Click(object sender, EventArgs e)
        {
            LoginIdLabel.Text = MedicalStaffMenu.passingtext1;
            datePicker.Format = DateTimePickerFormat.Time;
        }

        private void resetPictureBox_Click(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
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
    }
}

       