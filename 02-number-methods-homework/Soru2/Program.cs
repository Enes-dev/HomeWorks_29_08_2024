namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
                Console.WriteLine("Lütfen birinci sayıyı girin:");
        string input1 = Console.ReadLine();
        
        Console.WriteLine("Lütfen ikinci sayıyı girin:");
        string input2 = Console.ReadLine();

        // Kullanıcıdan alınan girdileri double tipine çeviriyoruz
        double sayi1, sayi2;

        if (double.TryParse(input1, out sayi1) && double.TryParse(input2, out sayi2))
        {
            if (sayi1 > sayi2)
            {
                Console.WriteLine("Birinci sayı daha büyük: " + sayi1);
            }
            else if (sayi2 > sayi1)
            {
                Console.WriteLine("İkinci sayı daha büyük: " + sayi2);
            }
            else
            {
                Console.WriteLine("İki sayı eşit: " + sayi1);
            }
        }
        else
        {
            Console.WriteLine("Geçerli sayılar girmediniz.");
        }
    }
}
