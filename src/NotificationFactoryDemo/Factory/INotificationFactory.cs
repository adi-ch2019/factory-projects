namespace NotificationFactoryDemo.Factory;

using NotificationFactoryDemo.Services;

public interface INotificationFactory
{
    INotificationService Create(string type);
}
