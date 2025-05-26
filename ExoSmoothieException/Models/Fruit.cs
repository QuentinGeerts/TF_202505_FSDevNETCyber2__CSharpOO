using ExoSmoothieException.Enums;

namespace ExoSmoothieException.Models;

public class Fruit
{
    public Fruit(string nom, TypeFruit type)
    {
        Nom = nom;
        Type = type;
    }

    public string Nom { get; set; }
    public TypeFruit Type { get; set; }

    public override string? ToString()
    {
        return $"{Nom} {Type}";
    }
}
