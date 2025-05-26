using DemoInterfaces.Enums;
using DemoInterfaces.Interfaces;

namespace DemoInterfaces.Models;

internal class VoitureAmphibie : Voiture, IVehiculeMaritime
{
    public VoitureAmphibie(int puissanceMoteur, TypeCarburant typeCarburant, int nombrePlaces) : base(puissanceMoteur, typeCarburant, nombrePlaces)
    {
    }

    public override void Rouler()
    {
        Console.WriteLine($"La voiture amphibie roule...");
    }

    public void Naviguer()
    {
        Console.WriteLine($"La voiture amphibie navigue...");
    }
}
