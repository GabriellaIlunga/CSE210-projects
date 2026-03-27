using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address addr1 = new Address("123 Maple St", "Johannesburg", "CA", "USA"); 
        Customer cust1 = new Customer("Alice Smith", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop Sleeve", "LS101", 25.00, 1));
        order1.AddProduct(new Product("Wireless Mouse", "WM202", 15.50, 2));

        Address addr2 = new Address("456 Rose Road", "Johannesburg", "Gauteng", "South Africa");
        Customer cust2 = new Customer("Gabriella Ilunga", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Mechanical Keyboard", "MK500", 85.00, 1));
        order2.AddProduct(new Product("USB-C Cable", "UC01", 10.00, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotal());
        Console.WriteLine("------------------------------");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotal());
        Console.WriteLine("------------------------------");
    }
}