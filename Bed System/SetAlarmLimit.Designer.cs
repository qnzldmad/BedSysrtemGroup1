namespace Bed_System
{
    partial class SetAlarmLimit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetAlarmLimit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AlarmPatientIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AlarmPatientNameLabel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbMaxSys = new System.Windows.Forms.TextBox();
            this.tbMinSys = new System.Windows.Forms.TextBox();
            this.tbMaxBreathing = new System.Windows.Forms.TextBox();
            this.tbMinBreathing = new System.Windows.Forms.TextBox();
            this.tbMaxTemperature = new System.Windows.Forms.TextBox();
            this.tbMinTemperature = new System.Windows.Forms.TextBox();
            this.tbMaxPulse = new System.Windows.Forms.TextBox();
            this.tbminPulse = new System.Windows.Forms.TextBox();
            this.tbMaxDias = new System.Windows.Forms.TextBox();
            this.tbMinDias = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alarm Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pulse Rate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blood Pressure (Systolic)  : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperature:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Breathing Rate :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 79);
            this.panel1.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(155, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(276, 316);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(401, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Blood Pressure (Diastolic) :";
            // 
            // AlarmPatientIdTextBox
            // 
            this.AlarmPatientIdTextBox.Location = new System.Drawing.Point(141, 108);
            this.AlarmPatientIdTextBox.Name = "AlarmPatientIdTextBox";
            this.AlarmPatientIdTextBox.Size = new System.Drawing.Size(150, 20);
            this.AlarmPatientIdTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Patient ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Patient Name :";
            // 
            // AlarmPatientNameLabel
            // 
            this.AlarmPatientNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AlarmPatientNameLabel.Location = new System.Drawing.Point(141, 146);
            this.AlarmPatientNameLabel.Name = "AlarmPatientNameLabel";
            this.AlarmPatientNameLabel.Size = new System.Drawing.Size(150, 23);
            this.AlarmPatientNameLabel.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(141, 191);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbMaxSys
            // 
            this.tbMaxSys.Location = new System.Drawing.Point(551, 229);
            this.tbMaxSys.Name = "tbMaxSys";
            this.tbMaxSys.Size = new System.Drawing.Size(58, 20);
            this.tbMaxSys.TabIndex = 24;
            // 
            // tbMinSys
            // 
            this.tbMinSys.Location = new System.Drawing.Point(473, 229);
            this.tbMinSys.Name = "tbMinSys";
            this.tbMinSys.Size = new System.Drawing.Size(60, 20);
            this.tbMinSys.TabIndex = 25;
            // 
            // tbMaxBreathing
            // 
            this.tbMaxBreathing.Location = new System.Drawing.Point(509, 188);
            this.tbMaxBreathing.Name = "tbMaxBreathing";
            this.tbMaxBreathing.Size = new System.Drawing.Size(65, 20);
            this.tbMaxBreathing.TabIndex = 26;
            // 
            // tbMinBreathing
            // 
            this.tbMinBreathing.Location = new System.Drawing.Point(431, 188);
            this.tbMinBreathing.Name = "tbMinBreathing";
            this.tbMinBreathing.Size = new System.Drawing.Size(55, 20);
            this.tbMinBreathing.TabIndex = 27;
            // 
            // tbMaxTemperature
            // 
            this.tbMaxTemperature.Location = new System.Drawing.Point(509, 144);
            this.tbMaxTemperature.Name = "tbMaxTemperature";
            this.tbMaxTemperature.Size = new System.Drawing.Size(65, 20);
            this.tbMaxTemperature.TabIndex = 28;
            // 
            // tbMinTemperature
            // 
            this.tbMinTemperature.Location = new System.Drawing.Point(417, 144);
            this.tbMinTemperature.Name = "tbMinTemperature";
            this.tbMinTemperature.Size = new System.Drawing.Size(59, 20);
            this.tbMinTemperature.TabIndex = 29;
            // 
            // tbMaxPulse
            // 
            this.tbMaxPulse.Location = new System.Drawing.Point(509, 104);
            this.tbMaxPulse.Name = "tbMaxPulse";
            this.tbMaxPulse.Size = new System.Drawing.Size(65, 20);
            this.tbMaxPulse.TabIndex = 30;
            // 
            // tbminPulse
            // 
            this.tbminPulse.Location = new System.Drawing.Point(412, 105);
            this.tbminPulse.Name = "tbminPulse";
            this.tbminPulse.Size = new System.Drawing.Size(64, 20);
            this.tbminPulse.TabIndex = 31;
            // 
            // tbMaxDias
            // 
            this.tbMaxDias.Location = new System.Drawing.Point(551, 270);
            this.tbMaxDias.Name = "tbMaxDias";
            this.tbMaxDias.Size = new System.Drawing.Size(58, 20);
            this.tbMaxDias.TabIndex = 32;
            // 
            // tbMinDias
            // 
            this.tbMinDias.Location = new System.Drawing.Point(473, 270);
            this.tbMinDias.Name = "tbMinDias";
            this.tbMinDias.Size = new System.Drawing.Size(60, 20);
            this.tbMinDias.TabIndex = 33;
            // 
            // SetAlarmLimit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(621, 351);
            this.Controls.Add(this.tbMinDias);
            this.Controls.Add(this.tbMaxDias);
            this.Controls.Add(this.tbminPulse);
            this.Controls.Add(this.tbMaxPulse);
            this.Controls.Add(this.tbMinTemperature);
            this.Controls.Add(this.tbMaxTemperature);
            this.Controls.Add(this.tbMinBreathing);
            this.Controls.Add(this.tbMaxBreathing);
            this.Controls.Add(this.tbMinSys);
            this.Controls.Add(this.tbMaxSys);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.AlarmPatientNameLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AlarmPatientIdTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "SetAlarmLimit";
            this.Text = "Set Alarm Limit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AlarmPatientIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label AlarmPatientNameLabel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbMaxSys;
        private System.Windows.Forms.TextBox tbMinSys;
        private System.Windows.Forms.TextBox tbMaxBreathing;
        private System.Windows.Forms.TextBox tbMinBreathing;
        private System.Windows.Forms.TextBox tbMaxTemperature;
        private System.Windows.Forms.TextBox tbMinTemperature;
        private System.Windows.Forms.TextBox tbMaxPulse;
        private System.Windows.Forms.TextBox tbminPulse;
        private System.Windows.Forms.TextBox tbMaxDias;
        private System.Windows.Forms.TextBox tbMinDias;
    }
}