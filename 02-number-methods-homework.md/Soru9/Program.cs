using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        double kucukSayi = Math.Min(sayi1, sayi2);
        Console.WriteLine($"Küçük sayı: {kucukSayi}");
    }
}