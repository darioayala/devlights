using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WorkDay.Domain;
using WorkDay.Infrastructure;

namespace WorkDay.Business
{
    public class WorkDayHandler
    {
        public void StartWorkingDay(Building building)
        {

            var currentTime = building.WorkingDayStart;
            while(currentTime <= building.WorkingDayEnd)
            {
                // check for stating tasks
                var assignStart = building.Assignments.Where(x => x.StartHour == currentTime).ToList();

                if(assignStart.Any())
                {
                    assignStart.ForEach(x => Console.WriteLine(string.Format("{0} - Task started - Floor: {1} - {2}", currentTime.ToString(), building.GetTaksFloor(x.Task),  x.ToString())));
                }

                // check for ending tasks
                var assignEnd = building.Assignments.Where(x => x.FinishHour== currentTime).ToList();
                if(assignEnd.Any())
                {
                    assignEnd.ForEach(x => Console.WriteLine(string.Format("{0} - Task ended - Floor: {1} - {2}", currentTime.ToString(), building.GetTaksFloor(x.Task), x.ToString())));
                }

                currentTime = currentTime.AddMinutes(1);
            }

            



        }
    }
}
