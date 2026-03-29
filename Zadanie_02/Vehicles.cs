using System;

namespace Zadanie_02
{
    public class Vehicles
    {
        protected string name;
        protected string manufacturer;
        protected string id;
        protected double mileage;
        protected int years;

        public Vehicles()
        {
            name = "";
            manufacturer = "";
            id = "";
            mileage = 0;
            years = 0;
        }

        public virtual void Read()
        {
            Console.WriteLine("WPROWADZANIE DANYCH POJAZDU");

            name = ReadNonEmptyString("Podaj nazwę pojazdu: ");
            manufacturer = ReadNonEmptyString("Podaj producenta: ");
            id = ReadNonEmptyString("Podaj ID pojazdu: ");
            mileage = ReadPositiveDouble("Podaj przebieg (km): ");
            years = ReadPositiveInt("Podaj rok produkcji: ");
        }

        public virtual void Show()
        {
            Console.WriteLine("DANE POJAZDU");
            Console.WriteLine($"Nazwa:       {name}");
            Console.WriteLine($"Producent:   {manufacturer}");
            Console.WriteLine($"ID:          {id}");
            Console.WriteLine($"Przebieg:    {mileage:F2} km");
            Console.WriteLine($"Rok produkcji: {years}");
        }

        protected string ReadNonEmptyString(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Błąd: Pole nie może być puste. Spróbuj ponownie.");
                        continue;
                    }

                    return input;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }
        }

        protected double ReadPositiveDouble(string prompt)
        {
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

                    double value = double.Parse(input);

                    if (value < 0)
                    {
                        Console.WriteLine("Błąd: Wartość nie może być ujemna.");
                        continue;
                    }

                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: Wprowadzono niepoprawny format liczby. Spróbuj ponownie.");
                }
            }
        }

        protected int ReadPositiveInt(string prompt)
        {
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

                    int value = int.Parse(input);

                    if (value <= 0)
                    {
                        Console.WriteLine("Błąd: Wartość musi być większa od zera.");
                        continue;
                    }

                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: Wprowadzono niepoprawny format liczby całkowitej. Spróbuj ponownie.");
                }
            }
        }
    }
}
