namespace NotificationFactoryDemo.Services;

public class EmailNotification : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"[EMAIL] {message}");
    }
}
