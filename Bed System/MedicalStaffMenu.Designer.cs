namespace Bed_System
{
    partial class MedicalStaffMenu
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
            this.selectModulePB = new System.Windows.Forms.PictureBox();
            this.setPatientPB = new System.Windows.Forms.PictureBox();
            this.deRegisterPB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.medicalIDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.medicalStaffID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectModulePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setPatientPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegisterPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 80);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medical Staff Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::Bed_System.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // selectModulePB
            // 
            this.selectModulePB.Image = global::Bed_System.Properties.Resources.select_module;
            this.selectModulePB.Location = new System.Drawing.Point(415, 132);
            this.selectModulePB.Name = "selectModulePB";
            this.selectModulePB.Size = new System.Drawing.Size(101, 82);
            this.selectModulePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectModulePB.TabIndex = 13;
            this.selectModulePB.TabStop = false;
            this.selectModulePB.Click += new System.EventHandler(this.selectModulePB_click);
            this.selectModulePB.MouseLeave += new System.EventHandler(this.selectModulePB_MouseLeave);
            this.selectModulePB.MouseHover += new System.EventHandler(this.selectModulePB_MouseHover);
            // 
            // setPatientPB
            // 
            this.setPatientPB.Image = global::Bed_System.Properties.Resources.Check;
            this.setPatientPB.Location = new System.Drawing.Point(233, 132);
            this.setPatientPB.Name = "setPatientPB";
            this.setPatientPB.Size = new System.Drawing.Size(101, 82);
            this.setPatientPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setPatientPB.TabIndex = 12;
            this.setPatientPB.TabStop = false;
            this.setPatientPB.Click += new System.EventHandler(this.setPatientPB_click);
            this.setPatientPB.MouseLeave += new System.EventHandler(this.setPatientPB_MouseLeave);
            this.setPatientPB.MouseHover += new System.EventHandler(this.setPatientPB_MouseHover);
            // 
            // deRegisterPB
            // 
            this.deRegisterPB.Image = global::Bed_System.Properties.Resources.ReDeregister;
            this.deRegisterPB.Location = new System.Drawing.Point(41, 132);
            this.deRegisterPB.Name = "deRegisterPB";
            this.deRegisterPB.Size = new System.Drawing.Size(101, 82);
            this.deRegisterPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deRegisterPB.TabIndex = 11;
            this.deRegisterPB.TabStop = false;
            this.deRegisterPB.Click += new System.EventHandler(this.deRegisterPB_click);
            this.deRegisterPB.MouseLeave += new System.EventHandler(this.deRegisterPB_MouseLeave);
            this.deRegisterPB.MouseHover += new System.EventHandler(this.deRegisterPB_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // medicalIDLabel
            // 
            this.medicalIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medicalIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalIDLabel.Location = new System.Drawing.Point(452, 89);
            this.medicalIDLabel.Name = "medicalIDLabel";
            this.medicalIDLabel.Size = new System.Drawing.Size(85, 23);
            this.medicalIDLabel.TabIndex = 47;
            this.medicalIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Login ID:";
            // 
            // medicalStaffID
            // 
            this.medicalStaffID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medicalStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalStaffID.Location = new System.Drawing.Point(139, 86);
            this.medicalStaffID.Name = "medicalStaffID";
            this.medicalStaffID.Size = new System.Drawing.Size(85, 23);
            this.medicalStaffID.TabIndex = 49;
            this.medicalStaffID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Medical Staff ID:";
            // 
            // MedicalStaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 280);
            this.Controls.Add(this.medicalStaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.medicalIDLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectModulePB);
            this.Controls.Add(this.setPatientPB);
            this.Controls.Add(this.deRegisterPB);
            this.Controls.Add(this.panel1);
            this.Name = "MedicalStaffMenu";
            this.Text = "MedicalStaffMenu";
            this.Load += new System.EventHandler(this.MedicalStaffMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectModulePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setPatientPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegisterPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox deRegisterPB;
        private System.Windows.Forms.PictureBox setPatientPB;
        private System.Windows.Forms.PictureBox selectModulePB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label medicalIDLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label medicalStaffID;
        private System.Windows.Forms.Label label4;
    }
}