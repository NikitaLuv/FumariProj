using System;
using System.Collections.Generic;

#nullable disable

namespace FumariProject.Database
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Battary { get; set; }
        public int Puffs { get; set; }
        public string Nicotine { get; set; }
        public int Liquid { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
