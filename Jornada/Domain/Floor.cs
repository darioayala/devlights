using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDay.Domain
{
    public class Floor
    {
        public Floor()
        {
            this.Tasks = new List<Task>();
        }
        public List<Task> Tasks { get; set; }
    }
}
