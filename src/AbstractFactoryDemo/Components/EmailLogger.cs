namespace AbstractFactoryDemo.Components;

public class EmailLogger : INotificationLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Email] Logged: {message}");
    }
}
