using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int toplam = 0;

        for (int i = 1; i < sayi; i++)
        {
            if (sayi % i == 0)
            {
                toplam += i;
            }
        }

        if (toplam == sayi)
        {
            Console.WriteLine($"{sayi} bir mükemmel sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} bir mükemmel sayı değildir.");
        }
    }
}