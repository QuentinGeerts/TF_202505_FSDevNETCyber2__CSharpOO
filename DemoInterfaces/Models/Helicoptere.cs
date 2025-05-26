using DemoInterfaces.Enums;
using DemoInterfaces.Interfaces;

namespace DemoInterfaces.Models;

internal class Helicoptere : Vehicule, IVehiculeAerien
{
    public Helicoptere(int puissanceMoteur, TypeCarburant typeCarburant, int nombrePlaces) : base(puissanceMoteur, typeCarburant, nombrePlaces)
    {
    }

    public void Voler()
    {
        Console.WriteLine($"L'hélicoptere vole...");
    }
}
