using System;

class Program
{
    static void Main()
    {
        Console.Write("Doğum tarihinizi (yyyy-MM-dd formatında) girin: ");
        string input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime dogumTarihi))
        {
            int dogumYili = dogumTarihi.Year;
            int kalan = dogumYili % 12;

            string zodyakHayvani = kalan switch
            {
                0 => "Maymun",
                1 => "Horoz",
                2 => "Köpek",
                3 => "Domuz",
                4 => "Fare",
                5 => "Öküz",
                6 => "Kaplan",
                7 => "Tavşan",
                8 => "Ejderha",
                9 => "Yılan",
                10 => "At",
                11 => "Koyun",
                _ => "Bilinmeyen"
            };

            Console.WriteLine($"Sizin Çin Zodyağınız: {zodyakHayvani}");
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı. Lütfen 'yyyy-MM-dd' formatında bir tarih girin.");
        }
    }
}
