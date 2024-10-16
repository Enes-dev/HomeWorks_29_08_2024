using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Yapmak istediğiniz işlemi girin (+, -, *, /): ");
        char islem = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double sonuc;

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
                sonuc = sayi1 / sayi2;
                break;
            default:
                Console.WriteLine("Geçersiz işlem.");
                return; // Programı sonlandır
        }

        Console.WriteLine($"Sonuç: {sonuc}");
    }
}