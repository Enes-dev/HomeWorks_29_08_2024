using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci kenar uzunluğunu girin: ");
        double kenar1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci kenar uzunluğunu girin: ");
        double kenar2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Üçüncü kenar uzunluğunu girin: ");
        double kenar3 = Convert.ToDouble(Console.ReadLine());

        double yarimCevre = (kenar1 + kenar2 + kenar3) / 2;
        double alan = Math.Sqrt(yarimCevre * (yarimCevre - kenar1) * (yarimCevre - kenar2) * (yarimCevre - kenar3));

        Console.WriteLine($"Üçgenin alanı: {alan}");
    }
}
