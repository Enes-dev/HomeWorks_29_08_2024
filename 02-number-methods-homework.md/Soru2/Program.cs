using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        if (sayi1 > sayi2)
            Console.WriteLine($"{sayi1} daha büyüktür.");
        else if (sayi2 > sayi1)
            Console.WriteLine($"{sayi2} daha büyüktür.");
        else
            Console.WriteLine("Her iki sayı eşittir.");
    }
}
