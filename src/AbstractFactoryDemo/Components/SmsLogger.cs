namespace AbstractFactoryDemo.Components;

public class SmsLogger : INotificationLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[SMS] Logged: {message}");
    }
}
