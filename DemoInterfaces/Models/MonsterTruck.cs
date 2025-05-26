using DemoInterfaces.Enums;
using DemoInterfaces.Interfaces;

namespace DemoInterfaces.Models;

internal class MonsterTruck : Voiture, IDrapeau
{
    public MonsterTruck(int puissanceMoteur, TypeCarburant typeCarburant, int nombrePlaces, Drapeau drapeau) : base(puissanceMoteur, typeCarburant, nombrePlaces)
    {
        Drapeau = drapeau;
    }

    public Drapeau Drapeau { get; set; }
}
