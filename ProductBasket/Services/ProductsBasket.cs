using ProductBasket.Models;

namespace ProductBasket.Services;

    public class ProductsBasket
    {
    /// <summary>
    /// Selects the heaviest products first, without exceeding the specified maximum weight.
    /// </summary>
    /// <param name="shoppingList">The list of products to choose from.</param>
    /// <param name="maxWeight">The maximum total weight allowed for the basket is 20Kg.</param>
    /// <returns>A list of products whose total weight is less than or equal to the maxWeight.</returns>
    public static List<Product> PutHeaviestFirst(List<Product> shoppingList, double maxWeight)
        {
            var sortedList = shoppingList
                .OrderByDescending(product => product.Weight)
                .ToList();

            var basket = new List<Product>();
            double currentWeight = 0;

            foreach (var product in sortedList)
            {
                if (currentWeight + product.Weight <= maxWeight)
                {
                    basket.Add(product);
                    currentWeight += product.Weight;
                }
            }

            return basket;
        }
    }

