using System;

public class Logika1
{
    public static void Main(string[] args)
    {
        int a,b;

        Console.Write("Nilai A: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Nilai B: ");
        b = int.Parse(Console.ReadLine());

        if (a > b) {
            Console.WriteLine("a lebih besar dari b");
        } else if (a < b) {
            Console.WriteLine("b lebih besar dari a");
        } else {
            Console.WriteLine("a sama dengan b");
        }
    }
}