namespace ScheduleUI
{
    partial class SubjectsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsForm));
            this.lblAddProfessor = new System.Windows.Forms.Label();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblAddHall = new System.Windows.Forms.Label();
            this.cmbHall = new System.Windows.Forms.ComboBox();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.btnEditSubject = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEcts = new System.Windows.Forms.Label();
            this.txtEcts = new System.Windows.Forms.TextBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.lblDay = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.btnShowSubjectDetails = new System.Windows.Forms.Button();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddProfessor
            // 
            this.lblAddProfessor.AutoSize = true;
            this.lblAddProfessor.Location = new System.Drawing.Point(278, 120);
            this.lblAddProfessor.Name = "lblAddProfessor";
            this.lblAddProfessor.Size = new System.Drawing.Size(126, 18);
            this.lblAddProfessor.TabIndex = 8;
            this.lblAddProfessor.Text = "Assign professor";
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.BackColor = System.Drawing.Color.LightGray;
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Location = new System.Drawing.Point(278, 159);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(200, 26);
            this.cmbProfessor.TabIndex = 9;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubject.Location = new System.Drawing.Point(35, 563);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(200, 42);
            this.btnAddSubject.TabIndex = 18;
            this.btnAddSubject.Text = "Create subject";
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(35, 292);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(75, 18);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "Start time";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(32, 378);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(70, 18);
            this.lblEndTime.TabIndex = 6;
            this.lblEndTime.Text = "End time";
            // 
            // lblAddHall
            // 
            this.lblAddHall.AutoSize = true;
            this.lblAddHall.Location = new System.Drawing.Point(278, 206);
            this.lblAddHall.Name = "lblAddHall";
            this.lblAddHall.Size = new System.Drawing.Size(83, 18);
            this.lblAddHall.TabIndex = 10;
            this.lblAddHall.Text = "Assign hall";
            // 
            // cmbHall
            // 
            this.cmbHall.BackColor = System.Drawing.Color.LightGray;
            this.cmbHall.FormattingEnabled = true;
            this.cmbHall.Location = new System.Drawing.Point(278, 245);
            this.cmbHall.Name = "cmbHall";
            this.cmbHall.Size = new System.Drawing.Size(200, 26);
            this.cmbHall.TabIndex = 11;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(500, 120);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.Size = new System.Drawing.Size(464, 347);
            this.dgvSubjects.TabIndex = 21;
            // 
            // btnEditSubject
            // 
            this.btnEditSubject.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSubject.Location = new System.Drawing.Point(558, 484);
            this.btnEditSubject.Name = "btnEditSubject";
            this.btnEditSubject.Size = new System.Drawing.Size(200, 42);
            this.btnEditSubject.TabIndex = 19;
            this.btnEditSubject.Text = "Edit subject";
            this.btnEditSubject.UseVisualStyleBackColor = false;
            this.btnEditSubject.Click += new System.EventHandler(this.btnEditSubject_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(35, 159);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblEcts
            // 
            this.lblEcts.AutoSize = true;
            this.lblEcts.Location = new System.Drawing.Point(38, 206);
            this.lblEcts.Name = "lblEcts";
            this.lblEcts.Size = new System.Drawing.Size(43, 18);
            this.lblEcts.TabIndex = 2;
            this.lblEcts.Text = "Ects:";
            // 
            // txtEcts
            // 
            this.txtEcts.Location = new System.Drawing.Point(38, 245);
            this.txtEcts.Name = "txtEcts";
            this.txtEcts.Size = new System.Drawing.Size(200, 26);
            this.txtEcts.TabIndex = 3;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(278, 493);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(197, 112);
            this.rtxtDescription.TabIndex = 17;
            this.rtxtDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(275, 461);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(92, 18);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(35, 331);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(200, 26);
            this.txtStartTime.TabIndex = 5;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(35, 417);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(200, 26);
            this.txtEndTime.TabIndex = 7;
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSubject.Location = new System.Drawing.Point(764, 484);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(200, 42);
            this.btnDeleteSubject.TabIndex = 20;
            this.btnDeleteSubject.Text = "Delete subject";
            this.btnDeleteSubject.UseVisualStyleBackColor = false;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(278, 292);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(36, 18);
            this.lblDay.TabIndex = 12;
            this.lblDay.Text = "Day";
            // 
            // cmbDay
            // 
            this.cmbDay.BackColor = System.Drawing.Color.LightGray;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(278, 331);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(200, 26);
            this.cmbDay.TabIndex = 13;
            // 
            // btnShowSubjectDetails
            // 
            this.btnShowSubjectDetails.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShowSubjectDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSubjectDetails.Location = new System.Drawing.Point(764, 72);
            this.btnShowSubjectDetails.Name = "btnShowSubjectDetails";
            this.btnShowSubjectDetails.Size = new System.Drawing.Size(200, 42);
            this.btnShowSubjectDetails.TabIndex = 22;
            this.btnShowSubjectDetails.Text = "Show details";
            this.btnShowSubjectDetails.UseVisualStyleBackColor = false;
            this.btnShowSubjectDetails.Click += new System.EventHandler(this.btnShowSubjectDetails_Click);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(278, 378);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(73, 18);
            this.lblSchedule.TabIndex = 14;
            this.lblSchedule.Text = "Schedule";
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.BackColor = System.Drawing.Color.LightGray;
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Location = new System.Drawing.Point(278, 417);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(200, 26);
            this.cmbSchedule.TabIndex = 15;
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1010, 657);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtEcts);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnShowSubjectDetails);
            this.Controls.Add(this.btnEditSubject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.cmbSchedule);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.cmbHall);
            this.Controls.Add(this.cmbProfessor);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblAddHall);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblEcts);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddProfessor);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubjectsForm";
            this.Text = "Subject";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddProfessor;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblAddHall;
        private System.Windows.Forms.ComboBox cmbHall;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Button btnEditSubject;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEcts;
        private System.Windows.Forms.TextBox txtEcts;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Button btnShowSubjectDetails;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.ComboBox cmbSchedule;
    }
}