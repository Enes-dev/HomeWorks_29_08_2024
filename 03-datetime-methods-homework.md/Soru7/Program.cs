using System;

class Program
{
    static void Main()
    {
        Console.Write("Tarihi girin (dd/MM/yyyy formatında): ");
        string tarihStr = Console.ReadLine();
        DateTime tarih = DateTime.ParseExact(tarihStr, "dd/MM/yyyy", null);
        Console.WriteLine($"DateTime nesnesi: {tarih}");
    }
}