using System; 

namespace inheritanceDaily_dotnet
{
    public abstract class Notification
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Subject { get; set; }
        public string Body { get; set; }

        public Notification(string subject, string body)
        {
            this.Subject = subject;
            this.Body = body;
        }

        public abstract void Transport();
    }
}