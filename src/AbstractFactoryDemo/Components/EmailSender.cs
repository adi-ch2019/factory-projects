namespace AbstractFactoryDemo.Components;

public class EmailSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"[Email] Sending: {message}");
    }
}
