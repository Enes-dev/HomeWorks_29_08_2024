using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Bir işlem (+, -, *, /) girin: ");
        char islem = Console.ReadLine()[0];

        double sonuc = 0;

        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                break;
            case '/':
                if (sayi2 != 0)
                    sonuc = sayi1 / sayi2;
                else
                {
                    Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem.");
                return;
        }

        Console.WriteLine($"Sonuç: {sonuc}");
    }
}