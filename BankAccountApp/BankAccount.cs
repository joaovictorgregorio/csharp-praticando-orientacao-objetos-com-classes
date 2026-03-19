namespace BankAccountApp
{
    public class BankAccount
    {
        public BankAccount(string? accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public string? AccountNumber { get; set; }
        public double Balance { get; set; }

        public void Deposit(double value) => Balance += value;
    }
}
