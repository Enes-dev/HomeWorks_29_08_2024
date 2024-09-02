namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir ondalıklı sayı girin:");
        string input = Console.ReadLine();
        
        // Kullanıcıdan alınan girdiyi double tipine çeviriyoruz
        double sayi;
        if (double.TryParse(input, out sayi))
        {
            // Sayıyı en yakın tam sayıya yuvarlıyoruz
            int yuvarlanmisSayi = (int)Math.Round(sayi);

            Console.WriteLine("Yuvarlanmış sayı: " + yuvarlanmisSayi);
        }
        else
        {
            Console.WriteLine("Geçerli bir ondalıklı sayı girmediniz.");
        }
    }
    }

