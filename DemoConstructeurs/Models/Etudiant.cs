namespace DemoConstructeurs.Models;

internal class Etudiant : Personne
{

    private readonly List<double> notes;

    // Constructeur vide => Remplace le constructeur par défaut
    public Etudiant() : this("Anonyme", "Anonyme", new DateOnly(0001, 1, 1))
    {
        // notes = new List<double>();
    }

    public Etudiant(string nom, string prenom, DateOnly dateNaissance)
        : base(nom, prenom, dateNaissance)
    {
        //Nom = nom;
        //Prenom = prenom;
        //DateNaissance = dateNaissance;
        notes = new List<double>();
    }

    

}
