using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Grotta_Alessandro_CoolShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use an List<Order> to store all orders (type-safe)
            List<Order> orders = new List<Order>();
            string path = "Ordini.csv"; // path of the CSV file

            StreamReader reader = null; // Will be used to read the file

            // Check if the file exists
            if (File.Exists(path))
            {
                // Open the file with StreamReader
                reader = new StreamReader(File.OpenRead(path));

                // Loop through the file until the end
                while (!reader.EndOfStream)
                {
                    // Read a single line from the file
                    var line = reader.ReadLine();

                    // Split line into fields (CSV uses semicolon as delimiter here)
                    var values = line.Split(';');

                    try
                    {
                        // Parse each column into the correct type
                        int id = int.Parse(values[0]);
                        string articleName = values[1];
                        int quantity = int.Parse(values[2]);
                        double price = double.Parse(values[3]);
                        double persentageDiscount = double.Parse(values[4]);
                        string buyer = values[5];

                        // Create an Order object with parsed data
                        Order order = new Order()
                        {
                            Id = id,
                            ArticleName = articleName,
                            Quantity = quantity,
                            Price = price,
                            PercentageDiscount = persentageDiscount,
                            Buyer = buyer
                        };

                        // Add the order to the list
                        orders.Add(order);
                    }
                    catch (Exception ex)
                    {
                        // If parsing fails, show error with the problematic line
                        Console.WriteLine($"Error parsing line: {line}. Exception: {ex.Message}");
                    }
                }
            }
            else
            {
                // If the file is not found
                Console.WriteLine("The file does not exist");
            }

            // if the list is empty, write the error message
            if (!orders.Any())
            {
                Console.WriteLine("No valid orders found in the file.");
                return;
            }

            // Requested outputs:


            // Order with the highest unit price
            var orderWithHighestPrice = orders.OrderByDescending(o => o.Price).First();
            Console.WriteLine($"Order with highest price: {orderWithHighestPrice.ArticleName}, {orderWithHighestPrice.Price}");


            // Order with the highest quantity
            var orderWithHighestQuantity = orders.OrderByDescending(o => o.Quantity).First();
            Console.WriteLine($"The article with the highest quantity is: {orderWithHighestQuantity.ArticleName}, {orderWithHighestQuantity.Quantity}");


            // Total price of all orders without discount
            var totalPrice = orders.Sum(o => o.Price * o.Quantity);
            Console.WriteLine($"The total price of all orders without discount is: {totalPrice}");

            // Total price of all orders with discount
            var totalDiscountedPrice = orders.Sum(o => o.Price * o.Quantity * (1 - o.PercentageDiscount / 100));
            Console.WriteLine($"The total price of all orders with discount is: {totalDiscountedPrice}");
        }
    }
}
