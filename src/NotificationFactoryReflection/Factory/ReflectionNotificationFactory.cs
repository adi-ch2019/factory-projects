using NotificationFactoryReflection.Services;
using System.Reflection;

namespace NotificationFactoryReflection.Factory;

public static class ReflectionNotificationFactory
{
    public static INotificationService Create(string type)
    {
        // Normalize to class name
        string typeName = $"{char.ToUpper(type[0])}{type[1..].ToLower()}Notification";

        var serviceType = Assembly.GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(t =>
                typeof(INotificationService).IsAssignableFrom(t) &&
                !t.IsInterface &&
                !t.IsAbstract &&
                t.Name.Equals(typeName, StringComparison.OrdinalIgnoreCase));

        if (serviceType is null)
            throw new ArgumentException($"Notification type '{type}' is not supported.");

        return (INotificationService)Activator.CreateInstance(serviceType)!;
    }
}
