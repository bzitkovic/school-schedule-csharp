using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public class ScheduleLogic: ISchedule
    {
        public List<Subject> GetSelectedScheduleSubjects(Schedule selectedSchedule)
        {
            List<Subject> subjects = new List<Subject>();

            using (var context = new SchedulesEntities1())
            {
                var query = (from p in context.Schedules.Include("Subjects")
                             where p.Id == selectedSchedule.Id 
                             select p).FirstOrDefault();

                foreach (var subject in query.Subjects)
                {
                    subjects.Add(subject);
                }
            }

            return subjects;
        }

        public void CreateSchedule(User user, string name)
        {
            using (var context = new SchedulesEntities1())
            {               
                Schedule newSchedule = new Schedule
                {
                    Name = name,
                    IdUser = user.Id
                };

                context.Schedules.Add(newSchedule);

                context.SaveChanges();
            }
        }

        public List<Subject> GetFilteredScheduleSubjects(Schedule selectedSchedule, string day)
        {
            List<Subject> subjects = new List<Subject>();
          
            using (var context = new SchedulesEntities1())
            {               
                var query = (from p in context.Schedules.Include("Subjects")
                             where p.Id == selectedSchedule.Id
                             select p).FirstOrDefault();
               

                foreach (var subject in query.Subjects)
                {
                    var query2 = (from p in context.Subjects.Include("Durations").Include("Professors").Include("Halls")
                                  where p.Id == subject.Id
                                  select p).FirstOrDefault();

                    foreach (var duration in query2.Durations)
                    {
                        if (duration.Day == day)
                        {
                            subjects.Add(query2);
                        }
                    }
                }
            }

            return subjects;
        }

        public List<Schedule> GetSchedules(User user)
        {
            using (var context = new SchedulesEntities1())
            {
                return context.Schedules.Where(x => x.User.Id == user.Id).ToList();
            }
        }

        public void DeleteSchedule(Schedule selectedSchedule)
        {
            using (var context = new SchedulesEntities1())
            {
                var deletedSchedule = context.Schedules.SingleOrDefault(x => x.Id == selectedSchedule.Id);

                if (deletedSchedule != null)
                {
                    context.Schedules.Remove(deletedSchedule);
                }

                context.SaveChanges();
            }
        }
    }
}
