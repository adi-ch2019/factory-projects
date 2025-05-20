using AbstractFactoryDemo.Factories;

// Choose a factory (could be driven by config or input)
INotificationFactory factory = new EmailNotificationFactory();
// INotificationFactory factory = new SmsNotificationFactory();

// Use the factory
var sender = factory.CreateSender();
var logger = factory.CreateLogger();

sender.Send("Welcome to Abstract Factory Pattern");
logger.Log("Notification sent successfully");
