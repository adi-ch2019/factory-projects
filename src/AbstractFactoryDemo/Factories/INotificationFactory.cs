namespace AbstractFactoryDemo.Factories;

public interface INotificationFactory
{
    INotificationSender CreateSender();
    INotificationLogger CreateLogger();
}
