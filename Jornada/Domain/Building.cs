using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkDay.Domain
{
    public class Building: BaseClass
    {
        
        public Building(int id, string name, int numberOfFloors, TimeOnly workingDayStart, TimeOnly workingDatEnd)
        {
            this.Id = id;
            this.Name = name;
            Floors = new Floor[numberOfFloors];
            this.WorkingDayStart = workingDayStart;
            this.WorkingDayEnd = workingDatEnd;

            // Initializing floors
            for(int i=0; i<numberOfFloors; i++)
            {
                this.Floors[i] = new Floor();
            }
        }
        public string Name { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }
        public Floor[] Floors { get; private set; }
        public TimeOnly WorkingDayStart { get; set; }
        public TimeOnly WorkingDayEnd { get; set; }

        public int GetTaksFloor(Domain.Task task)
        {
            var floor = this.Floors.Where(x => x.Tasks.Any(t => t.Id == task.Id)).FirstOrDefault();
            return Array.IndexOf(Floors, floor);
        }

    }
}
