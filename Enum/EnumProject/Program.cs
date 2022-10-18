using System;
using EnumProject.Entities;
using EnumProject.Entities.Enums;

namespace EnumProject

{
	class Program
	{
		static void Main(string[] args)
		{
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            System.Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
		}
	}
}