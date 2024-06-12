namespace Task_RecordStatic;

internal class User
{
    private string _password;
    private static int id { get; set; }
    public int Id { get;  }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password
    {
        get => _password;
        set
        {
            if (PasswordChecker(value)==true)
                _password = value;
            
        }
    }
    public User(string email,string password,string name)
    {
        id++;
        Id = id;
        Email = email;
        Password = password;
        FullName = name;
    }
    public static bool PasswordChecker(string password)
    {
        bool haveBigLetter = false;
        bool haveSmallLetter = false;
        bool haveNumber = false;
        bool correctLength = false;
        if (password.Length == 8)
        {
            correctLength = true;
        }
        if (password.Length > 0)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                    haveNumber = true;
                else
                {
                    if (char.IsLetter(password[i]))
                    {
                        if (char.IsUpper(password[i]))
                            haveBigLetter = true;
                        else if (char.IsLower(password[i]))
                            haveSmallLetter = true;
                    }
                }
            }
        }
        
        if (haveBigLetter == true && haveSmallLetter == true && haveNumber == true&&correctLength==true)
            return true;
        else if (haveBigLetter == false)
        {
            Console.WriteLine("Password must contain at least one big letter");
            return false;
        }
        else if (haveSmallLetter == false)
        {
            Console.WriteLine("Password must contain at least one small letter");
            return false;
        }
        else if (haveNumber == false)
        {
            Console.WriteLine("Password must contain  at least one number");
            return false;
        }
        else if (correctLength == false)
        {
            Console.WriteLine("Length is not correct");
            return false;
        }
        else
        {
            Console.WriteLine("Password does not match what is requested");
            return false;
        }

    }
    public string GetInfo()
    {
        return $"{Id} {FullName} {Email}";
    }
    public static string FindUserById(int id, User[] users)
    {
        foreach(User user in users)
        {
            if (user.Id == id)
            {
                return $"{user.Id} {user.Email} {user.FullName}";
            }
        }
        return "User did not found";
    }
}
