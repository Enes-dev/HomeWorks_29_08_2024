using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir ondalıklı sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        Console.Write("Kaç ondalık basamağa yuvarlanacak: ");
        int basamak = Convert.ToInt32(Console.ReadLine());
        double yuvarlanmisSayi = Math.Round(sayi, basamak);
        Console.WriteLine($"Yuvarlanmış sayı: {yuvarlanmisSayi}");
    }
}
