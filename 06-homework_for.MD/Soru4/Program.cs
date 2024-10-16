using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int toplam = 0;

        Console.Write("Çarpanlar: ");
        for (int i = 1; i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                Console.Write(i + " ");
                toplam += i;
            }
        }

        Console.WriteLine($"\nÇarpanların toplamı: {toplam}");
    }
}