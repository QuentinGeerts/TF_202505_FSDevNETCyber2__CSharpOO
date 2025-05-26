namespace DemoGeneric2.Models;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
}
