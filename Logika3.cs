using System;

public class Logika3
{
    public static void Main(string[] args)
    {
        string username, password;

        Console.Write("username: ");
        username = Console.ReadLine();

        Console.Write("password: ");
        password = Console.ReadLine();

        if (username == "ocbc" && password == "bootcamp") {
            Console.WriteLine("Login successful");
        }
        else {
            Console.WriteLine("Wrong Credentials, try again!");
        }
    }
}