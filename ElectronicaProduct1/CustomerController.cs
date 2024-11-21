using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicaProduct1
{
    public class CustomerController
    {
        public List<Customer> Customers { get; set; }

        public CustomerController()
        {
            Customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
    }
}
