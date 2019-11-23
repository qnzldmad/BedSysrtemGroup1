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
    public partial class MainPage : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnBed_Click(object sender, EventArgs e)
        {
            RealTime realTime = new RealTime();
            realTime.Show();
        }

        private void btnCentral_Click(object sender, EventArgs e)
        {
            Central mainPages = new Central();
            mainPages.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
