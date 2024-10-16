using System;

class Program
{
    static void Main()
    {
        Console.Write("Boyunuzu (metre cinsinden) girin: ");
        double boy = Convert.ToDouble(Console.ReadLine());
        Console.Write("Kilonuzu (kg cinsinden) girin: ");
        double kilo = Convert.ToDouble(Console.ReadLine());

        double vki = kilo / Math.Pow(boy, 2);
        Console.WriteLine($"Vücut Kitle İndeksiniz: {vki}");
    }
}