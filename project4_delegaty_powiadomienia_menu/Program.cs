namespace project4_delegaty_powiadomienia
{
    internal class Program
    {
        public delegate void NotificationHandler(string message);
        public class EmailNotifier
        {
            public void SendEmail(string message)
            {
                Console.WriteLine($"Email wysłany: {message}");
            }
        }
        public class SMSNotifier
        {
            public void SendSMS(string message)
            {
                Console.WriteLine($"SMS wysłany: {message}");
            }
        }

        public class NotificationManager
        {
            public NotificationHandler Notify;
            public void AddNotificationHandler(NotificationHandler handler)
            {
                Notify += handler;
            }
            public void RemoveNotificationHandler(NotificationHandler handler)
            {
                Notify -= handler;
            }
            public void SendNotification(string message)
            {
                Notify?.Invoke(message);
            }
        }

        public class PushNotifier
        {
            public void SendPush(string message)
            {
                Console.WriteLine($"Powiadomienie push wysłane: {message}");
            }
        }
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Dodaj powiadomienie email");
            Console.WriteLine("2. Dodaj powiadomienie sms");
            Console.WriteLine("3. Dodaj powiadomienie push");
            Console.WriteLine("4. Usuń powiadomienie email");
            Console.WriteLine("5. Usuń powiadomienie sms");
            Console.WriteLine("6. Usuń powiadomienie push");
            Console.WriteLine("7. Wyślij powiadomienia");
            Console.WriteLine("8. Wyjście");
            //int choice = ValidIntInput("Wybierz opcje");
        }
        static void Main(string[] args)
        {
            var emailNotifier = new EmailNotifier();
            var smsNotifier = new SMSNotifier();
            var pushNotifier = new PushNotifier();

            var notificationManager = new NotificationManager();

            while (true)
            {
                try
                {

                }
                catch
                {

                }
            }

        }
    }
}
