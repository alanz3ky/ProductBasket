namespace ProductBasket.Models;


public class Product
{
    /// <summary>
    /// Gets the name of the product.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the weight of the product in kilograms.
    /// </summary>
    public double Weight { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Product"/> class with the specified name and weight.
    /// </summary>
    /// <param name="name">The name of the product.</param>
    /// <param name="weight">The weight of the product in kilograms. Must be greater than zero.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="weight"/> is less than or equal to zero.</exception>
    public Product(string name, double weight)
    {
        if (weight <= 0) throw new ArgumentException("Weight must be positive", nameof(weight));

        Name = name;
        Weight = weight;
    }

   
    public override string ToString() => $"{Name} ({Weight} kg)";
}
