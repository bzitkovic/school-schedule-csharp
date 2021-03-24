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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (CheckUserInput())
            {
                User newUser = new User();

                newUser.Username = txtUsername.Text;
                newUser.Password = txtPasword.Text;
                newUser.Email = txtEmail.Text;

                GlobalConfig.Profile.CreateProfile(newUser);

                this.Close();
            }
            else
            {
                MessageBox.Show("Form is not correct!");
            }          
        }

        private bool CheckUserInput()
        {
            bool output = true;

            if (!txtEmail.Text.Contains("@"))
            {
                output = false;
            }

            if (txtUsername.Text == "")
            {
                output = false;
            }

            return output;
        }
    }
}
