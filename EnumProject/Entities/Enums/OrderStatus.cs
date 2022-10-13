using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnumProject.Entities.Enums
{
    public enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}