using System;

namespace Zadanie_01
{
    public abstract class Shape
    {
        public abstract void ReadData();

        public abstract void ProcessData();

        public abstract void ShowResults();

        protected double ReadPositiveDouble(string prompt)
        {
            double value;
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Błąd: Wprowadź wartość liczbową.");
                        continue;
                    }

                    value = double.Parse(input);

                    if (value <= 0)
                    {
                        Console.WriteLine("Błąd: Wartość musi być większa od zera.");
                        continue;
                    }

                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: Wprowadzono niepoprawny format liczby. Spróbuj ponownie.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }
        }
    }
}
