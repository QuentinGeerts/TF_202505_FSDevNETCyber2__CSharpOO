using DemoInterfaces.Enums;
using DemoInterfaces.Models;

Bateau bateau = new Bateau(200, TypeCarburant.Electrique, 10);
bateau.Demarrer();
bateau.Naviguer();
bateau.Arreter();

Helicoptere helicoptere = new Helicoptere(300, TypeCarburant.Electrique, 4);
helicoptere.Demarrer();
helicoptere.Voler();
helicoptere.Arreter();

MonsterTruck monsterTruck = new MonsterTruck(250, TypeCarburant.Essence, 2, Drapeau.Belgique);
monsterTruck.Demarrer();
monsterTruck.Rouler();
monsterTruck.Arreter();

Trottinette trottinette = new Trottinette(1);

Voiture voiture = new Voiture(110, TypeCarburant.Diesel, 5);
voiture.Demarrer();
voiture.Rouler();
voiture.Arreter();

VoitureAmphibie voitureAmphibie = new VoitureAmphibie(140, TypeCarburant.Essence, 7);
voitureAmphibie.Demarrer();
voitureAmphibie.Rouler();
voitureAmphibie.Naviguer();
voitureAmphibie.Arreter();


Vehicule vehicule = new Bateau(200, TypeCarburant.Essence, 3);
Bateau bateau2 = (Bateau)vehicule;

Garage garage = new Garage();

garage.AjouterMoyenLocomotion(trottinette);
garage.AjouterMoyenLocomotion(monsterTruck);
garage.AjouterMoyenLocomotion(bateau);
garage.AjouterMoyenLocomotion(voiture);
garage.AjouterMoyenLocomotion(voitureAmphibie);
garage.AjouterMoyenLocomotion(helicoptere);

garage.AjouterMoyenNonMotorise(trottinette);
//garage.AjouterMoyenNonMotorise(voiture); // Ne fonctionne pas

Console.WriteLine("Liste des véhicules:");
foreach (var v in garage.Vehicules)
{
    Console.WriteLine($" - {v}");
}

Console.WriteLine("Liste des véhicules terrestres: ");
foreach (var v in garage.VehiculesTerrestres)
{
    Console.WriteLine($" - {v}");
}