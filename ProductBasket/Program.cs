using System;
using System.Collections.Generic;
using ProductBasket.Models;
using ProductBasket.Services;

namespace ProductBasket
{
  
    class Program
    {
        
        static void Main(string[] args)
        {
            var shoppingList = new List<Product>
            {
                new Product("Grilled Meat", 3.0),
                new Product("Sausages", 1.2),
                new Product("Burger Buns", 0.8),
                new Product("Melted Cheese", 0.5),
                new Product("Beer", 2.0),
                new Product("Soft Drinks", 1.5),
                new Product("Potato Chips", 0.7),
                new Product("Sauces", 0.6),
                new Product("Charcoal", 4.0),
                new Product("Bread", 0.5),
                new Product("Chicken Wings", 2.0),
                new Product("Vegetable Skewers", 1.2)
            };

            double maxBasketWeight = 20.0;

            var basket = ProductsBasket.PutHeaviestFirst(shoppingList, maxBasketWeight);

            PrintBasket(basket, maxBasketWeight);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prints the selected products in the basket and their total weight.
        /// </summary>
        /// <param name="basket">The list of selected products.</param>
        /// <param name="maxWeight">The maximum allowed weight for the basket.</param>
        static void PrintBasket(List<Product> basket, double maxWeight)
        {
            Console.WriteLine("Selected products for the basket:");
            double total = 0;

            foreach (var item in basket)
            {
                Console.WriteLine($"- {item.Name} ({item.Weight} kg)");
                total += item.Weight;
            }

            Console.WriteLine($"Total Weight: {total} kg (max allowed: {maxWeight} kg)");
        }
    }
}
