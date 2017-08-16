using System; 

namespace inheritanceDaily_dotnet
{
    public class TextNotification : Notification
    {
        public string Recipient { get; set; }
        public string SmsProvider { get; set; }

        public TextNotification(string recipient, string smsprovider, string subject, string body):base(body, subject)
        {
            Recipient = recipient;
            SmsProvider = smsprovider;
        }

        public void Transport()
        {
            Console.WriteLine(Recipient, SmsProvider);
        }
    }
}