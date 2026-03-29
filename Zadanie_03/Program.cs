using System;

namespace Zadanie_03
{
    public class Program
    {
        private static HRSystem hrSystem;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            hrSystem = new HRSystem();
            InitializeSampleData();
            bool running = true;
            while (running)
            {
                DisplayMainMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        DisplayAllEmployees();
                        break;
                    case "2":
                        AddNewEmployee();
                        break;
                    case "3":
                        DisplayEmployeeDetails();
                        break;
                    case "4":
                        RemoveEmployee();
                        break;
                    case "5":
                        CalculateCosts();
                        break;
                    case "6":
                        DisplayStatistics();
                        break;
                    case "7":
                        running = false;
                        Console.WriteLine("Do widzenia!");
                        break;
                    default:
                        Console.WriteLine("Błąd: Wybierz 1-7.");
                        break;
                }
                if (running && choice != "7")
                {
                    Console.WriteLine("Naciśnij Enter...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("SYSTEM HR");
            Console.WriteLine("1. Wyświetl wszystkich");
            Console.WriteLine("2. Dodaj pracownika");
            Console.WriteLine("3. Szczegóły");
            Console.WriteLine("4. Usuń");
            Console.WriteLine("5. Koszty");
            Console.WriteLine("6. Statystyki");
            Console.WriteLine("7. Wyjście");
            Console.Write("Wybór: ");
        }

        static void DisplayAllEmployees()
        {
            Console.Clear();
            hrSystem.DisplayAllEmployees();
        }

        static void AddNewEmployee()
        {
            Console.Clear();
            Console.WriteLine("1. Manager 2. Developer 3. HR 4. Designer");
            Console.Write("Typ: ");
            string choice = Console.ReadLine();
            try
            {
                string name = ReadNonEmptyString("Imię: ");
                string id = ReadNonEmptyString("ID: ");
                double salary = ReadPositiveDouble("Pensja: ");
                DateTime hireDate = ReadDateTime("Data (yyyy-MM-dd): ");
                switch (choice)
                {
                    case "1":
                        int teamSize = ReadPositiveInt("Zespół: ");
                        hrSystem.AddEmployee(new Manager(name, id, salary, hireDate, teamSize));
                        break;
                    case "2":
                        string language = ReadNonEmptyString("Język: ");
                        int exp = ReadPositiveInt("Lata: ");
                        hrSystem.AddEmployee(new Developer(name, id, salary, hireDate, language, exp));
                        break;
                    case "3":
                        string spec = ReadNonEmptyString("Spec: ");
                        hrSystem.AddEmployee(new HR_Specialist(name, id, salary, hireDate, spec));
                        break;
                    case "4":
                        string design = ReadNonEmptyString("Design: ");
                        int proj = ReadPositiveInt("Projekty: ");
                        hrSystem.AddEmployee(new Designer(name, id, salary, hireDate, design, proj));
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
            }
        }

        static void DisplayEmployeeDetails()
        {
            Console.Clear();
            string id = ReadNonEmptyString("ID: ");
            hrSystem.DisplayEmployeeDetails(id);
        }

        static void RemoveEmployee()
        {
            Console.Clear();
            string id = ReadNonEmptyString("ID do usunięcia: ");
            hrSystem.RemoveEmployee(id);
        }

        static void CalculateCosts()
        {
            Console.Clear();
            hrSystem.CalculateTotalCosts();
        }

        static void DisplayStatistics()
        {
            Console.Clear();
            hrSystem.DisplayStatisticsByDepartment();
        }

        static string ReadNonEmptyString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input;
                Console.WriteLine("Puste pole");
            }
        }

        static double ReadPositiveDouble(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    double value = double.Parse(Console.ReadLine());
                    if (value > 0) return value;
                    Console.WriteLine("Musi być > 0");
                }
                catch
                {
                    Console.WriteLine("Błąd liczby");
                }
            }
        }

        static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    int value = int.Parse(Console.ReadLine());
                    if (value > 0) return value;
                    Console.WriteLine("Musi być > 0");
                }
                catch
                {
                    Console.WriteLine("Błąd liczby");
                }
            }
        }

        static DateTime ReadDateTime(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    return DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
                }
                catch
                {
                    Console.WriteLine("Błąd daty");
                }
            }
        }

        static void InitializeSampleData()
        {
            hrSystem.AddEmployee(new Manager("Jan Kowalski", "MGR001", 8000, new DateTime(2020, 3, 15), 5));
            hrSystem.AddEmployee(new Developer("Anna Nowak", "DEV001", 7000, new DateTime(2021, 6, 1), "C#", 5));
            hrSystem.AddEmployee(new Developer("Piotr Lewandowski", "DEV002", 6500, new DateTime(2022, 1, 10), "Python", 3));
            hrSystem.AddEmployee(new HR_Specialist("Maria Kaminski", "HR001", 5500, new DateTime(2021, 9, 20), "Rekrutacja"));
            hrSystem.AddEmployee(new Designer("Kasia Wozniak", "DES001", 6000, new DateTime(2020, 11, 5), "UX/UI", 12));
            Console.Clear();
            Console.WriteLine("Załadowano pracowników: " + hrSystem.EmployeeCount);
            Console.WriteLine("Naciśnij Enter...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
