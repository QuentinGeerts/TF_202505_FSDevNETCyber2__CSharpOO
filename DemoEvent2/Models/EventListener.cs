using DemoEvent2.Enums;
using DemoEvent2.Handlers;

namespace DemoEvent2.Models;

public class EventListener
{

    public void Subscribe (Button button)
    {
        button.ClickEvent += (sender, eventArgs) =>
        {
            Console.WriteLine($"Récupération de l'événement: {sender.GetType().Name}");
            if (eventArgs is ButtonEventArgs buttonEventArgs)
            {
                switch (buttonEventArgs.ButtonType)
                {
                    case ButtonTypes.Left:
                        // Action sur le bouton Gauche
                        Console.WriteLine($"Clic gauche intercepté. Message récupéré: {buttonEventArgs.Message}");
                        break;

                    case ButtonTypes.Right:
                        // Action sur le bouton Droit
                        Console.WriteLine($"Clic droit intercepté. Message récupéré: {buttonEventArgs.Message}");

                        break;
                }
            }
        };
    }

}
