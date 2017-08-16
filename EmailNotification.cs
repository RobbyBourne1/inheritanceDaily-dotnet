using System; 

namespace inheritanceDaily_dotnet
{
    public class EmailNotification :Notification
    {
        public string Recipient { get; set; }
        public string SmtpProvider { get; set; }

        public EmailNotification(string recipient, string smtpprovider, string body, string subject):base(body,subject)
        {
            Recipient = recipient;
            SmtpProvider = smtpprovider;
        }

        public override void Transport()
        {
            Console.WriteLine($"You recieved a message from {Recipient} on a {SmtpProvider} line. Subject is: {Subject} and message is: {Body}");

        }
    }
}