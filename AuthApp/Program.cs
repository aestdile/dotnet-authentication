using AuthApp.Services;

var authService = new AuthService();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("*-------------------------*");
    Console.WriteLine("|  1. Registration        |");
    Console.WriteLine("|  2. Login               |");
    Console.WriteLine("|  3. Exit                |");
    Console.WriteLine("*-------------------------*");
    Console.Write("\nPlease, select: ");
    var choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("\nUsername: ");
        var username = Console.ReadLine();
        Console.Write("Password: ");
        var password = Console.ReadLine();
        Console.Write("Email: ");
        var email = Console.ReadLine();
        authService.Register(username, password, email);
    }
    else if (choice == "2")
    {
        Console.Write("\nUsername: ");
        var username = Console.ReadLine();
        Console.Write("Password: ");
        var password = Console.ReadLine();
        authService.Login(username, password);
    }
    else if (choice == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("\nIncorrect option.");
    }
}
