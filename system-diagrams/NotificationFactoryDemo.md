# NotificationFactoryDemo System Diagram

## Components

- **INotificationFactory** (interface)
  - Method: Create(string type)
- **NotificationFactory** (implements INotificationFactory)
  - Uses DI container to create EmailNotification or SmsNotification based on type
- **INotificationService** (interface)
  - Method: Send(string message)
- **EmailNotification** (implements INotificationService)
- **SmsNotification** (implements INotificationService)

## Program Flow

- Program.cs registers services and factory in DI container
- Resolves factory from DI container
- Uses factory to create notification services by type ("email", "sms")
- Calls Send on created services

## Diagram (UML-like)

```
+---------------------+
| INotificationFactory |
+---------------------+
| +Create(type)        |
+---------------------+
          |
          v
+---------------------+
| NotificationFactory  |
+---------------------+
| - IServiceProvider   |
| - Dictionary<string, Type> |
+---------------------+
          |
          v
+---------------------+
| INotificationService |
+---------------------+
          |
  +----------------+  +----------------+
  | EmailNotification|  | SmsNotification |
  +----------------+  +----------------+
