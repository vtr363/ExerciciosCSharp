using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lists.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{this.Id}, {this.Name}, {this.Salary}";
        }

        public void SalaryIncrease(double percentage)
        {
            this.Salary *= (percentage/100) + 1;
        }
    }
}