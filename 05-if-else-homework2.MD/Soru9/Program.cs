using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir yıl girin: ");
        int yil = Convert.ToInt32(Console.ReadLine());

        bool artikYilMi;

        // Artık yıl kontrolü
        if (yil % 4 == 0)
        {
            if (yil % 100 == 0)
            {
                if (yil % 400 == 0)
                {
                    artikYilMi = true; // 400'e kalansız bölünebilen yıllar
                }
                else
                {
                    artikYilMi = false; // 100'e kalansız bölünen ama 400'e bölünemeyen yıllar
                }
            }
            else
            {
                artikYilMi = true; // 4'e kalansız bölünebilen ve 100'e bölünemeyen yıllar
            }
        }
        else
        {
            artikYilMi = false; // 4'e kalansız bölünemeyen yıllar
        }

        // Sonucu ekrana yazdırma
        if (artikYilMi)
        {
            Console.WriteLine($"{yil} bir artık yıldır.");
        }
        else
        {
            Console.WriteLine($"{yil} bir artık yıl değildir.");
        }
    }
}
