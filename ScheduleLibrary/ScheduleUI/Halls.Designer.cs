namespace ScheduleUI
{
    partial class Halls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Halls));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumberOfSeats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddHall = new System.Windows.Forms.Button();
            this.lblNumberOfSeats = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEditHall = new System.Windows.Forms.Button();
            this.dgvHalls = new System.Windows.Forms.DataGridView();
            this.btnDeleteHall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHalls)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtNumberOfSeats
            // 
            this.txtNumberOfSeats.Location = new System.Drawing.Point(23, 168);
            this.txtNumberOfSeats.Name = "txtNumberOfSeats";
            this.txtNumberOfSeats.Size = new System.Drawing.Size(176, 26);
            this.txtNumberOfSeats.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-643, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "label1fdsf";
            // 
            // btnAddHall
            // 
            this.btnAddHall.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHall.Location = new System.Drawing.Point(23, 231);
            this.btnAddHall.Name = "btnAddHall";
            this.btnAddHall.Size = new System.Drawing.Size(176, 47);
            this.btnAddHall.TabIndex = 4;
            this.btnAddHall.Text = "Add hall";
            this.btnAddHall.UseVisualStyleBackColor = false;
            this.btnAddHall.Click += new System.EventHandler(this.btnAddHall_Click);
            // 
            // lblNumberOfSeats
            // 
            this.lblNumberOfSeats.AutoSize = true;
            this.lblNumberOfSeats.Location = new System.Drawing.Point(23, 138);
            this.lblNumberOfSeats.Name = "lblNumberOfSeats";
            this.lblNumberOfSeats.Size = new System.Drawing.Size(126, 18);
            this.lblNumberOfSeats.TabIndex = 2;
            this.lblNumberOfSeats.Text = "Number of seats:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnEditHall
            // 
            this.btnEditHall.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditHall.Location = new System.Drawing.Point(264, 359);
            this.btnEditHall.Name = "btnEditHall";
            this.btnEditHall.Size = new System.Drawing.Size(176, 47);
            this.btnEditHall.TabIndex = 5;
            this.btnEditHall.Text = "Edit hall";
            this.btnEditHall.UseVisualStyleBackColor = false;
            this.btnEditHall.Click += new System.EventHandler(this.btnEditHall_Click);
            // 
            // dgvHalls
            // 
            this.dgvHalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHalls.Location = new System.Drawing.Point(245, 50);
            this.dgvHalls.Name = "dgvHalls";
            this.dgvHalls.Size = new System.Drawing.Size(377, 303);
            this.dgvHalls.TabIndex = 7;
            // 
            // btnDeleteHall
            // 
            this.btnDeleteHall.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHall.Location = new System.Drawing.Point(446, 359);
            this.btnDeleteHall.Name = "btnDeleteHall";
            this.btnDeleteHall.Size = new System.Drawing.Size(176, 47);
            this.btnDeleteHall.TabIndex = 6;
            this.btnDeleteHall.Text = "Delete hall";
            this.btnDeleteHall.UseVisualStyleBackColor = false;
            this.btnDeleteHall.Click += new System.EventHandler(this.btnDeleteHall_Click);
            // 
            // Halls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(646, 426);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumberOfSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddHall);
            this.Controls.Add(this.lblNumberOfSeats);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDeleteHall);
            this.Controls.Add(this.btnEditHall);
            this.Controls.Add(this.dgvHalls);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Halls";
            this.Text = "Hall";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumberOfSeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddHall;
        private System.Windows.Forms.Label lblNumberOfSeats;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEditHall;
        private System.Windows.Forms.DataGridView dgvHalls;
        private System.Windows.Forms.Button btnDeleteHall;
    }
}