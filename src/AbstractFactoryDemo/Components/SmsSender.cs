namespace AbstractFactoryDemo.Components;

public class SmsSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"[SMS] Sending: {message}");
    }
}
