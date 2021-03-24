using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary.Models
{
    class ScheduleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<SubjectModel> Subjects = new List<SubjectModel>();
    }
}
