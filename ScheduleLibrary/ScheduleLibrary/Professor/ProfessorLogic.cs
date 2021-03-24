using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public class ProfessorLogic : IProfessor
    {
        public void CreateProfessor(Professor professor)
        {
            using (var context = new SchedulesEntities1())
            {
                Professor newProfessor = new Professor
                {
                    Name = professor.Name,
                    Surname = professor.Surname,
                    Email = professor.Email
                };

                context.Professors.Add(newProfessor);
                context.SaveChanges();
            }
        }

        public void DeleteProfessor(Professor professor)
        {          
            using (var context = new SchedulesEntities1())
            {
                var deletedProfessor = context.Professors.SingleOrDefault(x => x.Id == professor.Id);

                if (deletedProfessor != null)
                {
                    context.Professors.Remove(deletedProfessor);
                }

                context.SaveChanges();
            }
        }

        public List<Professor> GetAllProfessors()
        {
            List<Professor> professors = new List<Professor>();

            using (var context = new SchedulesEntities1())
            {
                foreach (var professor in context.Professors)
                {
                    professors.Add(professor);
                }
            }

            return professors;
        }

        public void UpdateProfessor(Professor professor)
        {           
            using (var context = new SchedulesEntities1())
            {
                var updatedProfessor = context.Professors.SingleOrDefault(x => x.Id == professor.Id);

                if (updatedProfessor != null)
                {
                    updatedProfessor.Name = professor.Name;
                    updatedProfessor.Surname = professor.Surname;
                    updatedProfessor.Email = professor.Email;
                }

                context.SaveChanges();
            }
        }
    }
}
