using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir harf girin: ");
        char harf = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Sesli harfler
        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

        if (Array.Exists(sesliHarfler, element => element == char.ToLower(harf)))
        {
            Console.WriteLine($"{harf} bir sesli harftir.");
        }
        else
        {
            Console.WriteLine($"{harf} bir sessiz harftir.");
        }
    }
}
