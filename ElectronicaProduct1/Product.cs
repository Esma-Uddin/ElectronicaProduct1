using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicaProduct1.Enums;

namespace ElectronicaProduct1
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int SellCount { get; set; }
        public Category ProductCategory { get; set; }

        public Product(string name, decimal price, int quantity, int sellCount, Category category)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            SellCount = sellCount;
            ProductCategory = category;
        }
    }

}
