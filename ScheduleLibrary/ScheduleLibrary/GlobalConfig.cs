using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public static class GlobalConfig
    {
        public static IProfile Profile { get; private set; } = new ProfileLogic();
        public static IHall Hall { get; private set; } = new HallLogic();
        public static IProfessor Professor { get; private set; } = new ProfessorLogic();
        public static ISubject Subject { get; private set; } = new SubjectLogic();
        public static ISchedule Schedule { get; private set; } = new ScheduleLogic();
    }
}
