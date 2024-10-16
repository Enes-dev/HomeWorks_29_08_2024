using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int bolenSayisi = 0;

        for (int i = 1; i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                bolenSayisi++;
            }
        }

        Console.WriteLine($"Pozitif bölen sayısı: {bolenSayisi}");
    }
}
