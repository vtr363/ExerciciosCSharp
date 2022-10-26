using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace worker.entities
{
    public class Department
    {
        public string name { get; set; }

        public Department (string name)
        {
            this.name = name;
        }
    }
}