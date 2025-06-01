using System;

class Program
{
    static void Main(string[] args)
    {
        // Order #1 - USA order 
        /* Address object with parameters in the same order as it was created in the Address class */
        Address address1 = new Address("854 Oxford St", "Trenton", "New Jersey", "USA"); /* | Worth to say that the address is without a doubt fictional, I'm not from there */
        /* Customer object with a name and the address */
        Customer customer1 = new Customer("John Jhonson", address1);
        /* Create an object for customer1 */
        Order order1 = new Order(customer1);
        /* Time to add the products with the method .AddProduct() in the same order as it was created in the Product class */
        order1.AddProduct(new Product("Darth Vader Mug", "#05672", 25.0, 1));
        order1.AddProduct(new Product("Star Wars T-shirt", "#8935", 47.9, 2));
        order1.AddProduct(new Product("Marvel Design Sunglasses", "#2345", 25, 2));
        order1.AddProduct(new Product("Hulk Pen", "#7943", 1.5, 10));


        // Order #2 - Non-USA order
        /* Same logic here as I already explained */
        Address address2 = new Address("Av. Miramar", "Arequipa", "Arequipa", "Peru");
        Customer customer2 = new Customer("José Gonzales", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("HDMI Cable", "#7684", 5.0, 5));
        order2.AddProduct(new Product("SSD Card", "#5869", 135.0, 1));
        order2.AddProduct(new Product("Headphones", "#8797", 25.0, 2));
        order2.AddProduct(new Product("Mouse", "#1123", 15.0, 1));

        /* Order 1 output */
        /* And the shipping label with the due method */
        Console.WriteLine(order1.GetShippingLabel() + "\n");
        /* Finally, I print the packing label with the due method */
        Console.WriteLine(order1.GetPackingLabel());
        /* I print the total price by using the due method and add :F2 to format the value two decimal places */
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Total price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine($"\n{new string('=', 40)}\n");
        /* Order 2 output */
        Console.WriteLine(order2.GetShippingLabel() + "\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}