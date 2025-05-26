using DemoInterfaces.Interfaces;

namespace DemoInterfaces.Models;

internal class Trottinette : IMoyenNonMotorise
{
    public Trottinette(int nombrePlaces)
    {
        NombrePlaces = nombrePlaces;
    }

    public int NombrePlaces { get; init; }
}
