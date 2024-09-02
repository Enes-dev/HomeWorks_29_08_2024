namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir sayı girin:");
        string input = Console.ReadLine();

        // Kullanıcıdan alınan girdiyi double tipine çeviriyoruz
        double sayi;
        if (double.TryParse(input, out sayi))
        {
            // Sayının mutlak değerini hesaplıyoruz
            double mutlakDeger = Math.Abs(sayi);
            Console.WriteLine("Sayının mutlak değeri: " + mutlakDeger);
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girmediniz.");
        }
    }
    }
