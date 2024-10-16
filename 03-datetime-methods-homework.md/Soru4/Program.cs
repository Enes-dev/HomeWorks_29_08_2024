using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir tarih girin (yyyy-MM-dd formatında): ");
        DateTime tarih = DateTime.Parse(Console.ReadLine());
        Console.Write("Eklemek istediğiniz gün sayısını girin: ");
        int gunSayisi = Convert.ToInt32(Console.ReadLine());

        DateTime yeniTarih = tarih.AddDays(gunSayisi);
        Console.WriteLine($"Yeni tarih: {yeniTarih.ToShortDateString()}");
    }
}