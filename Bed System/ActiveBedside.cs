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
        Random random;
        double badnum;

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
           IntPtr wParam, IntPtr lParam);

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseMenu mute = new NurseMenu();
            mute.ShowDialog();
            this.Close();
        }

        private void ActiveBedside_Load(object sender, EventArgs e)
        {
            random = new Random();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
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
            }
            else
            {
                MessageBox.Show("There is no such Bed Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mySqlConnection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int abs;
            int ab;
            {
                badnum = random.Next(135, 145);
                label11.Text = badnum.ToString();

                abs = int.Parse(label9.Text);
                ab = int.Parse(label11.Text);
                if (ab >= abs)
                {
                    label4.BackColor = Color.Red;
                    timer.Stop();
                    SoundPlayer player1 = new System.Media.SoundPlayer();
                    player1.SoundLocation = @"C:\Users\USER\Desktop\Alarm.wav";
                    player1.Play();
                    MessageBox.Show("Patient Bed 1 limit exceeded");
                    
                }
                else
                {
                    label4.BackColor = Color.Green;
                }
            }
            {
                badnum = random.Next(126, 132);
                label15.Text = badnum.ToString();

                abs = int.Parse(label9.Text);
                ab = int.Parse(label15.Text);
                if (ab >= abs)
                {
                    label7.BackColor = Color.Red;
                    timer.Stop();
                    SoundPlayer player1 = new System.Media.SoundPlayer();
                    player1.SoundLocation = @"C:\Users\USER\Desktop\Alarm.wav";
                    player1.Play();
                    MessageBox.Show("Patient Bed 2 limit exceeded");
                   
                }
                else
                {
                    label7.BackColor = Color.Green;
                }

            }
            {
                badnum = random.Next(88, 89);
                label5.Text = badnum.ToString();

                abs = int.Parse(label21.Text);
                ab = int.Parse(label5.Text);
                if (ab >= abs)
                {
                    label4.BackColor = Color.Red;
                    timer.Stop();
                    SoundPlayer player1 = new System.Media.SoundPlayer();
                    player1.SoundLocation = @"C:\Users\USER\Desktop\Alarm.wav";
                    player1.Play();
                    MessageBox.Show("Patient Bed 1 limit exceeded");
                   
                }
                else
                {
                    label4.BackColor = Color.Green;
                }
            }
            {
                badnum = random.Next(88, 89);
                label6.Text = badnum.ToString();

                abs = int.Parse(label21.Text);
                ab = int.Parse(label6.Text);
                if (ab >= abs)
                {
                    label7.BackColor = Color.Red;
                    timer.Stop();
                    SoundPlayer player1 = new System.Media.SoundPlayer();
                    player1.SoundLocation = @"C:\Users\USER\Desktop\Alarm.wav";
                    player1.Play();
                    MessageBox.Show("Patient Bed 2 limit exceeded");
                   
                }
                else
                {
                    label7.BackColor = Color.Green;
                }
            }

            {
                badnum = random.Next(35, 36);
                label13.Text = badnum.ToString();

                abs = int.Parse(label20.Text);
                ab = int.Parse(label13.Text);
                if (ab >= abs)
                {
                    label4.BackColor = Color.Red;
                    timer.Stop();
                    SoundPlayer player1 = new System.Media.SoundPlayer();
                    player1.SoundLocation = @"C:\Users\USER\Desktop\Alarm.wav";
                    player1.Play();
                    MessageBox.Show("Patient Bed 1 limit exceeded");
                    
                }
                else
                {
                    label4.BackColor = Color.Green;
                }
            }

            {
                badnum = random.Next(35, 36);
                label14.Text = badnum.ToString();

                abs = int.Parse(label20.Text);
                ab = int.Parse(label14.Text);
                if (ab >= abs)
                {
                    label7.BackColor = Color.Red;
                    timer.Stop();
                    SoundPlayer player1 = new System.Media.SoundPlayer();
                    player1.SoundLocation = @"C:\Users\USER\Desktop\Alarm.wav";
                    player1.Play();
                    MessageBox.Show("Patient Bed 2 limit exceeded");
                    
                }
                else
                {
                    label7.BackColor = Color.Green;
                }
            }

            {
                badnum = random.Next(60, 65);
                label31.Text = badnum.ToString();

                abs = int.Parse(label8.Text);
                ab = int.Parse(label31.Text);
                if (ab >= abs)
                {
                    label4.BackColor = Color.Red;
                    timer.Stop();
                    SoundPlayer player1 = new System.Media.SoundPlayer();
                    player1.SoundLocation = @"C:\Users\USER\Desktop\Alarm.wav";
                    player1.Play();
                    MessageBox.Show("Patient Bed 1 limit exceeded");
                    

                }
                else
                {
                    label4.BackColor = Color.Green;
                }
            }

            {
                badnum = random.Next(40, 45);
                label32.Text = badnum.ToString();

                abs = int.Parse(label8.Text);
                ab = int.Parse(label32.Text);
                if (ab >= abs)
                {
                    label7.BackColor = Color.Red;
                    timer.Stop();
                    SoundPlayer player1 = new System.Media.SoundPlayer();
                    player1.SoundLocation = @"C:\Users\USER\Desktop\Alarm.wav";
                    player1.Play();
                    MessageBox.Show("Patient Bed 2 limit exceeded");
                 
                }
                else
                {
                    label7.BackColor = Color.Green;
                }
            }

            {
                badnum = random.Next(75, 78);
                label17.Text = badnum.ToString();

                abs = int.Parse(label22.Text);
                ab = int.Parse(label17.Text);
                if (ab >= abs)
                {
                    label4.BackColor = Color.Red;
                    timer.Stop();
                    SoundPlayer player1 = new System.Media.SoundPlayer();
                    player1.SoundLocation = @"C:\Users\USER\Desktop\Alarm.wav";
                    player1.Play();
                    MessageBox.Show("Patient Bed 1 limit exceeded");
                    
                }
                else
                {
                    label4.BackColor = Color.Green;
                }
            }

            {
                badnum = random.Next(75, 78);
                label16.Text = badnum.ToString();

                abs = int.Parse(label22.Text);
                ab = int.Parse(label16.Text);
                if (ab >= abs)
                {
                    label7.BackColor = Color.Red;
                    timer.Stop();
                    SoundPlayer player1 = new System.Media.SoundPlayer();
                    player1.SoundLocation = @"C:\Users\USER\Desktop\Alarm.wav";
                    player1.Play();
                    MessageBox.Show("Patient Bed 1 limit exceeded");
                   
                }
                else
                {
                    label7.BackColor = Color.Green;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
              (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }
    }
    }

        
     
    



