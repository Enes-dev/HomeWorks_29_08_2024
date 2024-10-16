using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir tarih girin (yyyy-MM-dd formatında): ");
        DateTime tarih = DateTime.Parse(Console.ReadLine());
        int gunSayisi = tarih.DayOfYear;
        Console.WriteLine($"Bu tarih yılın {gunSayisi}. günüdür.");
    }
}
