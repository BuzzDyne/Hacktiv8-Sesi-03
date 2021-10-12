using System;

public class Logika8Modified
{
    public static void Main(string[] args)
    {
        int i,x =1;

        System.Console.Write("Nilai i: ");        
        i = int.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine("x = "+ x + "\nx^2 = " + x*x + "\n2x-1 = " + (2*x+1) + "\n2^x = "+ Math.Pow(2,x)  + "\n");
            x++;
        } while (x <= i);
    }
}