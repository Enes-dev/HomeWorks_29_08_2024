using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi < 2)
        {
            Console.WriteLine("Girilen sayı asal değildir.");
            return;
        }

        bool asal = true;

        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
            {
                asal = false;
                break;
            }
        }

        if (asal)
            Console.WriteLine("Girilen sayı asaldır.");
        else
            Console.WriteLine("Girilen sayı asal değildir.");
    }
}