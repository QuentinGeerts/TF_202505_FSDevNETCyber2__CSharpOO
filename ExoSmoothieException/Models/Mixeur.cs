using ExoSmoothieException.Enums;
using ExoSmoothieException.Exceptions;

namespace ExoSmoothieException.Models;

public class Mixeur
{
    private List<Fruit> fruits;
    private HashSet<TypeFruit> fruitsInterdits;
    private bool estMixe;

    public Mixeur()
    {
        fruits = new List<Fruit>();

        // Définir les fruits interdits
        // Collection de valeurs uniques
        fruitsInterdits = new HashSet<TypeFruit>
        {
            TypeFruit.Noix,
            TypeFruit.Tomate,
            TypeFruit.Durian,
        };
    }

    public void AjouterFruit(Fruit fruit)
    {
        // Vérifier ce qui pourrait poser problème
        if (fruit is null)
            throw new ArgumentNullException("Le fruit ne peut pas être null.");

        if (string.IsNullOrWhiteSpace(fruit.Nom))
            throw new ArgumentException("Le fruit ne peut pas être vide.");

        if (fruitsInterdits.Contains(fruit.Type))
                    throw new Exception("Le fruit est interdit.");

        fruits.Add(fruit);

        Console.WriteLine($"Le fruit ({fruit}) a bien été ajouté.");
    }

    public void Mixer()
    {
        if (fruits.Count == 0)
            throw new MixeurVideException();

        Console.WriteLine($"Mixage en cours...");
        Thread.Sleep(2000);
        estMixe = true;
        Console.WriteLine($"Mixage terminé, votre smoothie est prêt (mmmmh).");
    }

    public void BoireSmoothie()
    {
        if (!estMixe)
            throw new SmoothieNonMixeException();

        Console.WriteLine($"Ton smoothie est terminé, bonne dégustation !");
        fruits.Clear();
        estMixe = false;
    }
}
