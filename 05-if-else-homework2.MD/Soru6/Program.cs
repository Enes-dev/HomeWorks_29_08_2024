using System;

class Program
{
    static void Main()
    {
        // Ürün fiyat listesi
        decimal armutFiyat = 45.50m;
        decimal bamyaFiyat = 81.40m;
        decimal domatesFiyat = 45.00m;
        decimal muzFiyat = 65.00m;
        decimal patlicanFiyat = 45.00m;

        Console.Write("Armut (kg): ");
        decimal armutKg = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Bamya (kg): ");
        decimal bamyaKg = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Domates (kg): ");
        decimal domatesKg = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Muz (kg): ");
        decimal muzKg = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Patlıcan (kg): ");
        decimal patlicanKg = Convert.ToDecimal(Console.ReadLine());

        // Toplam tutarı hesaplama
        decimal toplamTutar = (armutKg * armutFiyat) + (bamyaKg * bamyaFiyat) +
                              (domatesKg * domatesFiyat) + (muzKg * muzFiyat) +
                              (patlicanKg * patlicanFiyat);

        Console.WriteLine($"Toplam tutar: {toplamTutar} TL");
    }
}