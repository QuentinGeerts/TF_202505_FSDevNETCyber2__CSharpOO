namespace DemoConstructeurs.Models;

internal class Professeur : Personne
{
    private readonly string[] _cours;

    public Professeur(string nom, string prenom, DateOnly dateNaissance, string[] cours) 
        : base(nom, prenom, dateNaissance)
    {
        _cours = cours;
    }


}
