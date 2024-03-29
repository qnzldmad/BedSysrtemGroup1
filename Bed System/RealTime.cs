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
using System.IO;
using System.Media;
using System.Runtime.InteropServices;

namespace Bed_System
{
    public partial class RealTime : Form
    {
        public RealTime()
        {
            InitializeComponent();
        }

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
           IntPtr wParam, IntPtr lParam);

        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=eahthospital");
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;

        Timer timer;
        Random random;
        double bsrandomnum;
        double bdrandomnum;
        double prandomnum;
        double brandomnum;
        double trandomnum;
        int bstime;
        int bdtime;
        int ptime;
        int btime;
        int ttime;

        private void RealTime_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Show();
            btnExit.Hide();
            btnExit2.Show();
            btnCheck.Hide();

            panel2.Width = 400;
            panel2.Height = 200;
            panel2.Location = new Point(0, 82);
            panel3.Width = 400;
            panel3.Height = 200;
            panel3.Location = new Point(400, 82);
            panel4.Width = 400;
            panel4.Height = 200;
            panel4.Location = new Point(0, 284);
            panel5.Width = 400;
            panel5.Height = 200;
            panel5.Location = new Point(400, 284);
            panel6.Width = 274;
            panel6.Height = 409;
            panel6.Location = new Point(126, 101);
            btnExit.Location = new Point(716, 490);
            btnExit2.Location = new Point(716, 490);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DatabaseConnertor databaseConnertor = new DatabaseConnertor();
            databaseConnertor.connect();

            realtimeclass realtimeclass = new realtimeclass();
            realtimeclass.P_id = int.Parse(pID.Text);
            realtimeclass.P_systolic = int.Parse(lbSys.Text);
            realtimeclass.P_diastolic = int.Parse(lbDia.Text);
            realtimeclass.P_breathing = int.Parse(lbBre.Text);
            realtimeclass.P_pulse = int.Parse(lbPul.Text);
            realtimeclass.P_temperature = int.Parse(lbTem.Text);

            realtimeHandler realtimeHandler = new realtimeHandler();
            int recordCnt1 = realtimeHandler.addRealTime(databaseConnertor.getconn(), realtimeclass);

            bsrandomnum = random.Next(105, 145);
            bdrandomnum = random.Next(65, 100);
            prandomnum = random.Next(65, 75);
            //prandomnum = random.Next(0);
            brandomnum = random.Next(12, 20);
            trandomnum = random.Next(36, 37);
            lbSys.Text = bsrandomnum.ToString();
            lbDia.Text = bdrandomnum.ToString();
            lbPul.Text = prandomnum.ToString();
            lbBre.Text = brandomnum.ToString();
            lbTem.Text = trandomnum.ToString();

            chart1.Series[0].Points.AddXY(bstime++, bsrandomnum);
            chart1.Series[0].Color = Color.LightGreen;
            chart1.Series[1].Points.AddXY(bdtime++, bdrandomnum);
            if (chart1.Series[0].Points.Count > 5)
            {
                chart1.Series[0].Points.Remove(chart1.Series[0].Points[0]);
                chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
                chart1.ChartAreas[0].AxisX.Maximum = bstime;
            }

            chart2.Series[0].Points.AddXY(ptime++, prandomnum);
            chart2.Series[0].Color = Color.LightGreen;

            if (chart2.Series[0].Points.Count > 5)
            {
                chart2.Series[0].Points.Remove(chart2.Series[0].Points[0]);
                chart2.ChartAreas[0].AxisX.Minimum = chart2.Series[0].Points[0].XValue;
                chart2.ChartAreas[0].AxisX.Maximum = ptime;
            }

            chart3.Series[0].Points.AddXY(btime++, brandomnum);
            chart3.Series[0].Color = Color.LightGreen;

            if (chart3.Series[0].Points.Count > 5)
            {
                chart3.Series[0].Points.Remove(chart3.Series[0].Points[0]);
                chart3.ChartAreas[0].AxisX.Minimum = chart3.Series[0].Points[0].XValue;
                chart3.ChartAreas[0].AxisX.Maximum = btime;
            }

            chart4.Series[0].Points.AddXY(ttime++, trandomnum);
            chart4.Series[0].Color = Color.LightGreen;

            if (chart4.Series[0].Points.Count > 5)
            {
                chart4.Series[0].Points.Remove(chart4.Series[0].Points[0]);
                chart4.ChartAreas[0].AxisX.Minimum = chart4.Series[0].Points[0].XValue;
                chart4.ChartAreas[0].AxisX.Maximum = ttime;
            }



            if (lbPul.Text == "0")
            {
                timer.Stop();
                // SoundPlayer player = new System.Media.SoundPlayer();
                SoundPlayer player1 = new SoundPlayer(Properties.Resources.BedsideSoundss);
                player1.Play();
                // player.Stop();

            }

            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.BedsideSounds);
                player.Play();
            }

            passingtext1 = lbSys.Text;
            passingtext2 = lbDia.Text;
            passingtext3 = lbPul.Text;
            passingtext4 = lbBre.Text;
            passingtext5 = lbTem.Text;
            passingtext6 = pID.Text;
        }

        public static string passingtext1;
        public static string passingtext2;
        public static string passingtext3;
        public static string passingtext4;
        public static string passingtext5;
        public static string passingtext6;

        private void btnExit_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new System.Media.SoundPlayer();
            player.Stop();
            timer.Stop();
            this.Close();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clksearch_Click(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            string loadPatient = "SELECT * FROM eahthospital.addpatient WHERE p_firstName ='" + tbSearch.Text + "' OR p_lastName='" + tbSearch.Text + "'";
            mySqlCommand = new MySqlCommand(loadPatient, mySqlConnection);

            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (mySqlDataReader.Read())
            {
                tbPID.Text = mySqlDataReader.GetString("p_id");
                tbPName.Text = mySqlDataReader.GetString("p_firstName") + mySqlDataReader.GetString("p_lastName");
                tbPAge.Text = mySqlDataReader.GetInt32("p_age").ToString();
                tbPContact.Text = mySqlDataReader.GetInt32("p_contact").ToString();
                tbPEContact.Text = mySqlDataReader.GetInt32("p_emergencyContact").ToString();
                tbDOB.Value = mySqlDataReader.GetMySqlDateTime("p_dob").Value;
                tbGender.Text = mySqlDataReader.GetString("p_gender");
                tbAdd.Text = mySqlDataReader.GetString("p_address");
            }
            else
            {
                MessageBox.Show("There is no such Patient Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mySqlConnection.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnCheck.Show();

            if (tbPID.Text == "")
            {
                MessageBox.Show("Search Patient First!");
            }

            else
            {
                pID.Text = tbPID.Text;
                lbSys.Text = "0";
                lbDia.Text = "0";
                lbPul.Text = "0";
                lbBre.Text = "0";
                lbTem.Text = "0";

                random = new Random();
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += timer1_Tick;
                timer.Start();

                panel2.Show();
                panel3.Show();
                panel4.Show();
                panel5.Show();
                panel6.Hide();
                btnExit.Show();
                btnExit2.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPID.Text = "";
            tbPName.Text = "";
            tbPAge.Text = "";
            tbPContact.Text = "";
            tbPEContact.Text = "";
            tbDOB.Value = DateTime.Now;
            tbGender.Text = "";
            tbAdd.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
               (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
               (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }
    }
}
