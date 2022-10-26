using System;
using worker.entities;

namespace ProjectName
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine("Enter department's name: ");
            string Name = System.Console.ReadLine();
			Department department = new Department(Name);

			System.Console.WriteLine("Enter worker data:");
			System.Console.WriteLine("Name: ");
			string workerName = System.Console.ReadLine();

			System.Console.WriteLine("Level (Junior/MidLevel/Senior): ");
			WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

			System.Console.WriteLine("Base Salary:");
			double baseSalary = Double.Parse(Console.ReadLine());
			Worker employee = new Worker(Name, level, baseSalary, department);

			System.Console.WriteLine("How many contracts to this worker?");
			int howMany = int.Parse(Console.ReadLine());
			for (int i = 0; i < howMany; i++)
			{
				System.Console.WriteLine($"Enter #{i+1} contract to this worker");
				System.Console.WriteLine("Date (DD/MM/YYYY): ");
				DateTime contractDate = DateTime.Parse(Console.ReadLine());

				System.Console.WriteLine("Value per Hour: ");
				double value = Double.Parse(Console.ReadLine());

				System.Console.WriteLine("Duration (hours): ");
				int hours = int.Parse(Console.ReadLine());

				employee.addContract(new HourContract(contractDate, value, hours));
			}

			System.Console.WriteLine("enter month and year to calculate income (MM/YYYY): ");
			DateTime date = DateTime.Parse(Console.ReadLine());

			
		}
	}
}