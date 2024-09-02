namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Lütfen bir metin girin:");
        string metin = Console.ReadLine();

        // Metnin tüm harflerini büyük yapıyoruz
        string buyukHarfliMetin = metin.ToUpper();

        // Metnin tüm harflerini küçük yapıyoruz
        string kucukHarfliMetin = metin.ToLower();

        // Tek bir Console.Write ile sonuçları alt alta yazdırıyoruz
        Console.WriteLine(buyukHarfliMetin + "\n" + kucukHarfliMetin);
    }
}
