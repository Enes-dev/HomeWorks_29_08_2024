using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        double karekok = Math.Sqrt(sayi);
        Console.WriteLine($"Karekök: {karekok}");
    }
}
