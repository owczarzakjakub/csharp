using System.Security.Cryptography;
using System.Text;

namespace _5_2_zdarzenia
{
    internal class Program
    {
        public enum Role
        {
            Administrator,
            Manager,
            User
        }

        public enum Permissions
        {
            Read,
            Write,
            Delete,
            ManageUsers
        }

        public class User
        {
            public string Username { get; set; }
            public List<Role> Roles { get; set; }
            public User(string username)
            {
                Roles = new List<Role>();
                Username = username;
            }

            public void AddRole(Role role)
            {
                if (!Roles.Contains(role))
                {
                    Roles.Add(role);
                }
            }
        }

        public class RBAC
        {
            private readonly Dictionary<Role, List<Permissions>> _rolePermissions;


            public RBAC()
            {
                _rolePermissions = new Dictionary<Role, List<Permissions>>
                {
                    { Role.Administrator, new List<Permissions>{Permissions.Read, Permissions.Write, Permissions.Delete, Permissions.ManageUsers}},
                    { Role.Manager, new List<Permissions>{ Permissions.Read, Permissions.Write }},
                    { Role.User, new List<Permissions>{ Permissions.Read } }
                };
            }

            public bool HasPermission(User user, Permissions permission)
            {
                foreach (var role in user.Roles)
                {
                    if (_rolePermissions.ContainsKey(role) && _rolePermissions[role].Contains(permission))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public class PasswordManager
        {
            private const string _passwordFilePath = "userPasswords.txt";
            public static event Action<string, bool> PasswordVerified;

            static PasswordManager()
            {
                if (!File.Exists(_passwordFilePath))
                {
                    File.Create(_passwordFilePath).Dispose();
                }
            }

            public static void SavePassword(string username, string password)
            {
                if (File.ReadLines(_passwordFilePath).Any(line => line.Split(',')[0] == username))
                {
                    Console.WriteLine($"Użytkownik {username} już istnieje w systemie");
                    return;
                }

                string hashedPassword = HashPassword(password);
                File.AppendAllText(_passwordFilePath, $"{username},{hashedPassword}\n");
                Console.WriteLine($"Użytkownik {username} został zapisany");
            }

            public static bool VerifyPassword(string username, string password)
            {
                string hashedPassword = HashPassword(password);
                foreach (var line in File.ReadLines(_passwordFilePath))
                {
                    var parts = line.Split(',');
                    if (parts[0] == username && parts[1] == hashedPassword)
                    {
                        PasswordVerified?.Invoke(username, true);
                        return true;
                    }
                }
                PasswordVerified?.Invoke(username, false);
                return false;
            }

            private static string HashPassword(string password)
            {
                using (var sha256 = SHA256.Create())
                {
                    var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                    return Convert.ToBase64String(bytes);
                }
            }
        }

        public delegate void FileOPerations(string FilePath);

        public class FileManager()
        {
            //dok.
        };

        static void Main(string[] args)
        {
            PasswordManager.PasswordVerified += (username, success) => Console.WriteLine($"Logowanie użytkownika {username} : {(success ? "udane" : "nieudane")}");

            PasswordManager.SavePassword("AdminUser", "adminPassword");
            PasswordManager.SavePassword("ManagerUser", "ManagerPasssword");
            PasswordManager.SavePassword("NormalUser", "USerPassword");
            PasswordManager.SavePassword("xyz", "UserPassword");


            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.Clear();
                Console.WriteLine("=== SYSTEM LOGOWANIA ===");
                Console.WriteLine("Wprowadz nazwe uzytkownika");
                string username = Console.ReadLine();
                Console.WriteLine("Wprawdz hasło");
                string password = Console.ReadLine();

                if (PasswordManager.VerifyPassword(username, password))
                {
                    Console.WriteLine("Niepoprawna nazwa użytkownika lub hasło");
                    Console.ReadKey();
                    continue;
                }
                var user = new User(username);
                if(username == "AdminUser")
                {
                    user.AddRole(Role.Administrator);
                }
                else if(username == "ManagerUser"){
                    user.AddRole(Role.Manager);
                }
                else
                {
                    user.AddRole(Role.User);
                }

                var rbacSystem = new RBAC();

                string filePath = "testfile.txt";

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Zalogowano jako: {username}");
                    Console.WriteLine($"Wybierz opcje \n");
                    Console.WriteLine("1. Odczytaj plik");

                    if (rbacSystem.HasPermission(user, Permissions.Write))
                    {
                        Console.WriteLine("2. Zapisz do pliku");
                    }
                    if (rbacSystem.HasPermission(user, Permissions.Delete))
                    {
                        Console.WriteLine("3. Usun z pliku");
                    }
                    if(rbacSystem.HasPermission(user, Permissions.ManageUsers))
                    {
                        Console.WriteLine("4. Dodaj nowego użytkownika");
                    }
                    Console.WriteLine("5. Wyloguj sie");
                    Console.WriteLine("6. Wyjdz");
                    Console.ReadKey();

                    int choice;
                    if(int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Niepoprawny wybor sprobuj ponownie");
                        continue;
                    }
                    else
                    {

                    }
                }
            }

           /* Console.Write("\nWprowadź nazwę użytkownika: ");
            string username = Console.ReadLine();

            Console.Write("Wprowadź hasło: ");
            string password = Console.ReadLine();
            Console.WriteLine();

            if (!PasswordManager.VerifyPassword(username, password))
            {
                Console.WriteLine("Niepoprawna nazwa użytkownika lub hasło");
                return;
            }

            var user = new User(username);

            if (username == "AdminUser")
            {
                user.AddRole(Role.Administrator);
            }

            var rbacSystem = new RBAC();

            Console.WriteLine("\nSprawdzenie dostępu do różnych zasobów:");

            Console.WriteLine("Read: " + rbacSystem.HasPermission(user, "Read"));
            Console.WriteLine("Write: " + rbacSystem.HasPermission(user, "Write"));
            Console.WriteLine("Delete: " + rbacSystem.HasPermission(user, "Delete"));*/
        }
    }
}
