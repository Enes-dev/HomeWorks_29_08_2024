namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir cümle girin:");
        string cumle = Console.ReadLine();

        // Cümleyi boşluk karakterine göre ayırıyoruz
        string[] kelimeler = cumle.Split(' ');

        // Dizi uzunluğu, kelime sayısını verir
        int kelimeSayisi = kelimeler.Length;

        Console.WriteLine("Cümledeki kelime sayısı: " + kelimeSayisi);
    }
}
