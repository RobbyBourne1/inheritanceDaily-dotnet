using System;

namespace inheritanceDaily_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new EmailNotification("Robby", "Verizon", "Hello World", "Welcome");
            email.Transport();
            var text = new TextNotification("Bob", "AT&T", "Hi", "Welcome to AT&T");
            text.Transport();
        }
    }
}
