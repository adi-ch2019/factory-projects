using Microsoft.Extensions.DependencyInjection;
using NotificationFactoryDemo.Services;
using NotificationFactoryDemo.Factory;

var services = new ServiceCollection();

// Register notification types
services.AddTransient<EmailNotification>();
services.AddTransient<SmsNotification>();

// Register factory

services.AddSingleton<INotificationFactory, NotificationFactory>();

// Build service provider

var serviceProvider = services.BuildServiceProvider();

// Resolve the factory
var factory = serviceProvider.GetRequiredService<INotificationFactory>();

// Use the factory to create and send messages
var emailService = factory.Create("email");
emailService.Send("Welcome via Email!");

var smsService = factory.Create("sms");
smsService.Send("Welcome via SMS!");
