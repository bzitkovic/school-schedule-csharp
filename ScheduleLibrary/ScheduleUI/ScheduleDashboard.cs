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
    public partial class ScheduleDashboard : Form, IUser
    {
        User currentUser;
        public ScheduleDashboard(User user)
        {
            InitializeComponent();

            currentUser = user;
        }

        private void ScheduleDashboard_Load(object sender, EventArgs e)
        {
            cmbSchedules.DataSource = GlobalConfig.Schedule.GetSchedules(currentUser);
        }       

        private void btnSelectSchedule_Click(object sender, EventArgs e)
        {
            if (!(cmbSchedules.Text == ""))
            {
                Schedule schedule = (Schedule)cmbSchedules.SelectedItem;

                ScheduleViewer frm = new ScheduleViewer(schedule);

                frm.Show();
            }
            else
            {
                MessageBox.Show("You don't have any schedules!");
            }                     
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UserProfile frm = new UserProfile(this);

            frm.Show();
        }

        public User GetUserInfo()
        {
            return currentUser;
        }

        private void btnHall_Click(object sender, EventArgs e)
        {
            Halls frm = new Halls();

            frm.Show();          
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            Professors frm = new Professors();

            frm.Show();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            SubjectsForm frm = new SubjectsForm(currentUser);

            frm.Show();
        }

        private void btnNewSchedule_Click(object sender, EventArgs e)
        {
            NewSchedule frm = new NewSchedule(currentUser);

            frm.Show();
        }

        private void ScheduleDashboard_Activated(object sender, EventArgs e)
        {
            cmbSchedules.DataSource = GlobalConfig.Schedule.GetSchedules(currentUser);
        }
    }
}
