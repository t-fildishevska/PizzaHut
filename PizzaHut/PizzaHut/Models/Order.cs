using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Models
{
    public class Order : IEntity
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderName { get; set; }
        public string OrderAddress { get; set; }
        public string OrderCity { get; set; }
        public DateTime DeliveryDate { get; set; }

        public Employee Employee { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public User User { get; set; }

    }
}
