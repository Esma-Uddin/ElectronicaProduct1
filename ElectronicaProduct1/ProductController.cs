using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicaProduct1
{
    
    public class ProductController
    {
        public List<Product> Products { get; set; }

        public ProductController()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
