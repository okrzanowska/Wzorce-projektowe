using System;

namespace Zadanie_03
{
    public class HR_Specialist : Employee
    {
        private string specialization;
        private const double BonusPercentage = 0.10;

        public HR_Specialist(string name, string id, double salary, DateTime hireDate, string specialization)
            : base(name, id, salary, hireDate)
        {
            this.specialization = specialization;
        }

        public override string GetPosition() => "Specjalista HR";

        public override string GetDepartment() => "HR";

        public override double CalculateBonus()
        {
            return salary * BonusPercentage;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Specjalizacja: {specialization}");
        }

        public string Specialization => specialization;
    }
}
