using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir para değeri girin (TL): ");
        decimal tutar = Convert.ToDecimal(Console.ReadLine());
        decimal kdvOrani;

        if (tutar > 0 && tutar <= 1000)
            kdvOrani = 0.20m; // %20 KDV
        else if (tutar > 1000)
            kdvOrani = 0.08m; // %8 KDV
        else
        {
            Console.WriteLine("Geçersiz tutar.");
            return;
        }

        decimal kdvTutari = tutar * kdvOrani;
        decimal kdvliFiyat = tutar + kdvTutari;

        Console.WriteLine($"KDV Tutarı: {kdvTutari} TL");
        Console.WriteLine($"KDV'li Fiyat: {kdvliFiyat} TL");
    }
}
