namespace DemoStatic.Models;

public class MaClasse
{

    // Propriété d'instance = Lié à l'instance
    public int ProprieteInstance { get; set; }

    // Propriété de classe = Lié à la classe
    public static int ProprieteClasse { get; set; } = 100;


    // Uniquement disponible sur une instance
    public void MethodeInstance ()
    {
        if (ProprieteClasse == 100) ProprieteClasse = 99;
        Console.WriteLine($"Propriété instance: {ProprieteInstance}");
        Console.WriteLine($"Propriété classe: {ProprieteClasse}");
    }

    // Uniquement disponible sur une classe
    public static int MethodeClasse ()
    {
        return ProprieteClasse;
    }

}
