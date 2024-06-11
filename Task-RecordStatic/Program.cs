namespace Task_RecordStatic;

internal class Program
{
    static void Main(string[] args)
    {
        User[] users= new User[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter user {i+1} email:");
            string email = Console.ReadLine();            
            Console.WriteLine($"Enter user {i+1} password:");
            Ibrahim:            
            string password = Console.ReadLine();
            if (User.PasswordChecker(password) == false)
                goto Ibrahim;            
            Console.WriteLine($"Enter user {i+1} fullname:");
            string fullName = Console.ReadLine();
            users[i] = new(email, password, fullName);
        }
        int input = 5;
        Console.WriteLine("Welcome to menu. If you want to see all users write 1");
        Console.WriteLine("If you want to see specific user write 2");
        Console.WriteLine("If you want to quit from menu type 0");
        while (input != 0)
        {
            input = Convert.ToInt32( Console.ReadLine());
            if (input == 1)
            {
                foreach(User user in users)
                {
                    Console.WriteLine( user.GetInfo());
                }
            }
            if (input == 2)
            {
                Console.WriteLine("type the user id that you want to see:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(User.FindUserById(id, users));
            }
            Console.WriteLine("If you want to see all users write 1");
            Console.WriteLine("If you want to see specific user write 2");
            Console.WriteLine("If you want to quit from menu type 0");
        }
    }
}
