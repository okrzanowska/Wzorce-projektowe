using System;

namespace Zadanie_04
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        private const decimal EUR_TO_PLN = 4.50m;
        private const decimal USD_TO_PLN = 4.00m;
        private const decimal PLN_TO_EUR = 1 / 4.50m;
        private const decimal PLN_TO_USD = 1 / 4.00m;
        private const decimal EUR_TO_USD = 4.00m / 4.50m;
        private const decimal USD_TO_EUR = 4.50m / 4.00m;

        public BankAccount(string accountNumber, decimal initialBalance = 0)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentException("Numer konta nie może być pusty.");
            if (initialBalance < 0)
                throw new ArgumentException("Saldo początkowe nie może być ujemne.");

            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Kwota musi być większa od zera.");

            balance += amount;
            Console.WriteLine("Wpłacono: " + amount.ToString("F2") + " PLN");
            Console.WriteLine("Nowe saldo: " + balance.ToString("F2") + " PLN");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Kwota musi być większa od zera.");

            if (amount > balance)
                throw new InvalidOperationException("Niewystarczające saldo. Dostępne: " + balance.ToString("F2") + " PLN");

            balance -= amount;
            Console.WriteLine("Wypłacono: " + amount.ToString("F2") + " PLN");
            Console.WriteLine("Nowe saldo: " + balance.ToString("F2") + " PLN");
        }

        public decimal ConvertToEUR()
        {
            return balance * PLN_TO_EUR;
        }

        public decimal ConvertToUSD()
        {
            return balance * PLN_TO_USD;
        }

        public decimal ConvertPLNToEUR(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Kwota nie może być ujemna.");
            return amount * PLN_TO_EUR;
        }

        public decimal ConvertPLNToUSD(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Kwota nie może być ujemna.");
            return amount * PLN_TO_USD;
        }

        public decimal ConvertEURToPLN(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Kwota nie może być ujemna.");
            return amount * EUR_TO_PLN;
        }

        public decimal ConvertUSDToPLN(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Kwota nie może być ujemna.");
            return amount * USD_TO_PLN;
        }

        public decimal ConvertEURToUSD(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Kwota nie może być ujemna.");
            return amount * EUR_TO_USD;
        }

        public decimal ConvertUSDToEUR(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Kwota nie może być ujemna.");
            return amount * USD_TO_EUR;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine("INFORMACJE O KONCIE BANKOWYM");
            Console.WriteLine("Numer konta: " + accountNumber);
            Console.WriteLine("Saldo (PLN): " + balance.ToString("F2"));
            Console.WriteLine("Saldo (EUR): " + ConvertToEUR().ToString("F2"));
            Console.WriteLine("Saldo (USD): " + ConvertToUSD().ToString("F2"));
        }

        public void ResetBalance()
        {
            balance = 0;
            Console.WriteLine("Saldo zostało zresetowane.");
        }
    }
}
