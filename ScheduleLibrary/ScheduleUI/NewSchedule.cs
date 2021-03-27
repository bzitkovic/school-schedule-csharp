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
    public partial class NewSchedule : Form
    {
        User currentUser;
        public NewSchedule(User user)
        {
            InitializeComponent();

            currentUser = user;
        }

        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if(name != "")
            {
                GlobalConfig.Schedule.CreateSchedule(currentUser, name);

                this.Close();
            }
            else
            {
                MessageBox.Show("Name can't be empty!");
            }           
        }
    }
}
