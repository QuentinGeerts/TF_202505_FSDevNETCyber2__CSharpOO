using DemoEvent2.Enums;
using DemoEvent2.Handlers;

namespace DemoEvent2.Models;

public abstract class Button
{

    // Déclaration de l'événément sur base de EventHandler
    public event EventHandler ClickEvent;

    public abstract void Click();

    protected virtual void OnButtonClicked (ButtonTypes buttonsTypes, string message)
    {
        ClickEvent?.Invoke(this, new ButtonEventArgs(buttonsTypes, message));
    }

}
