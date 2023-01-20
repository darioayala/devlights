using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDay.Domain
{
    public class Assignment: BaseClass
    {
        public Assignment(int id, Employee employee, Task task, TimeOnly startHour, TimeOnly finishHour)
        {
            Id = id;
            Employee = employee;
            Task = task;
            StartHour = startHour;
            FinishHour = finishHour;
        }

        public Employee Employee { get; set; }
        public Task Task { get; set; }
        public TimeOnly StartHour { get; set; }
        public TimeOnly FinishHour { get; set; }

        public override string ToString()
        {
            return string.Format("Employee: {0} - Taks: {1} ", Employee.Name, Task.Description);
        }
    }
}
