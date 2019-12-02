namespace Bed_System
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginIdLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.resetPictureBox = new System.Windows.Forms.PictureBox();
            this.registerPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.deregisterPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deregisterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register / Deregister";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nurse ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // LoginIdLabel
            // 
            this.LoginIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LoginIdLabel.Location = new System.Drawing.Point(357, 89);
            this.LoginIdLabel.Name = "LoginIdLabel";
            this.LoginIdLabel.Size = new System.Drawing.Size(93, 24);
            this.LoginIdLabel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 68);
            this.panel1.TabIndex = 6;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(55, 134);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 7;
            // 
            // resetPictureBox
            // 
            this.resetPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("resetPictureBox.Image")));
            this.resetPictureBox.Location = new System.Drawing.Point(271, 151);
            this.resetPictureBox.Name = "resetPictureBox";
            this.resetPictureBox.Size = new System.Drawing.Size(37, 32);
            this.resetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resetPictureBox.TabIndex = 9;
            this.resetPictureBox.TabStop = false;
            this.resetPictureBox.Click += new System.EventHandler(this.resetPictureBox_Click);
            // 
            // registerPictureBox
            // 
            this.registerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("registerPictureBox.Image")));
            this.registerPictureBox.Location = new System.Drawing.Point(171, 243);
            this.registerPictureBox.Name = "registerPictureBox";
            this.registerPictureBox.Size = new System.Drawing.Size(116, 58);
            this.registerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.registerPictureBox.TabIndex = 10;
            this.registerPictureBox.TabStop = false;
            this.registerPictureBox.Click += new System.EventHandler(this.registerPictureBox_Click);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.Location = new System.Drawing.Point(339, 237);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(62, 64);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 11;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // deregisterPictureBox
            // 
            this.deregisterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deregisterPictureBox.Image")));
            this.deregisterPictureBox.Location = new System.Drawing.Point(37, 243);
            this.deregisterPictureBox.Name = "deregisterPictureBox";
            this.deregisterPictureBox.Size = new System.Drawing.Size(116, 58);
            this.deregisterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deregisterPictureBox.TabIndex = 12;
            this.deregisterPictureBox.TabStop = false;
            this.deregisterPictureBox.Click += new System.EventHandler(this.deregisterPictureBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 14;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(155, 176);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 20);
            this.tbTime.TabIndex = 15;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(466, 337);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deregisterPictureBox);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.registerPictureBox);
            this.Controls.Add(this.resetPictureBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginIdLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deregisterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LoginIdLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.PictureBox resetPictureBox;
        private System.Windows.Forms.PictureBox registerPictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox deregisterPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTime;
    }
}