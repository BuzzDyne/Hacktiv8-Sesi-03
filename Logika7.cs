using System;

public class Logika7 {
    public static void Main(string[] args)
    {
        int a;

        Console.Write("Panjang Sisi Kotak: ");
        a = int.Parse(Console.ReadLine());

        System.Console.WriteLine();

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                Console.Write("O ");
            }
            Console.Write('\n');
        }
    }
}