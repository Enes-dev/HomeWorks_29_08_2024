using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        double mutlakDeger = Math.Abs(sayi);
        Console.WriteLine($"Mutlak değer: {mutlakDeger}");
    }
}