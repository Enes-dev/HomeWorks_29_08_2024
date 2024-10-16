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

        double sonuc;

        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                Console.WriteLine($"Sonuç: {sonuc}");
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                Console.WriteLine($"Sonuç: {sonuc}");
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                Console.WriteLine($"Sonuç: {sonuc}");
                break;
            case '/':
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                }
                else
                {
                    Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem.");
                break;
        }
    }
}
