using AuthApp.Data;
using AuthApp.Models;

namespace AuthApp.Services;

public class AuthService
{
    private readonly AppDbContext _context = new();

    public void Register(string username, string password, string email)
    {
        var userExists = _context.Users.Any(u => u.Username == username);
        if (userExists)
        {
            Console.WriteLine("\nThis user is already exist!");
            return;
        }

        var user = new User { Username = username, Password = password, Email = email };
        _context.Users.Add(user);
        _context.SaveChanges();

        Console.WriteLine("\nRegistration is successfull!");
    }

    public void Login(string username, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        if (user == null)
        {
            Console.WriteLine("\nInvalid Error! Password or Username is incorrect!");
        }
        else
        {
            Console.WriteLine($"\nWelcome, {username}!");
        }
    }
}
