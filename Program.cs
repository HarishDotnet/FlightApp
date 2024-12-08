using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> users = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        users.Add("h","h");
        Console.WriteLine("Welcome to the Login/Sign-up System!");
        while (true)
        {
            Console.WriteLine("\n1. Login");
            Console.WriteLine("2. Sign-up");
            Console.WriteLine("3. Exit");
            Console.Write("Please choose an option (1/2/3): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Login();
            }
            else if (choice == "2")
            {
                SignUp();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    static void Login()
    {
        Console.WriteLine("\n--- Login ---");
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (users.ContainsKey(username) && users[username] == password)
        {
            Console.WriteLine("Login successful!");
            FlightAvailabilityChecker obj=new FlightAvailabilityChecker();
        }
        else
        {
            Console.WriteLine("Invalid username or password.");
        }
    }

    static void SignUp()
    {
        Console.WriteLine("\n--- Sign-up ---");
        Console.Write("Enter a username: ");
        string username = Console.ReadLine();

        if (users.ContainsKey(username))
        {
            Console.WriteLine("Username already taken. Please choose a different username.");
        }
        else
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            users.Add(username, password);
            Console.WriteLine("Sign-up successful! You can now log in.");
        }
    }
}
