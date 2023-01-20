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
                var assign = building.Assignments.Where(x => x.StartHour == currentTime).ToList();

                if(assign.Any())
                {
                    assign.ForEach(x => Console.WriteLine(x.ToString()));
                }

                // check for ending tasks


                currentTime = currentTime.AddMinutes(1);
            }

            



        }
    }
}
