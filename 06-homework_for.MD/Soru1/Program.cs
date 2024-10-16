using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int toplam = 0;
        int sayac = 0;

        for (int i = 0; i <= sayi; i++)
        {
            if (i % 3 == 0 && i % 4 == 0)
            {
                toplam += i;
                sayac++;
            }
        }

        double ortalama = sayac > 0 ? (double)toplam / sayac : 0;
        Console.WriteLine($"3'ün ve 4'ün katı olan sayıların ortalaması: {ortalama}");
    }
}
