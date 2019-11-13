namespace Bed_System
{
    partial class NurseMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMuteAlarm = new System.Windows.Forms.Button();
            this.btnAlarmLimit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPatientMonitored = new System.Windows.Forms.Button();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(331, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nurse Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(662, 24);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(91, 29);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMuteAlarm
            // 
            this.btnMuteAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMuteAlarm.Location = new System.Drawing.Point(537, 14);
            this.btnMuteAlarm.Name = "btnMuteAlarm";
            this.btnMuteAlarm.Size = new System.Drawing.Size(136, 133);
            this.btnMuteAlarm.TabIndex = 5;
            this.btnMuteAlarm.Text = "Mute Alarm";
            this.btnMuteAlarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMuteAlarm.UseVisualStyleBackColor = false;
            this.btnMuteAlarm.Click += new System.EventHandler(this.btnMuteAlarm_Click);
            // 
            // btnAlarmLimit
            // 
            this.btnAlarmLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAlarmLimit.Location = new System.Drawing.Point(365, 15);
            this.btnAlarmLimit.Name = "btnAlarmLimit";
            this.btnAlarmLimit.Size = new System.Drawing.Size(139, 132);
            this.btnAlarmLimit.TabIndex = 4;
            this.btnAlarmLimit.Text = "Set Alarm Limit";
            this.btnAlarmLimit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlarmLimit.UseVisualStyleBackColor = false;
            this.btnAlarmLimit.Click += new System.EventHandler(this.btnAlarmLimit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(198, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 132);
            this.button2.TabIndex = 3;
            this.button2.Text = "Active Bedside System";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegister.Location = new System.Drawing.Point(35, 175);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(138, 132);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddPatient.Location = new System.Drawing.Point(198, 15);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(141, 132);
            this.btnAddPatient.TabIndex = 6;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddPatient.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPatientMonitored);
            this.panel1.Controls.Add(this.btnEmergency);
            this.panel1.Controls.Add(this.btnSearchPatient);
            this.panel1.Controls.Add(this.btnAddPatient);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnAlarmLimit);
            this.panel1.Controls.Add(this.btnMuteAlarm);
            this.panel1.Location = new System.Drawing.Point(47, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 328);
            this.panel1.TabIndex = 0;
            // 
            // btnPatientMonitored
            // 
            this.btnPatientMonitored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPatientMonitored.Location = new System.Drawing.Point(365, 175);
            this.btnPatientMonitored.Name = "btnPatientMonitored";
            this.btnPatientMonitored.Size = new System.Drawing.Size(139, 132);
            this.btnPatientMonitored.TabIndex = 11;
            this.btnPatientMonitored.Text = "Patient Monitored";
            this.btnPatientMonitored.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatientMonitored.UseVisualStyleBackColor = false;
            // 
            // btnEmergency
            // 
            this.btnEmergency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEmergency.Location = new System.Drawing.Point(537, 175);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(139, 132);
            this.btnEmergency.TabIndex = 9;
            this.btnEmergency.Text = "Emergency Monitoring";
            this.btnEmergency.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmergency.UseVisualStyleBackColor = false;
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearchPatient.Location = new System.Drawing.Point(35, 15);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(138, 132);
            this.btnSearchPatient.TabIndex = 10;
            this.btnSearchPatient.Text = "Search Patient";
            this.btnSearchPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchPatient.UseVisualStyleBackColor = false;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // NurseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "NurseMenu";
            this.Text = "NurseMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMuteAlarm;
        private System.Windows.Forms.Button btnAlarmLimit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmergency;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.Button btnPatientMonitored;
    }
}