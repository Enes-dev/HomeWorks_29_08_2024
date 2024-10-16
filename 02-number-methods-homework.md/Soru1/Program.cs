using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir ondalıklı sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        int yuvarlanmisSayi = (int)Math.Round(sayi);
        Console.WriteLine($"Yuvarlanmış sayı: {yuvarlanmisSayi}");
    }
}