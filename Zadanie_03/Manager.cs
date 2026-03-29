using System;

namespace Zadanie_03
{
    public class Manager : Employee
    {
        private int teamSize;
        private const double BonusPercentage = 0.20;

        public Manager(string name, string id, double salary, DateTime hireDate, int teamSize)
            : base(name, id, salary, hireDate)
        {
            this.teamSize = teamSize;
        }

        public override string GetPosition() => "Kierownik";

        public override string GetDepartment() => "Zarządzanie";

        public override double CalculateBonus()
        {
            double baseBonus = salary * BonusPercentage;
            double teamBonus = teamSize * 100;
            return baseBonus + teamBonus;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Rozmiar zespołu: {teamSize} osób");
        }

        public int TeamSize => teamSize;
    }
}
