using System;

namespace Zadanie_01
{
    public class Ellipse : Shape
    {
        protected double a;
        protected double b;
        protected double area;
        protected double perimeter;

        public Ellipse()
        {
            a = 0;
            b = 0;
            area = 0;
            perimeter = 0;
        }

        public override void ReadData()
        {
            Console.WriteLine("WPROWADZANIE DANYCH ELIPSY");
            a = ReadPositiveDouble("Podaj półoś wielką a: ");
            b = ReadPositiveDouble("Podaj półoś małą b: ");
        }

        public override void ProcessData()
        {
            area = Math.PI * a * b;

            double h = Math.Pow(a - b, 2) / Math.Pow(a + b, 2);
            perimeter = Math.PI * (a + b) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
        }

        public override void ShowResults()
        {
            Console.WriteLine("WYNIKI ELIPSY");
            Console.WriteLine($"Półoś wielka (a):   {a:F2}");
            Console.WriteLine($"Półoś mała (b):     {b:F2}");
            Console.WriteLine($"Pole:               {area:F2}");
            Console.WriteLine($"Obwód (przybliżony):{perimeter:F2}");
        }
    }
}
