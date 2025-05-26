namespace DemoGeneric2.Models;

public class ProductRepository
{
    private readonly List<Product> _products;

    public ProductRepository()
    {
        _products = new List<Product>();
    }

    public void Add(Product product)
    {
        if (product == null) throw new ArgumentNullException("product");
        if (_products.Contains(product)) throw new ArgumentException("Le produit est déjà dans la liste");

        _products.Add(product);
        Console.WriteLine($"Le produit a bien été ajouté.");
    }

    public Product? FindById(Guid id)
    {
        foreach (var product in _products)
        {
            if (product.Id.Equals(id)) return product;
        }

        return null;
    }
}
