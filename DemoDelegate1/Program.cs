using DemoDelegate1.Models;

NotificationService notificationService = new NotificationService();

// Enregistrer les méthodes de notifications
Console.WriteLine("Enregistrer les méthodes de notifications");
notificationService.RegisterNotification(SendEmail);
notificationService.RegisterNotification(SendSMS);
notificationService.RegisterNotification(SendFax);

// Déclencher le système de notification
Console.WriteLine("\n\nDéclencher le système de notification");
notificationService.Notify("Je commence à avoir faim.");

// Désenregistrer les méthodes de notifications
Console.WriteLine("\n\nDésenregistrer les méthodes de notifications");
notificationService.UnregisterNotification(SendEmail);
notificationService.UnregisterNotification(SendSMS);
notificationService.UnregisterNotification(SendFax);

notificationService.RegisterNotification(SendPush);

// Déclencher le système de notification
Console.WriteLine("\n\nDéclencher le système de notification");
notificationService.Notify("Je commence à avoir TRES faim.");

notificationService._notifyDelegate?.Invoke("Coucou"); // Attention déclenchable depuis l'extérieur

static void SendEmail(string message)
{
    Console.WriteLine($"Envoi par Email: {message}");
}

static void SendSMS(string message)
{
    Console.WriteLine($"Envoi par SMS: {message}");
}

static void SendFax(string message)
{
    Console.WriteLine($"Envoi par Fax: {message}");
}

static void SendPush(string message)
{
    Console.WriteLine($"Envoi par Push: {message}");
}