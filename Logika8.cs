using System;

public class Logika8
{
    public static void Main(string[] args)
    {
        int i;

        System.Console.Write("Nilai i: ");        
        i = int.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine("i = "+i);
            i++;

            if (i>5) {
                break;
            }

        } while (i < 20);
    }
}