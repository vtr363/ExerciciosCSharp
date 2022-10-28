using System.Text;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio.entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public Order(Client client, OrderStatus status)
        {
            this.Client = client;
            this.Moment = DateTime.Now;
            this.Status = OrderStatus.PendingPayment;
        }

        public override string ToString()
        {
            StringBuilder orderSummary = new StringBuilder();
            orderSummary.Append("ORDER SUMMARY:\nOrder moment: ");
            orderSummary.Append(this.Moment);
            orderSummary.Append("\nOrder status: ");
            orderSummary.Append(this.Status);
            orderSummary.Append(this.Client);
            orderSummary.Append("Ordet items:");
            foreach (OrderItem item in this.Items)
            {
                orderSummary.Append($"\n{item}");
            }
            orderSummary.Append($"\nTotal price: {this.total()}");
            return orderSummary.ToString();
        }

        public void addItem(OrderItem orderItem)
        {
            this.Items.Add(orderItem);
        }
        public void removeItem(OrderItem orderItem)
        {
            this.Items.Remove(orderItem);
        }
        public double total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.subTotal();
            }
            return total;
        }


    }
}