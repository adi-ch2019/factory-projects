namespace NotificationFactoryDemo.Factory;
using Microsoft.Extensions.DependencyInjection;

using NotificationFactoryDemo.Services;

public class NotificationFactory : INotificationFactory
{
    private readonly IServiceProvider _serviceProvider;
    private readonly Dictionary<string, Type> _mappings = new()
    {
        { "email", typeof(EmailNotification) },
        { "sms", typeof(SmsNotification) }
    };

    public NotificationFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public INotificationService Create(string type)
    {
        if (_mappings.TryGetValue(type.ToLower(), out var implType))
        {
            return (INotificationService)_serviceProvider.GetRequiredService(implType);
        }

        throw new ArgumentException($"Notification type '{type}' not found.");
    }
}
