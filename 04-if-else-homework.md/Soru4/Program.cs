using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir yıl girin: ");
        int yil = Convert.ToInt32(Console.ReadLine());

        bool artikYil = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);
        if (artikYil)
            Console.WriteLine($"{yil} bir artık yıldır.");
        else
            Console.WriteLine($"{yil} bir artık yıl değildir.");
    }
}
