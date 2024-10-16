using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Üçüncü sayıyı girin: ");
        double sayi3 = Convert.ToDouble(Console.ReadLine());

        double[] sayilar = { sayi1, sayi2, sayi3 };
        Array.Sort(sayilar);
        Array.Reverse(sayilar); // Büyükten küçüğe sıralama

        Console.WriteLine("Büyükten küçüğe sıralama: " + string.Join(", ", sayilar));
    }
}
