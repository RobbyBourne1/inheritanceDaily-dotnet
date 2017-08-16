using System; 

namespace inheritanceDaily_dotnet
{
    public class EmailNotification :Notification
    {
        public string Recipient { get; set; }
        public string SmtpProvider { get; set; }

        public EmailNotification(string recipient, string provider, string body, string subject):base(body,subject)
        {
            Recipient = recipient;
            SmtpProvider = provider;
        }

        public override void Transport()
        {
            Console.WriteLine($"{Recipient},{SmtpProvider}");

        }
    }
}