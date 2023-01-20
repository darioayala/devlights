using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDay.Domain
{
    public class Employee: BaseClass
    {
        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public string Name { get; set; }
    }
}
