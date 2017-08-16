using System;

namespace inheritanceDaily_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new EmailNotification("Robby", "Verizon", "Hello World", "Welcome");
            Console.WriteLine(email);
            var text = new TextNotification("Bob", "Verizon", "Hi", "Welcome to Verizon");
            Console.WriteLine(text);
        }
    }
}
