using System;

namespace Zadanie_01
{
    public class Circle : Ellipse
    {
        private double radius;

        public Circle()
        {
            radius = 0;
            a = 0;
            b = 0;
            area = 0;
            perimeter = 0;
        }

        public override void ReadData()
        {
            Console.WriteLine("WPROWADZANIE DANYCH KOŁA");
            radius = ReadPositiveDouble("Podaj promień koła (r): ");

            a = radius;
            b = radius;
        }

        public override void ProcessData()
        {
            area = Math.PI * radius * radius;

            perimeter = 2 * Math.PI * radius;
        }

        public override void ShowResults()
        {
            Console.WriteLine("WYNIKI KOŁĄ");
            Console.WriteLine($"Promień (r):        {radius:F2}");
            Console.WriteLine($"Pole:               {area:F2}");
            Console.WriteLine($"Obwód:              {perimeter:F2}");
        }
    }
}
