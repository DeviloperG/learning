namespace ConsoleApp2;

public static class Program14
{
    public static string? ReadResult;
    public static string? userLevel;
    public static bool isValid = false;
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
        do
        {
            ReadResult = Console.ReadLine();
            if (ReadResult != null)
            {
                string role = ReadResult.Trim().ToLower();
                isValid = true;
                switch (role)
                {
                    case "administrator":
                        Console.WriteLine("Your input value (Administrator) has been accepted.");
                        break;
                    
                    case "manager":
                        Console.WriteLine("Your input value (Manager) has been accepted.");
                        break;
                    
                    case "user":
                        Console.WriteLine("Your input value (User) has been accepted.");
                        break;
                    
                    default:
                        Console.WriteLine($"The role name that you entered, {ReadResult} is not valid. Enter your role name (Administrator, Manager, or User)");
                        isValid = false;
                        break;
                }
            }
        } while (isValid == false);

    }
}