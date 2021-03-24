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
    public partial class Login : Form
    {
        ILoginConnection login = new LoginLogic();      
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User user = login.CheckLoginCredentials(username, password);
            
            if (user.Username != null)
            {
                ScheduleDashboard frm = new ScheduleDashboard(user);

                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("User credentials are not valid!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration frm = new Registration();

            frm.Show();
        }
    }
}
