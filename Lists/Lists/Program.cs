using System;
using Lists.Entities;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("How Many employees will be registered?");
            int n = int.Parse(Console.ReadLine());
            
            List<Employee> list = new List<Employee>();
            for(int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Employee #{i}");
                System.Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
    // Falta verificar se o id ja foi utilizado

                System.Console.Write("\nName: ");
                String name = Console.ReadLine();

                System.Console.Write("\nSalary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
            }

            System.Console.WriteLine("\nEnter the employee id that wil have salary increase: ");
            int idFind = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the percentage: ");
            double increase = double.Parse(Console.ReadLine());

            int index = list.FindIndex(x => x.Id == idFind);
            list[index].SalaryIncrease(increase);

            System.Console.WriteLine("Updated list of employees:");
            foreach(Employee x in list)
            {
                System.Console.WriteLine(x);
            }

        }  

        static bool checkId(Employee x, int id)
        {
            return (x.Id == id) ? true : false;
        }
    }
    
}