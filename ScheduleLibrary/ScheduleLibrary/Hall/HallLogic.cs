using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary
{
    public class HallLogic: IHall
    {
        public void CreateHall(Hall hall)
        {
            using (var context = new SchedulesEntities1())
            {
                Hall newHall = new Hall
                {
                    Name = hall.Name,
                    Seats = hall.Seats
                };

                context.Halls.Add(newHall);
                context.SaveChanges();
            }
        }

        public void DeleteHall(Hall hall)
        {
            using (var context = new SchedulesEntities1())
            {
                var deletedHall = context.Halls.SingleOrDefault(x => x.Id == hall.Id);

                if (deletedHall != null)
                {
                    context.Halls.Remove(deletedHall);                    
                }

                context.SaveChanges();
            }
        }

        public List<Hall> GetAllHalls()
        {
            List<Hall> halls = new List<Hall>();

            using (var context = new SchedulesEntities1())
            {
                foreach (Hall hall in context.Halls)
                {
                    halls.Add(hall);
                }
            }

            return halls;
        }

        public void UpdateHall(Hall hall)
        {           
            using (var context = new SchedulesEntities1())
            {
                var updatedHall = context.Halls.SingleOrDefault(x => x.Id == hall.Id);

                if (updatedHall != null)
                {
                    updatedHall.Name = hall.Name;
                    updatedHall.Seats = hall.Seats;
                }

                context.SaveChanges();
            }
        }
    }
}
