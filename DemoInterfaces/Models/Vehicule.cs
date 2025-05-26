using DemoInterfaces.Enums;
using DemoInterfaces.Interfaces;

namespace DemoInterfaces.Models;

public abstract class Vehicule : IVehicule
{
    protected Vehicule(int puissanceMoteur, TypeCarburant typeCarburant, int nombrePlaces)
    {
        PuissanceMoteur = puissanceMoteur;
        TypeCarburant = typeCarburant;
        NombrePlaces = nombrePlaces;
    }

    public int PuissanceMoteur { get; set; }
    public TypeCarburant TypeCarburant { get; set; }
    public int NombrePlaces { get; init; }

    public virtual void Demarrer()
    {
        Console.WriteLine($"Le véhicule démarre...");
    }

    public virtual void Arreter()
    {
        Console.WriteLine($"Le véhicule s'arrête...");
    }
}
