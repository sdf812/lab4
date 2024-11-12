using ConsoleApp1;
using System.Xml;

IAccountManager manager= new AccountManager();

while (true)
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1. Открыть счет");
    Console.WriteLine("2. Закрыть счет");
    Console.WriteLine("3. Пополнить счет");
    Console.WriteLine("4. Снять деньги");
    Console.WriteLine("5. Выйти из программы");

    Console.Write("Ваш выбор: ");
    var name = Console.ReadLine();
    switch (Console.ReadLine())
    {
        case "1":
            var balance = int.Parse(Console.ReadLine());
            manager.OpenAccount(name, balance);
            break;
        case "2":
            manager.CloseAccount(name);
            break;
        case "3":
            var amount = int.Parse(Console.ReadLine());
            manager.Deposit(name, amount);
            break;
        case "4":
            var a = int.Parse(Console.ReadLine());
            manager.Withdraw(name, a);
            break;
        case "5":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Неверный выбор. Попробуйте снова.");
            break;
    }
}
