namespace Soru4;

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
            if (sayi >= 0)
            {
                // Sayının karekökünü hesaplıyoruz
                double karekok = Math.Sqrt(sayi);
                Console.WriteLine("Sayının karekökü: " + karekok);
            }
            else
            {
                Console.WriteLine("Negatif sayıların reel karekökü yoktur.");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girmediniz.");
        }
    }
    }

