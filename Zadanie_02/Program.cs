using System;

namespace Zadanie_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool running = true;

            while (running)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HandleVehicles();
                        break;
                    case "2":
                        HandleCars();
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Do widzenia!");
                        break;
                    default:
                        Console.WriteLine("Błąd: Wybierz opcję 1, 2 lub 3.");
                        break;
                }

                if (running && (choice == "1" || choice == "2"))
                {
                    Console.WriteLine("Naciśnij Enter, aby wrócić do menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (running)
                {
                    Console.Clear();
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("ZARZĄDZANIE POJAZDAMI");
            Console.WriteLine("1. Wprowadź dane pojazdu");
            Console.WriteLine("2. Wprowadź rozszerzone dane pojazdu");
            Console.WriteLine("3. Wyjście");
            Console.Write("Wybierz opcję (1-3): ");
        }

        static void HandleVehicles()
        {
            Console.Clear();
            Vehicles vehicle = new Vehicles();
            vehicle.Read();
            vehicle.Show();
        }

        static void HandleCars()
        {
            Console.Clear();
            Cars car = new Cars();
            car.Read();
            car.Show();
        }
    }
}
