using DemoInterfaces.Enums;
using DemoInterfaces.Interfaces;

namespace DemoInterfaces.Models;

public class Bateau : Vehicule, IVehiculeMaritime
{
    public Bateau(int puissanceMoteur, TypeCarburant typeCarburant, int nombrePlaces) : base(puissanceMoteur, typeCarburant, nombrePlaces)
    {
    }

    public void Naviguer()
    {
        Console.WriteLine($"Le bateau navigue...");
    }
}
