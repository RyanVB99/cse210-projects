using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Provo", "UT", "USA");
        Address address2 = new Address("456 Elm St", "Mexico City", "Mexico", "Mexico");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Laptop", 1, 999.99f, 1);
        Product product2 = new Product("Mouse", 2, 49.99f, 2);
        Product product3 = new Product("Keyboard", 3, 79.99f, 1);
        Product product4 = new Product("Monitor", 4, 199.99f, 1);
        Product product5 = new Product("Printer", 5, 149.99f, 1);
        Product product6 = new Product("Desk Lamp", 6, 29.99f, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Order order3 = new Order(customer2);
        order3.AddProduct(product5);
        order3.AddProduct(product6);

        Order order4 = new Order(customer2);
        order4.AddProduct(product1);
        order4.AddProduct(product3);

        Console.WriteLine("Customer 1 Orders:");
        order1.Display();
        order2.Display();

        Console.WriteLine("Customer 2 Orders:");
        order3.Display();
        order4.Display();
    }
}