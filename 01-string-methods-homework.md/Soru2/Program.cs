using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir metin girin:");
        string metin = Console.ReadLine();

        string buyukHarfler = metin.ToUpper();
        string kucukHarfler = metin.ToLower();

        Console.Write(buyukHarfler + Environment.NewLine + kucukHarfler);
    }
}