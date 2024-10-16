using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir karakter girin: ");
        char karakter = Convert.ToChar(Console.ReadLine().ToLower());

        if (karakter == 'a' || karakter == 'e' || karakter == 'i' || karakter == 'o' || karakter == 'u')
            Console.WriteLine("Girilen karakter bir sesli harftir.");
        else
            Console.WriteLine("Girilen karakter bir sesli harf değildir.");
    }
}
