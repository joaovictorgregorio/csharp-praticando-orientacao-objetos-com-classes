using BankAccountApp;

Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("                     CONTA BANCÁRIA");
Console.ResetColor();
Console.WriteLine();

var account = new BankAccount("6789675-3", 1200.00);
account.Deposit(1200.00);

Console.WriteLine($"  Conta: {account.AccountNumber} \n  Saldo atual: {account.Balance:C}");