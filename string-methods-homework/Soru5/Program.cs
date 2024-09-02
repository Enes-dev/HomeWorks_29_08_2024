namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Lütfen bir metin girin:");
        string anaMetin = Console.ReadLine();

        Console.WriteLine("Aranacak metni girin:");
        string aranacakMetin = Console.ReadLine();

        // Aranacak metni ana metin içinde arıyoruz
        int index = anaMetin.IndexOf(aranacakMetin, StringComparison.OrdinalIgnoreCase);

        if (index != -1)
        {
            Console.WriteLine($"'{aranacakMetin}' metni ilk olarak {index}. indekste bulundu.");
        }
        else
        {
            Console.WriteLine($"'{aranacakMetin}' metni ana metin içinde bulunamadı.");
        }
    }
    }

