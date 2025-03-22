// Usage
BankAccount account = new BankAccount();
account.Deposit(1000);
account.Withdraw(500);



public class BankAccount
{
    private double balance; // Private field to restrict direct access

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}. Balance: {balance}");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: {amount}. Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }

    public double GetBalance()
    {
        return balance; // Controlled access via a public method
    }
}

