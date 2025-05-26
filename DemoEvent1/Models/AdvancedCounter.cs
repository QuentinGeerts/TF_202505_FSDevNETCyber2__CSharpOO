namespace DemoEvent1.Models;

internal class AdvancedCounter : Counter
{
    public AdvancedCounter(int threshold) : base(threshold)
    {
    }

    protected override void OnThresholdReached()
    {
        // Autres fonctionnalités supplémentaires
        Console.WriteLine("Déclenchement d'autres fonctionnalités...");

        base.OnThresholdReached();
    }
}
