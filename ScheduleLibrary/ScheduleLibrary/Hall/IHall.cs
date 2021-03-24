using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public interface IHall
    {
        void CreateHall(Hall hall);

        void UpdateHall(Hall hall);

        void DeleteHall(Hall hall);

        List<Hall> GetAllHalls();
    }
}
