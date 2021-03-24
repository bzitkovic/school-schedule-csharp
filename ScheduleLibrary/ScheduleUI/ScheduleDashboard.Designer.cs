namespace ScheduleUI
{
    partial class ScheduleDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleDashboard));
            this.lblChooseSchedule = new System.Windows.Forms.Label();
            this.cmbSchedules = new System.Windows.Forms.ComboBox();
            this.btnSelectSchedule = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnHall = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnNewSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseSchedule
            // 
            this.lblChooseSchedule.AutoSize = true;
            this.lblChooseSchedule.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChooseSchedule.Location = new System.Drawing.Point(32, 55);
            this.lblChooseSchedule.Name = "lblChooseSchedule";
            this.lblChooseSchedule.Size = new System.Drawing.Size(219, 24);
            this.lblChooseSchedule.TabIndex = 0;
            this.lblChooseSchedule.Text = "Choose your schedule";
            // 
            // cmbSchedules
            // 
            this.cmbSchedules.BackColor = System.Drawing.Color.LightGray;
            this.cmbSchedules.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbSchedules.FormattingEnabled = true;
            this.cmbSchedules.Location = new System.Drawing.Point(36, 84);
            this.cmbSchedules.Name = "cmbSchedules";
            this.cmbSchedules.Size = new System.Drawing.Size(206, 24);
            this.cmbSchedules.TabIndex = 1;
            // 
            // btnSelectSchedule
            // 
            this.btnSelectSchedule.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSchedule.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectSchedule.Location = new System.Drawing.Point(36, 127);
            this.btnSelectSchedule.Name = "btnSelectSchedule";
            this.btnSelectSchedule.Size = new System.Drawing.Size(206, 50);
            this.btnSelectSchedule.TabIndex = 2;
            this.btnSelectSchedule.Text = "Select schedule";
            this.btnSelectSchedule.UseVisualStyleBackColor = false;
            this.btnSelectSchedule.Click += new System.EventHandler(this.btnSelectSchedule_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSubject.Location = new System.Drawing.Point(267, 127);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(206, 50);
            this.btnSubject.TabIndex = 4;
            this.btnSubject.Text = "Subject";
            this.btnSubject.UseVisualStyleBackColor = false;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnHall
            // 
            this.btnHall.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHall.Location = new System.Drawing.Point(497, 127);
            this.btnHall.Name = "btnHall";
            this.btnHall.Size = new System.Drawing.Size(206, 50);
            this.btnHall.TabIndex = 6;
            this.btnHall.Text = "Hall";
            this.btnHall.UseVisualStyleBackColor = false;
            this.btnHall.Click += new System.EventHandler(this.btnHall_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfessor.Location = new System.Drawing.Point(267, 204);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(206, 50);
            this.btnProfessor.TabIndex = 5;
            this.btnProfessor.Text = "Professor";
            this.btnProfessor.UseVisualStyleBackColor = false;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfile.Location = new System.Drawing.Point(497, 204);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(206, 50);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnNewSchedule
            // 
            this.btnNewSchedule.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSchedule.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewSchedule.Location = new System.Drawing.Point(36, 204);
            this.btnNewSchedule.Name = "btnNewSchedule";
            this.btnNewSchedule.Size = new System.Drawing.Size(206, 50);
            this.btnNewSchedule.TabIndex = 3;
            this.btnNewSchedule.Text = "New schedule";
            this.btnNewSchedule.UseVisualStyleBackColor = false;
            this.btnNewSchedule.Click += new System.EventHandler(this.btnNewSchedule_Click);
            // 
            // ScheduleDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(748, 295);
            this.Controls.Add(this.btnNewSchedule);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.btnHall);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnSelectSchedule);
            this.Controls.Add(this.cmbSchedules);
            this.Controls.Add(this.lblChooseSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScheduleDashboard";
            this.Text = "Schedule dashboard";
            this.Activated += new System.EventHandler(this.ScheduleDashboard_Activated);
            this.Load += new System.EventHandler(this.ScheduleDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseSchedule;
        private System.Windows.Forms.ComboBox cmbSchedules;
        private System.Windows.Forms.Button btnSelectSchedule;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnHall;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnNewSchedule;
    }
}

