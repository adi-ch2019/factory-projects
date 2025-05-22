# NotificationFactoryReflection System Diagram

## Components

- **ReflectionNotificationFactory** (static class)
  - Method: Create(string type)
  - Uses reflection to find and instantiate INotificationService implementations
- **INotificationService** (interface)
  - Method: Send(string message)
- **EmailNotification** (implements INotificationService)
- **SmsNotification** (implements INotificationService)

## Program Flow

- Program.cs uses ReflectionNotificationFactory to create notification services by type ("email", "sms")
- Calls Send on created services

## Diagram (UML-like)

```
+----------------------------+
| ReflectionNotificationFactory |
+----------------------------+
| +Create(type)               |
+----------------------------+
          |
          v
+---------------------+
| INotificationService |
+---------------------+
          |
  +----------------+  +----------------+
  | EmailNotification|  | SmsNotification |
  +----------------+  +----------------+
