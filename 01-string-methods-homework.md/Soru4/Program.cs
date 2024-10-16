using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir cümle girin:");
        string cumle = Console.ReadLine();

        string trimmedCumle = cumle.Trim();

        Console.WriteLine("Boşluklar kaldırıldıktan sonra: \"" + trimmedCumle + "\"");
    }
}