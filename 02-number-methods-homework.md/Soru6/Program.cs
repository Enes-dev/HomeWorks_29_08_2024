using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir açı girin (derece cinsinden): ");
        double aci = Convert.ToDouble(Console.ReadLine());
        double sinDegeri = Math.Sin(aci * Math.PI / 180); // Dereceden radiyana çevirme
        Console.WriteLine($"Sinüs değeri: {sinDegeri}");
    }
}