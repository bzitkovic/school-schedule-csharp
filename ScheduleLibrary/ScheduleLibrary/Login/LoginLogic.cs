using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public class LoginLogic: ILoginConnection
    {
        public User CheckLoginCredentials(string username, string password)
        {
            User currentUser = new User();

            using (var context = new SchedulesEntities1())
            {               
                foreach (var user in context.Users)
                {
                    if (user.Username.ToString() == username && user.Password.ToString() == password)
                    {
                        currentUser = user;
                    }
                }
            }

            return currentUser;
        }
    }
}
