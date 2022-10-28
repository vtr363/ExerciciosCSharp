using System;
using Exercicio.entities;
namespace ProjectName
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Client data:\n Name: ");
            string name = Console.ReadLine();

            System.Console.Write("Email: ");
            string email = Console.ReadLine();

            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Enter order data: \nStatus: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(new Client(name, email, birthDate), status);
            System.Console.Write("How many items to this order? ");
            int howMany = int.Parse(Console.ReadLine());
            for (int i = 0; i < howMany; i++)
            {
                System.Console.WriteLine($"Enter #{i+1} item data:");
                System.Console.Write("Product name: ");
                string productName = Console.ReadLine();
                System.Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                System.Console.Write("Product quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                order.addItem(new OrderItem(productQuantity, new Product(productName, productPrice)));
            }

            System.Console.WriteLine(order);


		}
	}
}
