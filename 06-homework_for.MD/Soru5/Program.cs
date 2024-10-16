using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        string girilenSayi = Console.ReadLine();

        char[] tersSayi = girilenSayi.ToCharArray();
        Array.Reverse(tersSayi);

        Console.WriteLine("Sonuç: " + new string(tersSayi));
    }
}
