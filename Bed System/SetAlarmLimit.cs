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

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Hide();
            NurseMenu menu = new NurseMenu();
            menu.ShowDialog();
            this.Close();

        }

        
    }
}
