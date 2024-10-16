using System;

class Program
{
    static void Main()
    {
        Console.Write("Saati girin (hh:mm tt formatında, örneğin 02:30 PM): ");
        string saatStr = Console.ReadLine();
        DateTime saat = DateTime.Parse(saatStr);
        string saat24Format = saat.ToString("HH:mm");
        Console.WriteLine($"24 saat formatındaki saat: {saat24Format}");
    }
}