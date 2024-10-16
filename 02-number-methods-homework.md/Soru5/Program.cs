using System;

class Program
{
    static void Main()
    {
        Console.Write("Tabanı girin: ");
        double taban = Convert.ToDouble(Console.ReadLine());
        Console.Write("Üssü girin: ");
        double us = Convert.ToDouble(Console.ReadLine());
        double sonuc = Math.Pow(taban, us);
        Console.WriteLine($"Sonuç: {sonuc}");
    }
}