using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1;

        Console.WriteLine("Fibonacci Serisi:");
        while (a <= sayi)
        {
            Console.Write(a + " ");
            int temp = a;
            a = b;
            b = temp + b;
        }
    }
}
