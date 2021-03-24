using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public interface ILoginConnection
    {
        User CheckLoginCredentials(string username, string password);
    }
}
