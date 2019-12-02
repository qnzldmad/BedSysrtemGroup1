namespace Bed_System
{
    partial class DeRegister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.medicalIDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.resetPB = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbDeregister = new System.Windows.Forms.PictureBox();
            this.pbRegister = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMedicalID = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeregister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 79);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(126, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 54);
            this.label1.TabIndex = 30;
            this.label1.Text = "Register/Deregister";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::Bed_System.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // medicalIDLabel
            // 
            this.medicalIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medicalIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalIDLabel.Location = new System.Drawing.Point(306, 91);
            this.medicalIDLabel.Name = "medicalIDLabel";
            this.medicalIDLabel.Size = new System.Drawing.Size(85, 23);
            this.medicalIDLabel.TabIndex = 45;
            this.medicalIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Login ID:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(187, 154);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(203, 26);
            this.dateTimePicker2.TabIndex = 49;
            // 
            // resetPB
            // 
            this.resetPB.Image = global::Bed_System.Properties.Resources.Reset1;
            this.resetPB.Location = new System.Drawing.Point(177, 186);
            this.resetPB.Name = "resetPB";
            this.resetPB.Size = new System.Drawing.Size(50, 46);
            this.resetPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resetPB.TabIndex = 50;
            this.resetPB.TabStop = false;
            this.resetPB.Click += new System.EventHandler(this.resetPB_click);
            this.resetPB.MouseLeave += new System.EventHandler(this.resetPB_MouseLeave);
            this.resetPB.MouseHover += new System.EventHandler(this.resetPB_MouseHover);
            // 
            // pbExit
            // 
            this.pbExit.Image = global::Bed_System.Properties.Resources.exit;
            this.pbExit.Location = new System.Drawing.Point(337, 258);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(53, 50);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 43;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_click);
            // 
            // pbDeregister
            // 
            this.pbDeregister.Image = global::Bed_System.Properties.Resources.DeRegister;
            this.pbDeregister.Location = new System.Drawing.Point(159, 258);
            this.pbDeregister.Name = "pbDeregister";
            this.pbDeregister.Size = new System.Drawing.Size(132, 50);
            this.pbDeregister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeregister.TabIndex = 42;
            this.pbDeregister.TabStop = false;
            this.pbDeregister.Click += new System.EventHandler(this.pbDeregister_Click);
            // 
            // pbRegister
            // 
            this.pbRegister.Image = global::Bed_System.Properties.Resources.Register;
            this.pbRegister.Location = new System.Drawing.Point(21, 258);
            this.pbRegister.Name = "pbRegister";
            this.pbRegister.Size = new System.Drawing.Size(132, 50);
            this.pbRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegister.TabIndex = 41;
            this.pbRegister.TabStop = false;
            this.pbRegister.Click += new System.EventHandler(this.pbRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Medical Staff ID:";
            // 
            // lbMedicalID
            // 
            this.lbMedicalID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMedicalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedicalID.Location = new System.Drawing.Point(135, 91);
            this.lbMedicalID.Name = "lbMedicalID";
            this.lbMedicalID.Size = new System.Drawing.Size(85, 23);
            this.lbMedicalID.TabIndex = 53;
            this.lbMedicalID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(243, 202);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(138, 20);
            this.tbTime.TabIndex = 55;
            // 
            // DeRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(403, 320);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMedicalID);
            this.Controls.Add(this.resetPB);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medicalIDLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbDeregister);
            this.Controls.Add(this.pbRegister);
            this.Name = "DeRegister";
            this.Text = "Register / Dregister";
            this.Load += new System.EventHandler(this.DeRegister_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeregister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbDeregister;
        private System.Windows.Forms.PictureBox pbRegister;
        private System.Windows.Forms.Label medicalIDLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.PictureBox resetPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMedicalID;
        private System.Windows.Forms.TextBox tbTime;
    }
}