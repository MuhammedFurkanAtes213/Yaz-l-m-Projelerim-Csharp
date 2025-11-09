namespace BankApp;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Hesap sahibinin adını girin:");
        string name = Console.ReadLine();
        Console.WriteLine("Başlangıç bakiyesini girin:");
        decimal initialBalance = decimal.Parse(Console.ReadLine());
        var account = new BankAccount(name, initialBalance);

        while (true)
        {
            Console.WriteLine("\n--- Banka Uygulaması ---");
            Console.WriteLine("1. Para Yatır");
            Console.WriteLine("2. Para Çek");
            Console.WriteLine("3. Bakiyeyi Görüntüle");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminiz: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Yatırılacak tutar: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                account.Deposit(amount);
                Console.WriteLine($"Yeni bakiye: {account.Balance}");
            }
            else if (choice == "2")
            {
                Console.Write("Çekilecek tutar: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                if (account.Withdraw(amount))
                    Console.WriteLine($"Yeni bakiye: {account.Balance}");
                else
                    Console.WriteLine("Yetersiz bakiye!");
            }
            else if (choice == "3")
            {
                Console.WriteLine($"Hesap Sahibi: {account.AccountHolder}");
                Console.WriteLine($"Bakiye: {account.Balance}");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Çıkılıyor...");
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
            }
        }
    }
}