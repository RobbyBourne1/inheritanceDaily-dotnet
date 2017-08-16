using System; 

namespace inheritanceDaily_dotnet
{
    public abstract class Notification
    {
        public DateTime CreatedAt { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public Notification(string subject, string body)
        {
            Subject = subject;
            Body = body;
            CreatedAt = DateTime.Now;
        }

        public void Transport();
        {
            throws(NoTransportException);
        }
    }
}