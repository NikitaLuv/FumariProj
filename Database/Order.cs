using System;
using System.Collections.Generic;

#nullable disable

namespace FumariProject.Database
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }
        public string OrderGuid { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerNumber { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
