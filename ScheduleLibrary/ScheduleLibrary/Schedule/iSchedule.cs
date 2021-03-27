using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public interface ISchedule
    {
        List<Subject> GetSelectedScheduleSubjects(Schedule schedule);
        void CreateSchedule(User user, string name);
        List<Subject> GetFilteredScheduleSubjects(Schedule selectedSchedule, string day);
        List<Schedule> GetSchedules(User user);
        void DeleteSchedule(Schedule selectedSchedule);
    }
}
