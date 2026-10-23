
using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ten san pham {i + 1}: ");
            string name = Console.ReadLine()!;

            Console.Write("Gia san pham: ");
            double price = double.Parse(Console.ReadLine()!);

            Product p = new Product
            {
                Name = name,
                Price = price
            };

            products.Add(p);
        }

        Console.WriteLine("\nDanh sach san pham:");

        foreach (Product p in products)
        {
            Console.WriteLine($"{p.Name} - {p.Price:N0} VND");
        }
    }
}
