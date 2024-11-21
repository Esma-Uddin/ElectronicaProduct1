using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicaProduct1
{
    public class OrderController
    {
        public List<Order> Orders { get; set; }

        public OrderController()
        {
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}
