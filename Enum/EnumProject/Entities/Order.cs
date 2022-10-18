using System;
using EnumProject.Entities.Enums;

namespace EnumProject.Entities
{
    public class Order
    {
        public int Id {get; set;}
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}