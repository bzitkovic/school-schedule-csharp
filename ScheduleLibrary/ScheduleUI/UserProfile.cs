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
    public partial class UserProfile : Form
    {
        User currentUser;
        public UserProfile(IUser user)
        {
            InitializeComponent();

            currentUser = user.GetUserInfo();           

            PopulateUserForm();
        }

        private void PopulateUserForm()
        {
            txtUsername.Text = currentUser.Username;
            txtPasword.Text = currentUser.Password;
            txtEmail.Text = currentUser.Email;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (CheckUserInput())
            {
                GetCurrentUserData();

                GlobalConfig.Profile.UpdateProfile(currentUser);

                this.Close();
            }
            else
            {
                MessageBox.Show("Email is not valid!");
            }         
        }

        private bool CheckUserInput()
        {
            bool output = true;

            if (!txtEmail.Text.Contains("@"))
            {
                output = false;
            }

            return output;
        }

        private void GetCurrentUserData()
        {      
            currentUser.Password = txtPasword.Text;
            currentUser.Email = txtEmail.Text;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            GlobalConfig.Profile.DeleteProfile(currentUser);

            this.Close();

            Application.OpenForms["ScheduleDashboard"].Close();

            Login frm = new Login();
            frm.Show();
        }
    }
}
