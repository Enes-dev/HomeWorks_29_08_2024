using System;

class Program
{
    static void Main()
    {
        Console.Write("Notunuzu girin (0-100 arası): ");
        double notu = Convert.ToDouble(Console.ReadLine());
        string harf;

        if (notu >= 90 && notu <= 100)
            harf = "A";
        else if (notu >= 80)
            harf = "B";
        else if (notu >= 70)
            harf = "C";
        else if (notu >= 60)
            harf = "D";
        else if (notu >= 0)
            harf = "F";
        else
            harf = "Geçersiz not.";

        Console.WriteLine($"Notunuzun harf karşılığı: {harf}");
    }
}
