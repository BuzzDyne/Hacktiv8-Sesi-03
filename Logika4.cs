using System;

public class Logika4
{
    public static void Main(string[] args)
    {
        int nilai;

        Console.Write("Nilai: ");
        nilai = Convert.ToDouble(Console.ReadLine());

        if (nilai >= 85) {
            Console.WriteLine("Nilai Kamu A");
        } else if (nilai >= 65) {
            Console.WriteLine("Nilai Kamu B");
        } else if (nilai >= 45) {
            Console.WriteLine("Nilai Kamu C");
        } else if (nilai <= 25) {
            Console.WriteLine("Nilai Kamu D");
        }
    }
}