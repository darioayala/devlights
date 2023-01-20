using WorkDay.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDay.Infrastructure
{
    public class DataInitialization
    {

        public static Building Initialize() 
        { 

            // Building initialization
            var building = new Building(1, "Av. Corrientes 1234",5, new TimeOnly(8,0), new TimeOnly(18,0));
            
            // Floors initialization

            //Tasks initialization and floor asignment
            building.Floors[0].Tasks.Add(new Domain.Task(1, "Study cases"));
            building.Floors[1].Tasks.Add(new Domain.Task(2, "Fotocopies"));
            building.Floors[2].Tasks.Add(new Domain.Task(3, "Call with clients"));
            building.Floors[3].Tasks.Add(new Domain.Task(4, "Meeting"));
            building.Floors[4].Tasks.Add(new Domain.Task(5, "Mentoring"));
            building.Floors[4].Tasks.Add(new Domain.Task(6, "Learning"));


            //Employee initialization
            var employees = new List<Employee>
            {
                new Employee(1, "John"),
                new Employee(2, "Mary"),
                new Employee(3, "Mike"),
                new Employee(4, "Sharon")
            };

            var t1 = from f in building.Floors where f.Tasks.Any(x => x.Id== 1) select f.Tasks.FirstOrDefault(x => x.Id == 1);
            var tt = building.Floors.Where(f => f.Tasks.Any(x => x.Id == 1)).Select(f => f.Tasks.FirstOrDefault(x => x.Id == 1)).FirstOrDefault();

            building.Assignments = new List<Assignment>
            {
                new Assignment(1, employees.FirstOrDefault(x => x.Id == 1), getTask(building,1), new TimeOnly(8, 0), new TimeOnly(9, 0)),
                new Assignment(2, employees.FirstOrDefault(x => x.Id == 2), getTask(building,4), new TimeOnly(14, 0), new TimeOnly(14, 30)),

                new Assignment(3, employees.FirstOrDefault(x => x.Id == 2), getTask(building,3), new TimeOnly(10, 0), new TimeOnly(11, 0)),
                new Assignment(4, employees.FirstOrDefault(x => x.Id == 3), getTask(building,3), new TimeOnly(17, 15), new TimeOnly(17, 30)),
                new Assignment(4, employees.FirstOrDefault(x => x.Id == 4), getTask(building,2), new TimeOnly(10, 0), new TimeOnly(12, 0)),
                new Assignment(3, employees.FirstOrDefault(x => x.Id == 2), getTask(building,5), new TimeOnly(15, 0), new TimeOnly(16, 30)),
                new Assignment(3, employees.FirstOrDefault(x => x.Id == 1), getTask(building,6), new TimeOnly(17, 0), new TimeOnly(18, 0)),
                new Assignment(1, employees.FirstOrDefault(x => x.Id == 3), getTask(building,1), new TimeOnly(11, 0), new TimeOnly(12, 15)),
                new Assignment(2, employees.FirstOrDefault(x => x.Id == 3), getTask(building,2), new TimeOnly(8, 0), new TimeOnly(11, 0)),
                new Assignment(1, employees.FirstOrDefault(x => x.Id == 5), getTask(building,3), new TimeOnly(14, 30), new TimeOnly(15, 30))
            };


            return building;
        
        }

        private static Domain.Task getTask(Building building, int id)
        { 
            return building.Floors.Where(f => f.Tasks.Any(x => x.Id == id)).Select(f => f.Tasks.FirstOrDefault(x => x.Id == id)).FirstOrDefault();
        }


    }
}
