using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio.entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }

        public OrderItem(int quantity, Product product)
        {
            this.Quantity = quantity;
            this.Product = product;
            this.Price = this.Product.Price;
        }

        public override string ToString()
        {
            return $"{this.Product.Name}, {this.Quantity}, {this.Price}, Subtotal: ${this.subTotal()}";
        }

        public double subTotal()
        {
            return this.Price * this.Quantity;
        }

    }
}