using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public interface ISubject
    {
        void CreateSubject(Subject subject);
        void DeleteSubject(Subject subject);
        void UpdateSubject(Subject subject);      
        List<Subject> GetAllSubjects();
    }
}
