namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
                Console.WriteLine("Lütfen bir cümle girin:");
        string cumle = Console.ReadLine();

        Console.WriteLine("Aranacak kelimeyi girin:");
        string kelime = Console.ReadLine();

        // Cümleyi boşluk karakterine göre ayırıyoruz ve boş elemanları yoksayıyoruz
        string[] kelimeler = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Aranan kelimenin kaç kez geçtiğini saymak için bir sayaç kullanıyoruz
        int kelimeSayisi = 0;

        foreach (string k in kelimeler)
        {
            if (k.Equals(kelime, StringComparison.OrdinalIgnoreCase)) // Büyük-küçük harf duyarsız karşılaştırma
            {
                kelimeSayisi++;
            }
        }

        Console.WriteLine($"'{kelime}' kelimesi cümlede {kelimeSayisi} kez geçiyor.");
    }
    }

