namespace Interfaces
{
    public interface IMessage
    {
        string Msg { get; set; }
        bool SendMessage(string msg);
    }

    public interface ISMSMessage : IMessage
    {
        string PhoneNumber { get; set; }
    }

    public interface IEmailMessage : IMessage
    {
        string ToAddress { get; set; }
    }

    public interface INotificationService
    {
        bool SendEmail(string toAddress, string message);
        bool SendSMS(string phoneNumber, string message);
    }
}
