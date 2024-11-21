using System;
using ElectronicaProduct1.Enums;
using ElectronicaProduct1;

class Program
{
    static void Main(string[] args)
    {
       
        var productController = new ProductController();
        var customerController = new CustomerController();
        var orderController = new OrderController();

      
        var laptop = new Product("Gaming Laptop", 1500m, 10, 0, Category.Laptop);
        var smartphone = new Product("Smartphone", 800m, 20, 0, Category.Smartphone);
        var tablet = new Product("Tablet", 500m, 15, 0, Category.Tablet);

        productController.AddProduct(laptop);
        productController.AddProduct(smartphone);
        productController.AddProduct(tablet);

        var customer1 = new Customer("Esma", "Uddin", "esma@gmail.com", "esma1234");       
        var customer = new Customer("mirvari", "muradli", "mirvarimuradli@gmail.com", "password");
        customerController.AddCustomer(customer);

       
        customer.AddToCart(laptop);
        customer.AddToCart(smartphone);


        var order1 = new Order(DateTime.Now, customer, laptop, 1);
        var order2 = new Order(DateTime.Now, customer, smartphone, 2);

        orderController.AddOrder(order1);
        orderController.AddOrder(order2);

        
        Console.WriteLine("Orders:");
        foreach (var order in orderController.Orders)
        {
            Console.WriteLine($"Date: {order.Date}, Customer: {order.Customer.Name}, Product: {order.Product.Name},   Quantity: {order.Quantity}");
        }
    }
}
