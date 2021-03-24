using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public class ProfileLogic : IProfile
    {
        public void CreateProfile(User user)
        {
            using (var context = new SchedulesEntities1())
            {
                User newUser = new User
                {
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email
                };

                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }

        public void DeleteProfile(User user)
        {
            using (var context = new SchedulesEntities1())
            {
                var deletedUser = context.Users.SingleOrDefault(x => x.Id == user.Id);

                if (deletedUser != null)
                {
                    context.Users.Remove(deletedUser);
                }

                context.SaveChanges();
            }
        }

        public void UpdateProfile(User user)
        {
            using (var context = new SchedulesEntities1())
            {
                var updatedUser = context.Users.SingleOrDefault(x => x.Id == user.Id);

                if (updatedUser != null)
                {
                    updatedUser.Username = user.Username;
                    updatedUser.Password = user.Password;
                    updatedUser.Email = user.Email;
                }                                           

                context.SaveChanges();                
            }
        }
    }
}
