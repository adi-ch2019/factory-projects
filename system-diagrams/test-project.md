# test-project System Diagram

## Components

- **IMessage** (interface)
  - Properties: string Msg { get; set; }
  - Method: bool SendMessage(string msg)
- **ISMSMessage** (interface, extends IMessage)
  - Property: string PhoneNumber { get; set; }
- **IEmailMessage** (interface, extends IMessage)
  - Property: string ToAddress { get; set; }
- **INotificationService** (interface)
  - Methods: bool SendEmail(string toAddress, string message), bool SendSMS(string phoneNumber, string message)
- **SMSMessage** (implements ISMSMessage)
- **EmailMessage** (implements IEmailMessage)
- **NotificationService** (implements INotificationService)
  - Uses ISMSMessage and IEmailMessage to send messages

## Program Flow

- Program.cs sets up ASP.NET Core web app with controllers and Swagger
- Registers ISMSMessage, IEmailMessage, and INotificationService implementations
- Runs the web app

## Diagram (UML-like)

```
+-------------+       +-------------+       +-------------------+
| ISMSMessage |       | IEmailMessage|       | INotificationService|
+-------------+       +-------------+       +-------------------+
| PhoneNumber |       | ToAddress   |       | +SendEmail()       |
| Msg         |       | Msg         |       | +SendSMS()         |
| +SendMessage()|      | +SendMessage()|      +-------------------+
+-------------+       +-------------+       | - SMSMessage       |
       |                     |              | - EmailMessage     |
       |                     |              +-------------------+
       |                     |                      ^
       |                     |                      |
+-------------+       +-------------+               |
| SMSMessage  |       | EmailMessage|               |
+-------------+       +-------------+               |
                                              +-------------------+
                                              | NotificationService|
                                              +-------------------+
                                              | - ISMSMessage      |
                                              | - IEmailMessage    |
                                              +-------------------+
