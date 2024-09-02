namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir cümle girin:");
        string cumle = Console.ReadLine();

        // Cümlenin başındaki ve sonundaki boşlukları kaldırıyoruz
        string temizlenmisCumle = cumle.Trim();

        Console.WriteLine("Temizlenmiş cümle:");
        Console.WriteLine(temizlenmisCumle);
    }
}
