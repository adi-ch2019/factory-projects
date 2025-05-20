using AbstractFactoryDemo.Components;

namespace AbstractFactoryDemo.Factories;

public class SmsNotificationFactory : INotificationFactory
{
    public INotificationSender CreateSender() => new SmsSender();
    public INotificationLogger CreateLogger() => new SmsLogger();
}
