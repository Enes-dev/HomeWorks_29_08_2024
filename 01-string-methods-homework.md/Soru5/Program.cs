class Program
{
    static void Main()
    {
        // Kullanıcıdan bir metin alıyoruz
        Console.WriteLine("Lütfen bir metin girin:");
        string metin = Console.ReadLine();

        // Kullanıcıdan aranacak kelimeyi alıyoruz
        Console.WriteLine("Lütfen aramak istediğiniz metni girin:");
        string aranacakMetin = Console.ReadLine();

        // Aranacak metnin ilk bulunduğu indeks
        int indeks = metin.IndexOf(aranacakMetin, StringComparison.OrdinalIgnoreCase);

        // Sonucu ekrana yazdırıyoruz
        if (indeks != -1)
        {
            Console.WriteLine($"\"{aranacakMetin}\" metni, metinde {indeks} indeksinde bulundu.");
        }
        else
        {
            Console.WriteLine($"\"{aranacakMetin}\" metni, metinde bulunamadı.");
        }
    }
}