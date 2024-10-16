using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir yıl girin: ");
        int yil = Convert.ToInt32(Console.ReadLine());

        bool artikYil = DateTime.IsLeapYear(yil);
        Console.WriteLine(artikYil ? $"{yil} bir artık yıldır." : $"{yil} bir artık yıl değildir.");
    }
}
