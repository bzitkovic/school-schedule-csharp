using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public interface IProfile
    {
        void UpdateProfile(User user);
        void DeleteProfile(User user);
        void CreateProfile(User user);
    }
}
