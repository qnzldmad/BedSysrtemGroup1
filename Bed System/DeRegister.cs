﻿using System;
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
    public partial class DeRegister : Form
    {
        public DeRegister()
        {
            InitializeComponent();
        }

        private void DeRegister_Load(object sender, EventArgs e)
        {
            medicalIDLabel.Text = MedicalStaffMenu.passingtext1;
            dateTimePicker1.Format = DateTimePickerFormat.Time;
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
            rederegister.Register_date = this.dateTimePicker2.Value;
            rederegister.Register_time = this.dateTimePicker1.Value;

            rederegisterHandler rederegisterHandler = new rederegisterHandler();
            int recordCnt1 = rederegisterHandler.addReDeregister(databaseConnertor.getconn(), rederegister);
            MessageBox.Show(recordCnt1 + " record has been inserted !!");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void resetPB_click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
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
    }
}