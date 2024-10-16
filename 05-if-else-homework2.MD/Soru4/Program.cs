using System;

class Program
{
    static void Main()
    {
        Console.Write("Dairenin yarıçapını girin: ");
        double yaricap = Convert.ToDouble(Console.ReadLine());

        double alan = Math.PI * Math.Pow(yaricap, 2);
        double cevre = 2 * Math.PI * yaricap;

        Console.WriteLine($"Dairenin alanı: {alan}");
        Console.WriteLine($"Dairenin çevresi: {cevre}");
    }
}
