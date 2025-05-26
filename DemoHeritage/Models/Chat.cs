namespace DemoHeritage.Models;

internal class Chat : Animal
{
    public Chat(string nom) : base(nom)
    {
    }

    public void Miauler()
    {
        Console.WriteLine("Miaaaaou !");
    }
}
