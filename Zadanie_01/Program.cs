using System;

namespace Zadanie_01
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
                        HandleEllipse();
                        break;
                    case "2":
                        HandleCircle();
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
            Console.WriteLine("OBLICZANIE POLA I OBWODU FIGUR GEOMETRYCZNYCH");
            Console.WriteLine("1. Oblicz dla elipsy");
            Console.WriteLine("2. Oblicz dla koła");
            Console.WriteLine("3. Wyjście");
            Console.Write("Wybierz opcję (1-3): ");
        }

        static void HandleEllipse()
        {
            Console.Clear();
            Ellipse ellipse = new Ellipse();
            ellipse.ReadData();
            ellipse.ProcessData();
            ellipse.ShowResults();
        }

        static void HandleCircle()
        {
            Console.Clear();
            Circle circle = new Circle();
            circle.ReadData();
            circle.ProcessData();
            circle.ShowResults();
        }
    }
}
