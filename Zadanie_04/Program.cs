using System;

namespace Zadanie_04
{
    public class Program
    {
        private static BankAccount account;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            InitializeAccount();
            bool running = true;

            while (running)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        account.DisplayAccountInfo();
                        break;
                    case "2":
                        PerformDeposit();
                        break;
                    case "3":
                        PerformWithdraw();
                        break;
                    case "4":
                        ConvertCurrency();
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Do widzenia!");
                        break;
                    default:
                        Console.WriteLine("Błąd: Wybierz opcję 1-5.");
                        break;
                }

                if (running && choice != "5")
                {
                    Console.WriteLine("Naciśnij Enter...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("SYSTEM BANKOWY");
            Console.WriteLine("Konto: " + account.GetAccountNumber());
            Console.WriteLine("Saldo: " + account.GetBalance().ToString("F2") + " PLN");
            Console.WriteLine("1. Wyświetl informacje");
            Console.WriteLine("2. Wpłata");
            Console.WriteLine("3. Wypłata");
            Console.WriteLine("4. Przewalutowanie");
            Console.WriteLine("5. Wyjście");
            Console.Write("Wybór: ");
        }

        static void PerformDeposit()
        {
            Console.Clear();
            try
            {
                decimal amount = ReadPositiveDecimal("Podaj kwotę do wpłaty: ");
                account.Deposit(amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
            }
        }

        static void PerformWithdraw()
        {
            Console.Clear();
            try
            {
                decimal amount = ReadPositiveDecimal("Podaj kwotę do wypłaty: ");
                account.Withdraw(amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
            }
        }

        static void ConvertCurrency()
        {
            Console.Clear();
            Console.WriteLine("PRZEWALUTOWANIE");
            Console.WriteLine("Saldo aktualne (PLN): " + account.GetBalance().ToString("F2"));
            Console.WriteLine("Jakiej waluty chcesz?");
            Console.WriteLine("1. EUR (Euro)");
            Console.WriteLine("2. USD (Dolar)");
            Console.Write("Wybór: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Saldo w EUR: " + account.ConvertToEUR().ToString("F2"));
                    break;
                case "2":
                    Console.WriteLine("Saldo w USD: " + account.ConvertToUSD().ToString("F2"));
                    break;
                default:
                    Console.WriteLine("Zła opcja");
                    break;
            }

            Console.WriteLine("Co dalej?");
            Console.WriteLine("1. Konwertuj konkretną kwotę");
            Console.WriteLine("2. Powrót do menu");
            Console.Write("Wybór: ");

            string next = Console.ReadLine();
            if (next == "1")
            {
                ConvertSpecificAmount();
            }
        }

        static void ConvertSpecificAmount()
        {
            Console.WriteLine("KONWERSJA KONKRETNEJ KWOTY");
            Console.WriteLine("Z której waluty?");
            Console.WriteLine("1. PLN");
            Console.WriteLine("2. EUR");
            Console.WriteLine("3. USD");
            Console.Write("Wybór: ");

            string from = Console.ReadLine();

            Console.WriteLine("Na jaką walutę?");
            Console.WriteLine("1. PLN");
            Console.WriteLine("2. EUR");
            Console.WriteLine("3. USD");
            Console.Write("Wybór: ");

            string to = Console.ReadLine();

            decimal amount = ReadPositiveDecimal("Podaj kwotę: ");

            try
            {
                decimal result = 0;

                if (from == "1" && to == "2")
                    result = account.ConvertPLNToEUR(amount);
                else if (from == "1" && to == "3")
                    result = account.ConvertPLNToUSD(amount);
                else if (from == "2" && to == "1")
                    result = account.ConvertEURToPLN(amount);
                else if (from == "2" && to == "3")
                    result = account.ConvertEURToUSD(amount);
                else if (from == "3" && to == "1")
                    result = account.ConvertUSDToPLN(amount);
                else if (from == "3" && to == "2")
                    result = account.ConvertUSDToEUR(amount);
                else if (from == to)
                {
                    result = amount;
                    Console.WriteLine("Waluty są takie same!");
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa kombinacja walut.");
                    return;
                }

                Console.WriteLine("Wynik: " + result.ToString("F2"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
            }
        }

        static void InitializeAccount()
        {
            try
            {
                string accountNum = ReadNonEmptyString("Podaj numer konta: ");
                decimal initialBalance = ReadPositiveDecimal("Podaj saldo początkowe: ");
                account = new BankAccount(accountNum, initialBalance);
                Console.Clear();
                account.DisplayAccountInfo();
                Console.WriteLine("Naciśnij Enter...");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
                account = new BankAccount("DEFAULT123", 1000);
            }
        }

        static string ReadNonEmptyString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input;
                Console.WriteLine("Pole nie może być puste.");
            }
        }

        static decimal ReadPositiveDecimal(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Wprowadź liczbę.");
                        continue;
                    }
                    decimal value = decimal.Parse(input);
                    if (value <= 0)
                    {
                        Console.WriteLine("Wartość musi być większa od zera.");
                        continue;
                    }
                    return value;
                }
                catch
                {
                    Console.WriteLine("Błąd formatu liczby.");
                }
            }
        }
    }
}
