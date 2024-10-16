using System;

class Program
{
    static void Main()
    {
        DateTime simdikiTarih = DateTime.Now;
        string ayAdi = simdikiTarih.ToString("MMMM", System.Globalization.CultureInfo.GetCultureInfo("tr-TR"));
        Console.WriteLine($"Şu anki ay: {ayAdi}");
    }
}