using NotificationFactoryReflection.Factory;
using NotificationFactoryReflection.Services;

var email = ReflectionNotificationFactory.Create("email");
email.Send("Hello via Email!");

var sms = ReflectionNotificationFactory.Create("sms");
sms.Send("Hello via SMS!");

// Uncomment below to test failure case
// var push = ReflectionNotificationFactory.Create("push");
