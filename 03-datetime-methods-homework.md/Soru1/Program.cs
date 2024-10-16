using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir tarih girin (yyyy-MM-dd formatında): ");
        DateTime tarih = DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"Tarih: {tarih.ToShortDateString()}, Gün: {tarih.DayOfWeek}");
    }
}