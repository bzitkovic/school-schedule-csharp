using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary.Models
{
    class SubjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ects { get; set; }
        public string Description { get; set; }
        public List<TimeModel> SubjectsTime { get; set; }
        public List<ProfessorModel> Professors { get; set; } = new List<ProfessorModel>();
        public List<ScheduleModel> Schedules { get; set; } = new List<ScheduleModel>();
        public List<Hall> Halls { get; set; } = new List<Hall>();
    }
}
