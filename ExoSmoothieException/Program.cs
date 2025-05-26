/*
 * 
 * Créer un programme qui permet de simuler une machine à smoothies.
 * Le client peut ajouter des fruits, lancer le mixeur et boire le smoothie.
 * Mais attention:
 * - Certains fruits sont interdis dans la machine (Système jette une exception)
 * - Le mixeur ne peut pas être lancé s'il n'y a aucun fruit (custom exception)
 * - Si le client essaie de boire le smoothie avant de mixer, catastrophe ! (custom exception)
 * - Si on essaye d'ajouter un fruit "null" ou vide, il y a une exception système (ArgumentException)
 * 
 */

using ExoSmoothieException.Models;
using ExoSmoothieException.Enums;

Mixeur mixeur = new Mixeur();

// 1. Ajouter les fruits au mixeur

try
{
    mixeur.AjouterFruit(new Fruit("Pomme rouge", TypeFruit.Pomme));
    mixeur.AjouterFruit(new Fruit("Banane", TypeFruit.Banane));
    mixeur.AjouterFruit(new Fruit("Fraise", TypeFruit.Fraise));
    mixeur.AjouterFruit(new Fruit("Litchi", TypeFruit.Litchi));
}
catch (Exception e)
{
    Console.WriteLine($"Erreur: {e.Message}");
}

// 2. Mixer les fruits et boire le smoothie

try
{
    mixeur.Mixer();
    mixeur.BoireSmoothie();
}
catch (Exception e)
{
    Console.WriteLine($"Erreur: {e.Message}");
}

// Ajouter des fruits incorrects
try
{
    mixeur.AjouterFruit(new Fruit("", TypeFruit.Pomme));
}
catch (Exception e)
{
    Console.WriteLine($"Erreur lors de l'ajout d'un fruit: {e.Message}");
}

try
{
    mixeur.AjouterFruit(null);
}
catch (Exception e)
{
    Console.WriteLine($"Erreur lors de l'ajout d'un fruit: {e.Message}");
}

// Mixer sans ajouter de fruits

try
{
    mixeur.Mixer();
}
catch (Exception e)
{
    Console.WriteLine($"Erreur lors du mix sans fruit: {e.Message}");
}

// Boire sans avoir mixé

try
{
    mixeur.BoireSmoothie();
}
catch (Exception e)
{
    Console.WriteLine($"Erreur lors du brevage: {e.Message}");
}
