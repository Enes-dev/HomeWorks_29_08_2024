using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir cümle girin:");
        string cumle = Console.ReadLine();

        Console.WriteLine("Lütfen aramak istediğiniz kelimeyi girin:");
        string kelime = Console.ReadLine();

        string[] kelimeler = cumle.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        int kelimeSayisi = 0;
        foreach (string k in kelimeler)
        {
            if (k.Equals(kelime, StringComparison.OrdinalIgnoreCase)) 
            {
                kelimeSayisi++;
            }
        }

        Console.WriteLine($"\"{kelime}\" kelimesi cümlede {kelimeSayisi} kez geçiyor.");
    }
}