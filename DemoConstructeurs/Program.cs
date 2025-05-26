using DemoConstructeurs.Models;

Etudiant etudiant1 = new Etudiant(); // Constructeur par défaut
etudiant1.Nom = "Geerts";
etudiant1.Prenom = "Quentin";
etudiant1.DateNaissance = new DateOnly(1996, 4, 3);

Etudiant etudiant2 = new Etudiant() 
{
    Nom = "Geerts",
    Prenom = "Quentin",
    DateNaissance = new DateOnly(1996, 4, 3)
};

Etudiant etudiant3 = new Etudiant("Geerts", "Quentin", new DateOnly(1996, 4, 3));
Etudiant etudiant4 = new Etudiant(dateNaissance: new DateOnly(1996, 4, 3), nom: "Geerts", prenom: "Quentin");

Professeur professeur1 = new Professeur("Geerts", "Quentin", new DateOnly(1996, 4, 3), ["C#", "Angular"]);