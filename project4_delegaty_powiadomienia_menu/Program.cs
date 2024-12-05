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

        public class PushNotifier
        {
            public void SendPush(string message)
            {
                Console.WriteLine($"Powiadomiene push wysłane: {message}");
            }
        }

        public class NotificationManager
        {
            public NotificationHandler Notify;

            public void AddNotificationMethod(NotificationHandler handler)
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

        public static void ShowMenu()
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Dodaj powiadomienie email");
            Console.WriteLine("2. Dodaj powiadomienie sms");
            Console.WriteLine("3. Dodaj powiadomienie push");
            Console.WriteLine("4. Usuń powiadomienie email");
            Console.WriteLine("5. Usuń powiadomienie sms");
            Console.WriteLine("6. Usuń powiadomienie push");
            Console.WriteLine("7. Wyślij powiadomienia");
            Console.WriteLine("8. Wyjdź");
            Console.Write("\nWybierz opcję: ");
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
                    ShowMenu();
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            notificationManager.AddNotificationMethod(emailNotifier.SendEmail);
                            Console.WriteLine("Doadano powiadomienia email");
                            break;
                        case 2:
                            notificationManager.AddNotificationMethod(smsNotifier.SendSMS);
                            Console.WriteLine("Dodano powiadomienia sms");
                            break;
                        case 3:
                            notificationManager.AddNotificationMethod(pushNotifier.SendPush);
                            Console.WriteLine("Dodano powiadomienia push");
                            break;
                        case 4:
                            notificationManager.RemoveNotificationHandler(emailNotifier.SendEmail);
                            Console.WriteLine("Usunito powiadomienie email");
                            break;
                        case 5:
                            notificationManager.RemoveNotificationHandler(smsNotifier.SendSMS);
                            Console.WriteLine("Usunieto powiadomienia push");
                            break;
                        case 6:
                            notificationManager.RemoveNotificationHandler(pushNotifier.SendPush);
                            Console.WriteLine("Usunieto powiadomienia push");
                            break;
                        case 7:
                            while (true)
                            {
                                Console.Write("Wpisz wiadomosc do wyslania: ");
                                string message = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(message) || message.Length > 20)
                                {
                                    Console.WriteLine("Wiadomosc jest za dluga lub pusta");
                                }
                                else
                                {
                                    notificationManager.SendNotification(message);
                                    break;
                                }
                            }
                            break; 
                        case 8:
                            return;
                        default:
                            Console.WriteLine("nie prawidlowa opcja spprobuj ponowanie");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
