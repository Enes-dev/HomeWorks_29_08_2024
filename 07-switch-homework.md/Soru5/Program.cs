using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin (1-4): ");
        int mevsim = Convert.ToInt32(Console.ReadLine());

        switch (mevsim)
        {
            case 1:
                Console.WriteLine("İlkbahar");
                break;
            case 2:
                Console.WriteLine("Yaz");
                break;
            case 3:
                Console.WriteLine("Sonbahar");
                break;
            case 4:
                Console.WriteLine("Kış");
                break;
            default:
                Console.WriteLine("Lütfen 1-4 arasında bir sayı girin.");
                break;
        }
    }
}

