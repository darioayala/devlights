using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDay.Domain
{
    public class Task: BaseClass
    {
        public Task(int id, string description)
        {
            this.Id = id;
            this.Description= description;
        }
        public string Description { get; set; }

    }
}
