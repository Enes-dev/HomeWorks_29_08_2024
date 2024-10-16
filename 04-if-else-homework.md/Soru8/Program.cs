using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi % 3 == 0 && sayi % 5 == 0)
            Console.WriteLine("Girilen sayı hem 3'e hem de 5'e tam bölünmektedir.");
        else if (sayi % 3 == 0)
            Console.WriteLine("Girilen sayı sadece 3'e tam bölünmektedir.");
        else if (sayi % 5 == 0)
            Console.WriteLine("Girilen sayı sadece 5'e tam bölünmektedir.");
        else
            Console.WriteLine("Girilen sayı ne 3'e ne de 5'e tam bölünmektedir.");
    }
}
