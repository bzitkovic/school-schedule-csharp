using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public class SubjectLogic : ISubject
    {
        public void CreateSubject(Subject subject)
        {
            using (var context = new SchedulesEntities1())
            {
                Subject newSubject = new Subject
                {
                    Name = subject.Name,
                    Ects = subject.Ects,
                    Description = subject.Description,
                    Durations = subject.Durations
                };

                Schedule newSchedule = subject.Schedules.First();
                Professor newProfessor = subject.Professors.First();
                Hall newHall = subject.Halls.First();

                context.Schedules.Attach(newSchedule);
                context.Professors.Attach(newProfessor);
                context.Halls.Attach(newHall);

                newSubject.Schedules.Add(newSchedule);
                newSubject.Professors.Add(newProfessor);
                newSubject.Halls.Add(newHall);

                context.Subjects.Add(newSubject);

                context.SaveChanges();
            }
        }

        public void DeleteSubject(Subject subject)
        {
            using (var context = new SchedulesEntities1())
            {        
                var deletedSubject = context.Subjects.SingleOrDefault(x => x.Id == subject.Id);

                if (deletedSubject != null)
                {
                    context.Subjects.Remove(deletedSubject);
                }

                context.SaveChanges();
            }
        }

        public List<Subject> GetAllSubjects()
        {            
            using (var context = new SchedulesEntities1())
            {                                
                return context.Subjects.ToList();
            }
        }

        public void UpdateSubject(Subject subject)
        {
            using (var context = new SchedulesEntities1())
            {
             
                context.Subjects.Attach(subject);

                context.Entry(subject).State = EntityState.Modified;

                context.SaveChanges();

                context.Entry(subject).State = EntityState.Detached;
            }
        }
    }
}