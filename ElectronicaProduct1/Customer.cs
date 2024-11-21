using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicaProduct1
{
    using System.Collections.Generic;

    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Product> Cart { get; set; } 

        public Customer(string name, string surname, string email, string password)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            Cart = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            Cart.Add(product);
        }
    }

}
