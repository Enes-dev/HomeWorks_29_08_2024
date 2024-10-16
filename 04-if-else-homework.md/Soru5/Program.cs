using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci kenar uzunluğunu girin: ");
        double kenar1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci kenar uzunluğunu girin: ");
        double kenar2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Üçüncü kenar uzunluğunu girin: ");
        double kenar3 = Convert.ToDouble(Console.ReadLine());

        bool ucgenMi = (kenar1 + kenar2 > kenar3) && (kenar1 + kenar3 > kenar2) && (kenar2 + kenar3 > kenar1);
        if (ucgenMi)
            Console.WriteLine("Bu kenar uzunlukları bir üçgen oluşturur.");
        else
            Console.WriteLine("Bu kenar uzunlukları bir üçgen oluşturmaz.");
    }
}