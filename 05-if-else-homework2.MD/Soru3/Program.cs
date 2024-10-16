using System;

class Program
{
    static void Main()
    {
        Console.Write("Gidilen mesafeyi girin (KM): ");
        double mesafe = Convert.ToDouble(Console.ReadLine());

        const decimal acilisUcreti = 30m;
        const decimal kmUcreti = 20m;
        const decimal minimumTutar = 100m;

        decimal toplamTutar = acilisUcreti + (decimal)(mesafe * kmUcreti);
        toplamTutar = toplamTutar < minimumTutar ? minimumTutar : toplamTutar;

        Console.WriteLine($"Taksimetre tutarı: {toplamTutar} TL");
    }
}
