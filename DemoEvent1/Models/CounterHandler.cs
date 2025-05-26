namespace DemoEvent1.Models;

public class CounterHandler
{

    private Counter _counter;
    private AdvancedCounter _advancedCounter;

    public CounterHandler(int threshold)
    {
        _counter = new Counter(threshold);
        _counter.ThresholdReachedEvent += OnCounterThresholdReached;
        //_counter.ThresholdReachedEvent += delegate ()
        //{
        //    Console.WriteLine($"Counter: Le seuil a été atteint. [lambda]");
        //};

        // Seule la classe déclarant l'événement peut déclencher l'événement
        //_counter.ThresholdReachedEvent?.Invoke();

        _advancedCounter = new AdvancedCounter(threshold);
        _advancedCounter.ThresholdReachedEvent += OnAdvancedCounterThresoldReached;

    }

    public void CounterAddMethod (int value)
    {
        _counter.Add(value);
    }

    public void AdvancedCounterAddMethod (int value)
    {
        _advancedCounter.Add(value);
    }

    public void CounterAddMethod (int value, ValueChanged valueChanged)
    {
        _counter.ThresholdReachedEvent += valueChanged;
        _counter.Add(value);
    }

    private void OnCounterThresholdReached()
    {
        Console.WriteLine($"Counter: Le seuil a été atteint.");
    }

    private void OnAdvancedCounterThresoldReached()
    {
        Console.WriteLine($"AdvancedCounter: Le seuil a été atteint.");
    }

}
