namespace DemoEvent1.Models;

// Définition du délégué pour typer l'événement
public delegate void ValueChanged();

public class Counter
{

    private int _counter;
    private int _threshold;

    public event ValueChanged ThresholdReachedEvent;

    public Counter(int threshold)
    {
        _threshold = threshold;
    }


    public void Add (int value)
    {
        _counter += value;
        Console.WriteLine($"La valeur du compteur vaut: {_counter}");

        // Déclenchement de l'événement lorsqu'un le compteur atteint le seuil
        if (_counter >= _threshold)
        {
            OnThresholdReached();
        }
    }

    protected virtual void OnThresholdReached ()
    {
        ThresholdReachedEvent?.Invoke();
    }
}
