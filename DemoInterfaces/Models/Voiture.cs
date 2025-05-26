using DemoInterfaces.Enums;
using DemoInterfaces.Interfaces;

namespace DemoInterfaces.Models;

internal class Voiture : Vehicule, IVehiculeTerrestre
{
    public Voiture(int puissanceMoteur, TypeCarburant typeCarburant, int nombrePlaces) : base(puissanceMoteur, typeCarburant, nombrePlaces)
    {
    }

    public virtual void Rouler()
    {
        Console.WriteLine($"La voiture roule...");
    }

    public override void Demarrer()
    {
        Console.WriteLine($"La voiture démarre...");
    }

    public override void Arreter()
    {
        Console.WriteLine($"La voiture s'arrête...");
    }
}
