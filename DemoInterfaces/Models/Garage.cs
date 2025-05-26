using DemoInterfaces.Interfaces;

namespace DemoInterfaces.Models;

internal class Garage
{
    private readonly List<IMoyenLocomotion> _moyenLocomotion;

    public IVehiculeTerrestre[] VehiculesTerrestres 
    {
        get
        {
            // Inférence de type (C# 9)
            List<IVehiculeTerrestre> vehiculeTerrestres = new();

            foreach (IMoyenLocomotion moyen in _moyenLocomotion)
            {
                if (moyen is IVehiculeTerrestre vt)
                {
                    //vehiculeTerrestres.Add((IVehiculeTerrestre)moyen);
                    vehiculeTerrestres.Add(vt);
                }
            }

            return vehiculeTerrestres.ToArray();
        }
    }

    public IMoyenNonMotorise[] MoyensNonMotorises 
    {
        get
        {
            return _moyenLocomotion.OfType<IMoyenNonMotorise>().ToArray();
        }
    }

    public IVehicule[] Vehicules => _moyenLocomotion.OfType<IVehicule>().ToArray();

    public Garage()
    {
        _moyenLocomotion = new List<IMoyenLocomotion>();
    }

    public void AjouterMoyenLocomotion(IMoyenLocomotion moyen) 
    {
        if (moyen == null) return;
        if (_moyenLocomotion.Contains(moyen)) return;

        _moyenLocomotion.Add(moyen);
    }

    public void AjouterMoyenNonMotorise (IMoyenNonMotorise moyen)
    {
        if (moyen == null) return;
        if (_moyenLocomotion.Contains (moyen)) return;

        _moyenLocomotion.Add(moyen);
    }

}
