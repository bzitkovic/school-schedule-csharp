namespace ScheduleUI
{
    partial class ScheduleViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleViewer));
            this.lblSheduleName = new System.Windows.Forms.Label();
            this.dgvSheduleSubjects = new System.Windows.Forms.DataGridView();
            this.cmbFilterByDay = new System.Windows.Forms.ComboBox();
            this.lblFilterByDay = new System.Windows.Forms.Label();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSheduleSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSheduleName
            // 
            this.lblSheduleName.AutoSize = true;
            this.lblSheduleName.Location = new System.Drawing.Point(28, 71);
            this.lblSheduleName.Name = "lblSheduleName";
            this.lblSheduleName.Size = new System.Drawing.Size(134, 18);
            this.lblSheduleName.TabIndex = 0;
            this.lblSheduleName.Text = "<Schedule name>";
            // 
            // dgvSheduleSubjects
            // 
            this.dgvSheduleSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSheduleSubjects.Location = new System.Drawing.Point(31, 106);
            this.dgvSheduleSubjects.Name = "dgvSheduleSubjects";
            this.dgvSheduleSubjects.Size = new System.Drawing.Size(531, 283);
            this.dgvSheduleSubjects.TabIndex = 3;
            // 
            // cmbFilterByDay
            // 
            this.cmbFilterByDay.BackColor = System.Drawing.Color.LightGray;
            this.cmbFilterByDay.FormattingEnabled = true;
            this.cmbFilterByDay.Location = new System.Drawing.Point(386, 68);
            this.cmbFilterByDay.Name = "cmbFilterByDay";
            this.cmbFilterByDay.Size = new System.Drawing.Size(176, 26);
            this.cmbFilterByDay.TabIndex = 2;
            this.cmbFilterByDay.SelectedIndexChanged += new System.EventHandler(this.cmbFilterByDay_SelectedIndexChanged);
            // 
            // lblFilterByDay
            // 
            this.lblFilterByDay.AutoSize = true;
            this.lblFilterByDay.Location = new System.Drawing.Point(275, 71);
            this.lblFilterByDay.Name = "lblFilterByDay";
            this.lblFilterByDay.Size = new System.Drawing.Size(96, 18);
            this.lblFilterByDay.TabIndex = 1;
            this.lblFilterByDay.Text = "Filter by day:";
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDetails.Location = new System.Drawing.Point(204, 408);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(176, 47);
            this.btnShowDetails.TabIndex = 4;
            this.btnShowDetails.Text = "Show details";
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSchedule.Location = new System.Drawing.Point(386, 408);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(176, 47);
            this.btnDeleteSchedule.TabIndex = 5;
            this.btnDeleteSchedule.Text = "Delete schedule";
            this.btnDeleteSchedule.UseVisualStyleBackColor = false;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click);
            // 
            // ScheduleViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(587, 475);
            this.Controls.Add(this.btnDeleteSchedule);
            this.Controls.Add(this.cmbFilterByDay);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.lblFilterByDay);
            this.Controls.Add(this.lblSheduleName);
            this.Controls.Add(this.dgvSheduleSubjects);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScheduleViewer";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.ScheduleViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSheduleSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSheduleName;
        private System.Windows.Forms.DataGridView dgvSheduleSubjects;
        private System.Windows.Forms.ComboBox cmbFilterByDay;
        private System.Windows.Forms.Label lblFilterByDay;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnDeleteSchedule;
    }
}