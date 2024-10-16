using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Üçüncü sayıyı girin: ");
        double sayi3 = Convert.ToDouble(Console.ReadLine());

        double enBuyuk = Math.Max(sayi1, Math.Max(sayi2, sayi3));
        Console.WriteLine($"En büyük sayı: {enBuyuk}");
    }
}