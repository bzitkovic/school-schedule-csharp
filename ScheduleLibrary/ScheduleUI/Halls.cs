using ScheduleLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleUI
{
    public partial class Halls : Form
    {
        Hall chosenHall;
        public Halls()
        {
            InitializeComponent();

            ShowAllHalls();
        }

        private void ShowAllHalls()
        {
            dgvHalls.DataSource = null;
            dgvHalls.DataSource = GlobalConfig.Hall.GetAllHalls();
            dgvHalls.Columns["Subjects"].Visible = false;
        }

        private void btnAddHall_Click(object sender, EventArgs e)
        {           
            if (btnAddHall.Text == "Add hall")
            {
                if (CheckUserInput())
                {
                    GlobalConfig.Hall.CreateHall(GetHallData());
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of seats!");
                }              
            }
            else
            {
                if (CheckUserInput())
                {
                    chosenHall.Name = txtName.Text;
                    chosenHall.Seats = int.Parse(txtNumberOfSeats.Text);

                    GlobalConfig.Hall.UpdateHall(chosenHall);

                    btnAddHall.Text = "Add hall";
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of seats!");
                }                             
            }

            ClearForm();

            ShowAllHalls();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtNumberOfSeats.Text = "";
        }

        private Hall GetHallData()
        {
            Hall hall = new Hall();           

            hall.Name = txtName.Text;
            hall.Seats = int.Parse(txtNumberOfSeats.Text);

            return hall;
        }

        private bool CheckUserInput()
        {
            bool output = true;
            int numberOfSeats = 0;

            if (!int.TryParse(txtNumberOfSeats.Text, out numberOfSeats))
            {
                output = false;
            }

            return output;
        }

        private void btnEditHall_Click(object sender, EventArgs e)
        {            
            chosenHall = GetChosenHall();

            txtName.Text = chosenHall.Name;
            txtNumberOfSeats.Text = chosenHall.Seats.ToString();

            btnAddHall.Text = "Update hall";
        }

        private Hall GetChosenHall()
        {
            return dgvHalls.CurrentRow.DataBoundItem as Hall;
        }

        private void btnDeleteHall_Click(object sender, EventArgs e)
        {
            chosenHall = GetChosenHall();

            GlobalConfig.Hall.DeleteHall(chosenHall);

            ShowAllHalls();
        }
    }
}
