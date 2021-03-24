using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public interface IProfessor
    {
        void CreateProfessor(Professor professor);
        void DeleteProfessor(Professor professor);
        void UpdateProfessor(Professor professor);
        List<Professor> GetAllProfessors();
    }
}
