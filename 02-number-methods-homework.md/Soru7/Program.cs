using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir açı girin (derece cinsinden): ");
        double derece = Convert.ToDouble(Console.ReadLine());
        double radyan = derece * (Math.PI / 180);
        Console.WriteLine($"Radyan cinsinden: {radyan}");
    }
}
