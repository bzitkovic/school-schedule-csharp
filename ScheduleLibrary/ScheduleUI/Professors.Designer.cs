namespace ScheduleUI
{
    partial class Professors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professors));
            this.dgvProfessors = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEditProfessor = new System.Windows.Forms.Button();
            this.btnAddProfessor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnDeleteProfessor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfessors
            // 
            this.dgvProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessors.Location = new System.Drawing.Point(239, 12);
            this.dgvProfessors.Name = "dgvProfessors";
            this.dgvProfessors.Size = new System.Drawing.Size(470, 303);
            this.dgvProfessors.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnEditProfessor
            // 
            this.btnEditProfessor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfessor.Location = new System.Drawing.Point(351, 321);
            this.btnEditProfessor.Name = "btnEditProfessor";
            this.btnEditProfessor.Size = new System.Drawing.Size(176, 47);
            this.btnEditProfessor.TabIndex = 7;
            this.btnEditProfessor.Text = "Edit professor";
            this.btnEditProfessor.UseVisualStyleBackColor = false;
            this.btnEditProfessor.Click += new System.EventHandler(this.btnEditProfessor_Click);
            // 
            // btnAddProfessor
            // 
            this.btnAddProfessor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProfessor.Location = new System.Drawing.Point(12, 268);
            this.btnAddProfessor.Name = "btnAddProfessor";
            this.btnAddProfessor.Size = new System.Drawing.Size(176, 47);
            this.btnAddProfessor.TabIndex = 6;
            this.btnAddProfessor.Text = "Add professor";
            this.btnAddProfessor.UseVisualStyleBackColor = false;
            this.btnAddProfessor.Click += new System.EventHandler(this.btnAddProfessor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-654, -8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1fdsf";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 100);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(75, 18);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 179);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 18);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(12, 130);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(176, 26);
            this.txtSurname.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // btnDeleteProfessor
            // 
            this.btnDeleteProfessor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProfessor.Location = new System.Drawing.Point(533, 321);
            this.btnDeleteProfessor.Name = "btnDeleteProfessor";
            this.btnDeleteProfessor.Size = new System.Drawing.Size(176, 47);
            this.btnDeleteProfessor.TabIndex = 8;
            this.btnDeleteProfessor.Text = "Delete professor";
            this.btnDeleteProfessor.UseVisualStyleBackColor = false;
            this.btnDeleteProfessor.Click += new System.EventHandler(this.btnDeleteProfessor_Click);
            // 
            // Professors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(776, 417);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddProfessor);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDeleteProfessor);
            this.Controls.Add(this.btnEditProfessor);
            this.Controls.Add(this.dgvProfessors);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Professors";
            this.Text = "Professor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfessors;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEditProfessor;
        private System.Windows.Forms.Button btnAddProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnDeleteProfessor;
    }
}