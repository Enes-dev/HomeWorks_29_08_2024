using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan bir cümle alıyoruz
        Console.WriteLine("Lütfen bir cümle girin:");
        string cumle = Console.ReadLine();

        // Cümledeki kelimeleri ayırıyoruz ve kelime sayısını buluyoruz
        string[] kelimeler = cumle.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        int kelimeSayisi = kelimeler.Length;

        // Kelime sayısını ekrana yazdırıyoruz
        Console.WriteLine("Cümledeki kelime sayısı: " + kelimeSayisi);
    }
}