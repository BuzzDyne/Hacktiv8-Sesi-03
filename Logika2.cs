using System;

public class Logika2
{
    public static void Main(string[] args)
    {
        int nilai;
        string nama;

        Console.Write("Nama: ");
        nama = Console.ReadLine();

        Console.Write("Nilai: ");
        nilai = int.Parse(Console.ReadLine());

        Console.Write("Halo, "+nama+"! ");

        if (nilai < 60) {
            Console.Write("Nilai Kamu C");
        } else if (nilai < 80) {
            Console.Write("Nilai Kamu B");
        } else if (nilai < 100) {
            Console.Write("Nilai Kamu A");
        } else {
            Console.Write("Nilai Kamu S");
        }
    }
}