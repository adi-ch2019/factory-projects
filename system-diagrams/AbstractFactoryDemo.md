# AbstractFactoryDemo System Diagram

## Components

- **INotificationFactory** (interface)
  - Methods: CreateSender(), CreateLogger()
- **EmailNotificationFactory** (implements INotificationFactory)
  - Creates EmailSender and EmailLogger
- **SmsNotificationFactory** (implements INotificationFactory)
  - Creates SmsSender and SmsLogger
- **INotificationSender** (interface)
  - Method: Send(string message)
- **INotificationLogger** (interface)
  - Method: Log(string message)
- **EmailSender** (implements INotificationSender)
- **EmailLogger** (implements INotificationLogger)
- **SmsSender** (implements INotificationSender)
- **SmsLogger** (implements INotificationLogger)

## Program Flow

- Program.cs chooses a factory (EmailNotificationFactory or SmsNotificationFactory)
- Factory creates sender and logger
- Sender sends a message
- Logger logs the message

## Diagram (UML-like)

```
+---------------------+          +-------------------------+
| INotificationFactory |<>--------| EmailNotificationFactory |
+---------------------+          +-------------------------+
| +CreateSender()      |          | +CreateSender()          |
| +CreateLogger()      |          | +CreateLogger()          |
+---------------------+          +-------------------------+
          |                               |
          |                               |
          v                               v
+------------------+            +------------------+
| INotificationSender|            | INotificationLogger|
+------------------+            +------------------+
          |                               |
          |                               |
  +---------------+               +---------------+
  | EmailSender   |               | EmailLogger   |
  +---------------+               +---------------+
  | SmsSender     |               | SmsLogger     |
  +---------------+               +---------------+
