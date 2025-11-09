namespace Armstrong;
using System;
class Program
{
    static void Main()
    {
        // Kullanıcıdan bir sayı alınır
        Console.Write("Bir sayı girin: ");
        int number = int.Parse(Console.ReadLine());

        // Sayının basamak sayısını bulma
        int temp = number;
        int sum = 0;
        int digits = 0;

        // Sayının basamak sayısını hesaplamak için döngü
        while (temp != 0)
        {
            digits++;
            temp /= 10;
        }

        temp = number;

        // Sayının Armstrong olup olmadığını kontrol etmek için döngü
        while (temp != 0)
        {
            int digit = temp % 10; // Rakamı almak için
            sum += (int)Math.Pow(digit, digits); // Rakamların küpünü almak
            temp /= 10; // Bir sonraki basamağa geçmek
        }

        // Sonuç
        if (sum == number)
        {
            Console.WriteLine($"{number} bir Armstrong sayısıdır.");
        }
        else
        {
            Console.WriteLine($"{number} bir Armstrong sayısı değildir.");
        }
    }
}
