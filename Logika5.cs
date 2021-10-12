using System;

public class Logika4
{
    public static void Main(string[] args)
    {
        int nilai;

        Console.Write("Nilai: ");
        nilai = int.Parse(Console.ReadLine());

        switch (nilai)
        {
            case 1:{
                Console.WriteLine("Jan");
                break;}
            case 2:{
                Console.WriteLine("Feb");
                break;}
            case 3:{
                Console.WriteLine("Mar");
                break;}
            case 4:{
                Console.WriteLine("Apr");
                break;}
            case 5:{
                Console.WriteLine("May");
                break;}
            case 6:{
                Console.WriteLine("Jun");
                break;}
            case 7:{
                Console.WriteLine("Jul");
                break;}
            case 8:{
                Console.WriteLine("Agt");
                break;}
            case 9:{
                Console.WriteLine("Sep");
                break;}
            case 10:{
                Console.WriteLine("Oct");
                break;}
            case 11:{
                Console.WriteLine("Nov");
                break;}
            case 12:{
                Console.WriteLine("Dec");
                break;}
            default:{
                Console.WriteLine("Masukan angka (1-12)!");
                break;}
        }
    }
}