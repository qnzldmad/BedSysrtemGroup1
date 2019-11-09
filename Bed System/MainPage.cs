﻿using System;
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
    public partial class MainPage : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");

        public MainPage()
        {
            InitializeComponent();
        }
        private void btnPatientMode_Click(object sender, EventArgs e)
        {
            PatientMode patientMode = new PatientMode();
            patientMode.Show();
        }

        public static string passingtext;

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            Medical_Staff_Login_Page medical_Staff_Login_Page = new Medical_Staff_Login_Page();
            medical_Staff_Login_Page.Show();
        }

        private void btnNurse_Click(object sender, EventArgs e)
        {

        }
    }
}
