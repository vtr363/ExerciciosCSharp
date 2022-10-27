using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace worker.entities
{
    public class Worker
    {
        public string name { get; set; }
        public WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            this.name = name;
            this.level = level;
            this.BaseSalary = baseSalary;
            this.Department = Department;
        }

        public void addContract(HourContract contract)
        {
            contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            contracts.Remove(contract);
        }

        public string income(int year, int month)
        {
            double income = this.BaseSalary;
            foreach (HourContract contract in contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                     income += contract.totalValue();
                }
            }
            return income.ToString("F2");
        }
        

        
    }
}