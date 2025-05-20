using AbstractFactoryDemo.Components;

namespace AbstractFactoryDemo.Factories;

public class EmailNotificationFactory : INotificationFactory
{
    public INotificationSender CreateSender() => new EmailSender();
    public INotificationLogger CreateLogger() => new EmailLogger();
}
