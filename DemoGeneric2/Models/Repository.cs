using DemoGeneric2.Interfaces;

namespace DemoGeneric2.Models;


// where T : BaseEntity => Le type T doit être un enfant de la classe BaseEntity
// where T : IBaseEntity => Le type T doit implémenter l'interface IBase Entity
// where T : new() => Le type T doit posséder un constructeur vide
public class Repository<T>
    where T : BaseEntity, IBaseEntity, new()
{
    private readonly List<T> _values = new(); // A partir de C# 9: inférence de type

    public void Add(T value)
    {
        if (value == null) throw new ArgumentNullException("product");
        if (_values.Contains(value)) throw new ArgumentException($"Le {value.GetType().Name} est déjà dans la liste");

        _values.Add(value);
        Console.WriteLine($"Le produit a bien été ajouté.");
    }

    public T? Find<U>(U searchValue) where U : struct
    {
        if (typeof (U) == typeof (Guid))
        {
            foreach (var value in _values)
            {
                if (value.Id.Equals(searchValue)) return value;
            }

        }

        if (typeof (U) == typeof (int))
        {
            try
            {
                int index = Convert.ToInt32(searchValue);
                return (T?) _values[index];
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        return null;
    }

}
