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
using System.IO;
using System.Media;
using System.Runtime.InteropServices;



namespace Bed_System
{
    public partial class ActiveBedside : Form
    {
        public ActiveBedside()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;

        Timer timer;
        Timer Timer;
        Random random;

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
           IntPtr wParam, IntPtr lParam);

        private void ActiveBedside_Load(object sender, EventArgs e)
        {
            random = new Random();
            timer = new Timer();
            Timer = new Timer();
            
            timer.Interval = 1000;
            Timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            Timer.Tick += timer2_Tick;
            timer.Start();
            Timer.Start();
            lbDateTime.Text = DateTime.Now.ToString();

            mySqlConnection.Open();

            string loadLimit = "SELECT * FROM eahthospital.patientlimit WHERE p_id=" + int.Parse(pids.Text);
            mySqlCommand = new MySqlCommand(loadLimit, mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (mySqlDataReader.Read())
            {
                sysMin.Text = mySqlDataReader.GetInt32("p_min_blood_sys").ToString();
                sysMax.Text = mySqlDataReader.GetInt32("p_max_sys").ToString();
                diaMin.Text = mySqlDataReader.GetInt32("p_min_blood_dias").ToString();
                diaMax.Text = mySqlDataReader.GetInt32("p_max_dias").ToString();
                pulMin.Text = mySqlDataReader.GetInt32("p_min_pulse_rate").ToString();
                pulMax.Text = mySqlDataReader.GetInt32("p_max_pulse").ToString();
                breMin.Text = mySqlDataReader.GetInt32("p_min_breathing_rate").ToString();
                breMax.Text = mySqlDataReader.GetInt32("p_max_breathing").ToString();
                temMin.Text = mySqlDataReader.GetInt32("p_min_temperature").ToString();
                temMax.Text = mySqlDataReader.GetInt32("p_max_temperature").ToString();
            }

            mySqlConnection.Close();
        }

        double bsrandomnum;
        double bdrandomnum;
        double prandomnum;
        double brandomnum;
        double trandomnum;

        private void timer1_Tick(object sender, EventArgs e)
        {
            bsrandomnum = random.Next(105, 145);
            bdrandomnum = random.Next(65, 100);
            prandomnum = random.Next(65, 75);
            brandomnum = random.Next(12, 20);
            trandomnum = random.Next(36, 37);
            btsys.Text = bsrandomnum.ToString();
            btdia.Text = bdrandomnum.ToString();
            btpul.Text = prandomnum.ToString();
            btbre.Text = brandomnum.ToString();
            bttem.Text = trandomnum.ToString();
            btcolor.BackColor = Color.Green;

            double bsrandomnumtt = random.Next(105, 145);
            double bdrandomnumtt = random.Next(65, 100);
            double prandomnumtt = random.Next(65, 75);
            double brandomnumtt = random.Next(12, 20);
            double trandomnumtt = random.Next(36, 37);
            bttsys.Text = bsrandomnumtt.ToString();
            bttdia.Text = bdrandomnumtt.ToString();
            bttpul.Text = prandomnumtt.ToString();
            bttbre.Text = brandomnumtt.ToString();
            btttem.Text = trandomnumtt.ToString();
            bttcolor.BackColor = Color.Green;

            double bsrandomnumf = random.Next(105, 145);
            double bdrandomnumf = random.Next(65, 100);
            double prandomnumf = random.Next(65, 75);
            double brandomnumf = random.Next(12, 20);
            double trandomnumf = random.Next(36, 37);
            bfsys.Text = bsrandomnumf.ToString();
            bfdia.Text = bdrandomnumf.ToString();
            bfpul.Text = prandomnumf.ToString();
            bfbre.Text = brandomnumf.ToString();
            bftem.Text = trandomnumf.ToString();
            bfcolor.BackColor = Color.Green;

            double bsrandomnumff = random.Next(105, 145);
            double bdrandomnumff = random.Next(65, 100);
            double prandomnumff = random.Next(65, 75);
            double brandomnumff = random.Next(12, 20);
            double trandomnumff = random.Next(36, 37);
            bffsys.Text = bsrandomnumff.ToString();
            bffdia.Text = bdrandomnumff.ToString();
            bffpul.Text = prandomnumff.ToString();
            bffbre.Text = brandomnumff.ToString();
            bfftem.Text = trandomnumff.ToString();
            bffcolor.BackColor = Color.Green;

            double bsrandomnums = random.Next(105, 145);
            double bdrandomnums = random.Next(65, 100);
            double prandomnums = random.Next(65, 75);
            double brandomnums = random.Next(12, 20);
            double trandomnums = random.Next(36, 37);
            bssys.Text = bsrandomnums.ToString();
            bsdia.Text = bdrandomnums.ToString();
            bspul.Text = prandomnums.ToString();
            bsbre.Text = brandomnums.ToString();
            bstem.Text = trandomnums.ToString();
            bscolor.BackColor = Color.Green;

            double bsrandomnumss = random.Next(105, 145);
            double bdrandomnumss = random.Next(65, 100);
            double prandomnumss = random.Next(65, 75);
            double brandomnumss = random.Next(12, 20);
            double trandomnumss = random.Next(36, 37);
            bsssys.Text = bsrandomnumss.ToString();
            bssdia.Text = bdrandomnumss.ToString();
            bsspul.Text = prandomnumss.ToString();
            bssbre.Text = brandomnumss.ToString();
            bsstem.Text = trandomnumss.ToString();
            bsscolor.BackColor = Color.Green;

            double bsrandomnume = random.Next(105, 145);
            double bdrandomnume = random.Next(65, 100);
            double prandomnume = random.Next(65, 75);
            double brandomnume = random.Next(12, 20);
            double trandomnume = random.Next(36, 37);
            besys.Text = bsrandomnume.ToString();
            bedia.Text = bdrandomnume.ToString();
            bepul.Text = prandomnume.ToString();
            bebre.Text = brandomnume.ToString();
            betem.Text = trandomnume.ToString();
            becolor.BackColor = Color.Green;

            lbDateTime.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //This code for Connet with realtime
            /*bsys.Text = RealTime.passingtext1;
            bdia.Text = RealTime.passingtext2;
            bpul.Text = RealTime.passingtext3;
            bbre.Text = RealTime.passingtext4;
            btem.Text = RealTime.passingtext5;
            pid.Text = RealTime.passingtext6;*/

            bsrandomnum = random.Next(85, 145);
            bdrandomnum = random.Next(65, 100);
            prandomnum = random.Next(65, 75);
            brandomnum = random.Next(12, 20);
            trandomnum = random.Next(36, 37);
            bsys.Text = bsrandomnum.ToString();
            bdia.Text = bdrandomnum.ToString();
            bpul.Text = prandomnum.ToString();
            bbre.Text = brandomnum.ToString();
            btem.Text = trandomnum.ToString();

            int bsyst = int.Parse(bsys.Text);
            int bdiat = int.Parse(bdia.Text);
            int bpult = int.Parse(bpul.Text);
            int bbret = int.Parse(bbre.Text);
            int btemt = int.Parse(btem.Text);

            int sysmin = int.Parse(sysMin.Text);
            int sysmax = int.Parse(sysMax.Text);
            int diamin = int.Parse(diaMin.Text);
            int diamax = int.Parse(diaMax.Text);
            int pulmin = int.Parse(pulMin.Text);
            int pulmax = int.Parse(pulMax.Text);
            int bremin = int.Parse(breMin.Text);
            int bremax = int.Parse(breMax.Text);
            int temmin = int.Parse(temMin.Text);
            int temmax = int.Parse(temMax.Text);

            if (bsyst <= sysmin || bsyst >= sysmax)
            {
                bcolor.BackColor = Color.Red;
                SoundPlayer player1 = new System.Media.SoundPlayer(Properties.Resources.Alarm);
                player1.Play();

                DatabaseConnertor databaseConnertor = new DatabaseConnertor();
                databaseConnertor.connect();

                active active = new active();
                active.Bed_number = int.Parse(bedNo.Text);
                active.Emergency_datetime = DateTime.Parse(lbDateTime.Text);
                active.Systolic = int.Parse(bsys.Text);

                activeHandler activeHandler = new activeHandler();
                int recordCnt1 = activeHandler.addActive(databaseConnertor.getconn(), active);
            }
            else if (bdiat <= diamin || bdiat >= diamax)
            {
                bcolor.BackColor = Color.Red;
                SoundPlayer player1 = new System.Media.SoundPlayer(Properties.Resources.Alarm);
                player1.Play();

                DatabaseConnertor databaseConnertor = new DatabaseConnertor();
                databaseConnertor.connect();

                active active = new active();
                active.Bed_number = int.Parse(bedNo.Text);
                active.Emergency_datetime = DateTime.Parse(lbDateTime.Text);
                active.Diastolic = int.Parse(bdia.Text);

                activeHandler activeHandler = new activeHandler();
                int recordCnt1 = activeHandler.addActive(databaseConnertor.getconn(), active);
            }
            else if (bpult <= pulmin || bpult >= pulmax)
            {
                bcolor.BackColor = Color.Red;
                SoundPlayer player1 = new System.Media.SoundPlayer(Properties.Resources.Alarm);
                player1.Play();

                DatabaseConnertor databaseConnertor = new DatabaseConnertor();
                databaseConnertor.connect();

                active active = new active();
                active.Bed_number = int.Parse(bedNo.Text);
                active.Emergency_datetime = DateTime.Parse(lbDateTime.Text);
                active.Pulse = int.Parse(bpul.Text);

                activeHandler activeHandler = new activeHandler();
                int recordCnt1 = activeHandler.addActive(databaseConnertor.getconn(), active);
            }
            else if (bbret <= bremin || bbret >= bremax)
            {
                bcolor.BackColor = Color.Red;
                SoundPlayer player1 = new System.Media.SoundPlayer(Properties.Resources.Alarm);
                player1.Play();

                DatabaseConnertor databaseConnertor = new DatabaseConnertor();
                databaseConnertor.connect();

                active active = new active();
                active.Bed_number = int.Parse(bedNo.Text);
                active.Emergency_datetime = DateTime.Parse(lbDateTime.Text);
                active.Breathing = int.Parse(bbre.Text);

                activeHandler activeHandler = new activeHandler();
                int recordCnt1 = activeHandler.addActive(databaseConnertor.getconn(), active);
            }
            else if (btemt <= temmin || btemt >= temmax)
            {
                bcolor.BackColor = Color.Red;
                SoundPlayer player1 = new System.Media.SoundPlayer(Properties.Resources.Alarm);
                player1.Play();

                DatabaseConnertor databaseConnertor = new DatabaseConnertor();
                databaseConnertor.connect();

                active active = new active();
                active.Bed_number = int.Parse(bedNo.Text);
                active.Emergency_datetime = DateTime.Parse(lbDateTime.Text);
                active.Temperature = int.Parse(btem.Text);

                activeHandler activeHandler = new activeHandler();
                int recordCnt1 = activeHandler.addActive(databaseConnertor.getconn(), active);
            }
            else
            {
                bcolor.BackColor = Color.Green;
            }
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (tbStaffName.Text == "")
            {
                MessageBox.Show("Insert Staff Name");
            }
            else
            {
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                 (IntPtr)APPCOMMAND_VOLUME_MUTE);

                DatabaseConnertor databaseConnertor = new DatabaseConnertor();
                databaseConnertor.connect();

                active active = new active();
                active.Ms_name = tbStaffName.Text;
                active.Bed_number = int.Parse(bedNo.Text);
                active.Staff_checkdatetime = DateTime.Parse(lbDateTime.Text);

                activeHandler activeHandler = new activeHandler();
                int recordCnt1 = activeHandler.addActive(databaseConnertor.getconn(), active);

                Timer.Stop();
                MessageBox.Show("Checked Patient");
            }
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            this.Close();
            ActiveBedside activeBedside = new ActiveBedside();
            activeBedside.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            string loadPatient = "SELECT * FROM bed_status WHERE bed_status.id=" + int.Parse(bedNumberTextBox.Text);
            mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (mySqlDataReader.Read())
            {
                bedNumberTextBox.Text = mySqlDataReader.GetString("id");
                lblBed.Text = mySqlDataReader.GetString("status");
                lbPatient.Text = mySqlDataReader.GetString("patient_id");
            }
            else
            {
                MessageBox.Show("There is no such Bed Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mySqlConnection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Timer.Stop();
            timer.Stop();
        }
    }
}

        
     
    



