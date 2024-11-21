using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicaProduct1
{
    using System;

    public class Order
    {
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Order(DateTime date, Customer customer, Product product, int quantity)
        {
            Date = date;
            Customer = customer;
            Product = product;
            Quantity = quantity;
        }
    }

}
