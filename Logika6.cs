using System;

public class Logika6
{
    public static void Main(string[] args)
    {
        int a;

        Console.Write("Nilai A: ");
        a = int.Parse(Console.ReadLine());

        int i = 1;
        while (i<=a) {
            Console.WriteLine("Nilai: "+i);
            i++;
        }
    }
}