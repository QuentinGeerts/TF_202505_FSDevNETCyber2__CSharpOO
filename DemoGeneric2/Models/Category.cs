namespace DemoGeneric2.Models;

public enum CategoryTypes
{
    Nourriture,
    Informatique
}

public class Category : BaseEntity
{
    public CategoryTypes CategoryType { get; set; }

    public Category(CategoryTypes categoryTypes)
    {
        CategoryType = categoryTypes;
    }

    public Category()
    {
        
    }
}
