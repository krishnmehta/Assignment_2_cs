using System;
using System.Security.Principal;
using System.Text;
using System.Collections.Generic;


namespace Assignment2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            // Adding products in the list
            products.Add(new Product("lettuce", 10.5, 50, "Leafy green"));
            products.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            products.Add(new Product("pumpkin", 30, 30, "Marrow"));
            products.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
            products.Add(new Product("zucchini", 20.5, 50, "Marrow"));
            products.Add(new Product("yam", 30, 50, "Root"));
            products.Add(new Product("spinach", 10, 100, "Leafy green"));
            products.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            products.Add(new Product("garlic", 30, 20, "Leafy green"));
            products.Add(new Product("silverbeet", 10, 50, "Marrow"));

            // Print total number of products
            Console.WriteLine("Total number of products: " + products.Count + "\n");
            
            // Add new product and print updated list and total number of products
            products.Add(new Product("Potato", 10, 50, "Root"));
            Console.WriteLine("Below is the list of Products: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
            }

            //Print all the products of which have the type Leafy green.
            Console.WriteLine("\nAll Leafy green products are: ");
            foreach (Product product in products)
            {
                if (product.Type == "Leafy green")
                {
                    Console.WriteLine(product.ToString());
                }
            }
            /*As all the garlic is sold out, Remove Garlic from the list
            and print the total number of products that are left on the list.*/
            products.Remove(products.Find(p => p.Name == "garlic"));
            Console.WriteLine("\nTotal number of products after garlic is sold out is: " + products.Count);

            //If the user adds 50 cabbages to the inventory, print the final quantity of cabbage in the inventory.
            Product cabbage = products.Find(p => p.Name == "cabbage");
            cabbage.Quantity += 50;
            Console.WriteLine("Final quantity of cabbage in the inventory is: " + cabbage.Quantity);

            //If a user purchases 1kg lettuce, 2 kg zucchini, 1 kg broccoli the what is the round figure that the user needs to pay?
            double lettuce_price = products.Find(p => p.Name == "lettuce").Price;
            double zucchini_price = products.Find(p => p.Name == "zucchini").Price;
            double broccoli_price = products.Find(p => p.Name == "broccoli").Price;

            double total_price = lettuce_price + (2 * zucchini_price) + broccoli_price;
            Console.WriteLine($"User needs to pay {Math.Round(total_price)} Rs");
        }

    }
}