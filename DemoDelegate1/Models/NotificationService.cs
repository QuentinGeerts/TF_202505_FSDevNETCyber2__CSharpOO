namespace DemoDelegate1.Models;

// Définition du délégué pour les méthodes de notification
// Toutes les méthodes ne retourneront pas de valeur et prendront un paramètre string
public delegate void NotifyDelegate (string message);

public class NotificationService
{

    // Déclaration de la variable du type du délégué
    public NotifyDelegate _notifyDelegate;

    // Méthode pour enregistrer la méthode de nofication
    public void RegisterNotification (NotifyDelegate notifyDelegate)
    {
        _notifyDelegate += notifyDelegate;
    }

    // Méthode pour désenregistrer la méthode de notification
    public void UnregisterNotification(NotifyDelegate notifyDelegate)
    {
        if (_notifyDelegate != null)
            _notifyDelegate -= notifyDelegate;
    }

    // Méthide pour déclencher un délégué
    public void Notify (string message)
    {
        // 1ère façon
        if (_notifyDelegate != null) _notifyDelegate(message);

        // 2ème façon
        //if (_notifyDelegate != null) _notifyDelegate.Invoke(message);

        // 3ème façon
        //_notifyDelegate?.Invoke(message);
    }


}
