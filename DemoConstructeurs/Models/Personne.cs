namespace DemoConstructeurs.Models;

internal class Personne
{
    public Personne(string nom, string prenom, DateOnly dateNaissance)
    {
        Nom = nom;
        Prenom = prenom;
        DateNaissance = dateNaissance;
    }

    ~Personne() 
    {
        Console.WriteLine($"Destruction de l'objet");
    }

    public string Nom { get; set; } = string.Empty;
    public string Prenom { get; set; } = string.Empty;
    public DateOnly DateNaissance { get; set; }
}
