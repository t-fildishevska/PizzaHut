﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Models
{
    public class OrderDetail : IEntity
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int PizzaID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }

        public Order Order { get; set; }
        public Pizza Pizza { get; set; }

    }
}
