using System;

namespace _4_2_1_delegaty_powiadomienia_menu
{
    class Program
    {
        public delegate void Notificationhandler(string message);

        public interface INotifier
        {
            void Notify(string message);
        }
        public class EmailNotifier : INotifier
        {
            public void Notify(string message)
            {
                try
                {
                    Console.WriteLine("Email wyslany");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Blad: " + ex.Message);
                }
            }
            
        }

        public class SMSNotifier : INotifier
        {
            public void Notify(string message)
            {
                try
                {
                    Console.WriteLine("SMS wyslany");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Blad: " + ex.Message);
                }
            }
        }
        public class PushNotifier
        {
            public void Notify(string message)
            {
                try
                {
                    Console.WriteLine("Powiadomienie push wyslane");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Blad: " + ex.Message);
                }
            }
        }

        public class NotificationManager
        {
            public Notificationhandler Notify;

            public void AddNotificationMethod(Notificationhandler handler)
            {
                if(Notify == null)
                {

                }
            }

            public void RemoveNotificationMethod(Notificationhandler handler)
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
            Console.WriteLine("Menu");
            Console.WriteLine("1. Dodaj powiadomienie Email");
            Console.WriteLine("2. Dodaj powiadomienie SMS");
            Console.WriteLine("3. Dodaj powiadomienie Push");
            Console.WriteLine("4. Usuń powiadomienie Email");
            Console.WriteLine("5. Usuń powiadomienie SMS");
            Console.WriteLine("6. Usuń powiadomienie Push");
            Console.WriteLine("7. Wyślij powiadomienia");
            Console.WriteLine("8. Wyjdź");
            Console.Write("Wybierz opcję: ");
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
                    var choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            notificationManager.AddNotificationMethod(emailNotifier.Notify);
                            Console.WriteLine("Dodano powiadomienie Email\n");
                            break;
                        case 2:
                            notificationManager.AddNotificationMethod(smsNotifier.Notify);
                            Console.WriteLine("Dodano powiadomienie SMS\n");
                            break;
                        case 3:
                            notificationManager.AddNotificationMethod(pushNotifier.Notify);
                            Console.WriteLine("Dodano powiadomienie Push\n");
                            break;
                        case 4:
                            notificationManager.RemoveNotificationMethod(emailNotifier.Notify);
                            Console.WriteLine("Usunięto powiadomienie Email\n");
                            break;
                        case 5:
                            notificationManager.RemoveNotificationMethod(smsNotifier.Notify);
                            Console.WriteLine("Usunięto powiadomienie SMS\n");
                            break;
                        case 6:
                            notificationManager.RemoveNotificationMethod(pushNotifier.Notify);
                            Console.WriteLine("Usunięto powiadomienie Push\n");
                            break;
                        case 7:
                            Console.Write("Wpisz wiadomość do wysłania: ");
                            var message = Console.ReadLine();

                            //walidacja wiadomości
                            if (string.IsNullOrWhiteSpace(message))
                            {
                                Console.WriteLine("\nWiadomość nie może być pusta\n");
                                break;
                            }

                            if (message.Length > 20)
                            {
                                Console.WriteLine("Wiadomość jest zbyt długa (max 20 znaków)");
                                break;
                            }

                            notificationManager.SendNotification(message);
                            break;
                        case 8:
                            return;
                        default:
                            Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine();
        }
    }
}
