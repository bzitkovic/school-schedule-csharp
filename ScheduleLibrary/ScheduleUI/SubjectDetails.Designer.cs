namespace ScheduleUI
{
    partial class SubjectDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectDetails));
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.txtProfessorName = new System.Windows.Forms.TextBox();
            this.lblProfessorSurname = new System.Windows.Forms.Label();
            this.txtProfessorSurname = new System.Windows.Forms.TextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtHall = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(192, 231);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(166, 45);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(29, 29);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(123, 18);
            this.lblProfessor.TabIndex = 0;
            this.lblProfessor.Text = "Professor name:";
            // 
            // txtProfessorName
            // 
            this.txtProfessorName.Enabled = false;
            this.txtProfessorName.Location = new System.Drawing.Point(192, 26);
            this.txtProfessorName.Name = "txtProfessorName";
            this.txtProfessorName.Size = new System.Drawing.Size(166, 26);
            this.txtProfessorName.TabIndex = 1;
            // 
            // lblProfessorSurname
            // 
            this.lblProfessorSurname.AutoSize = true;
            this.lblProfessorSurname.Location = new System.Drawing.Point(29, 61);
            this.lblProfessorSurname.Name = "lblProfessorSurname";
            this.lblProfessorSurname.Size = new System.Drawing.Size(144, 18);
            this.lblProfessorSurname.TabIndex = 2;
            this.lblProfessorSurname.Text = "Professor surname:";
            // 
            // txtProfessorSurname
            // 
            this.txtProfessorSurname.Enabled = false;
            this.txtProfessorSurname.Location = new System.Drawing.Point(192, 58);
            this.txtProfessorSurname.Name = "txtProfessorSurname";
            this.txtProfessorSurname.Size = new System.Drawing.Size(166, 26);
            this.txtProfessorSurname.TabIndex = 3;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(29, 125);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(79, 18);
            this.lblStartTime.TabIndex = 6;
            this.lblStartTime.Text = "Start time:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Enabled = false;
            this.txtStartTime.Location = new System.Drawing.Point(192, 122);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(166, 26);
            this.txtStartTime.TabIndex = 7;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(29, 157);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(74, 18);
            this.lblEndTime.TabIndex = 8;
            this.lblEndTime.Text = "End time:";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Enabled = false;
            this.txtEndTime.Location = new System.Drawing.Point(192, 154);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(166, 26);
            this.txtEndTime.TabIndex = 9;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(29, 189);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(38, 18);
            this.lblRoom.TabIndex = 10;
            this.lblRoom.Text = "Hall:";
            // 
            // txtHall
            // 
            this.txtHall.Enabled = false;
            this.txtHall.Location = new System.Drawing.Point(192, 186);
            this.txtHall.Name = "txtHall";
            this.txtHall.Size = new System.Drawing.Size(166, 26);
            this.txtHall.TabIndex = 11;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(29, 93);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(40, 18);
            this.lblDay.TabIndex = 4;
            this.lblDay.Text = "Day:";
            // 
            // txtDay
            // 
            this.txtDay.Enabled = false;
            this.txtDay.Location = new System.Drawing.Point(192, 90);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(166, 26);
            this.txtDay.TabIndex = 5;
            // 
            // SubjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(431, 292);
            this.Controls.Add(this.txtHall);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.txtProfessorSurname);
            this.Controls.Add(this.lblProfessorSurname);
            this.Controls.Add(this.txtProfessorName);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubjectDetails";
            this.Text = "Subject details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.TextBox txtProfessorName;
        private System.Windows.Forms.Label lblProfessorSurname;
        private System.Windows.Forms.TextBox txtProfessorSurname;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtHall;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox txtDay;
    }
}