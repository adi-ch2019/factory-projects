using Interfaces;

namespace Services
{
    public class SMSMessage : ISMSMessage
    {
        public string PhoneNumber { get; set; }
        public string Msg { get; set; }

        public bool SendMessage(string msg)
        {
            // SMS operation DoWork()
            // For demonstration, just return true
            return true;
        }
    }

    public class EmailMessage : IEmailMessage
    {
        public string ToAddress { get; set; }
        public string Msg { get; set; }

        public bool SendMessage(string msg)
        {
            // Email operation DoWork()
            // For demonstration, just return true
            return true;
        }
    }

    public class NotificationService : INotificationService
    {
        private readonly ISMSMessage _smsMessage;
        private readonly IEmailMessage _emailMessage;

        public NotificationService(ISMSMessage smsMessage, IEmailMessage emailMessage)
        {
            _smsMessage = smsMessage;
            _emailMessage = emailMessage;
        }

        public bool SendEmail(string toAddress, string message)
        {
            _emailMessage.ToAddress = toAddress;
            _emailMessage.Msg = message;
            return _emailMessage.SendMessage(message);
        }

        public bool SendSMS(string phoneNumber, string message)
        {
            _smsMessage.PhoneNumber = phoneNumber;
            _smsMessage.Msg = message;
            return _smsMessage.SendMessage(message);
        }
    }
}
