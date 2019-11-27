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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            DatabaseConnertor database = new DatabaseConnertor();
            database.connect();
            realtimeHandler realtimeHandler = new realtimeHandler();

            dgvHistory.DataSource = realtimeHandler.getAlldetails(database.getconn());

            database.connect();
            addPatientHandler addPatientHandler = new addPatientHandler();

            dgvPatient.DataSource = addPatientHandler.getAllPatient(database.getconn());
        }
    }
}
