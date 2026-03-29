using System;

namespace Zadanie_03
{
    public class Developer : Employee
    {
        private string programmingLanguage;
        private int yearsOfExperience;
        private const double BonusPercentage = 0.15;

        public Developer(string name, string id, double salary, DateTime hireDate,
                        string programmingLanguage, int yearsOfExperience)
            : base(name, id, salary, hireDate)
        {
            this.programmingLanguage = programmingLanguage;
            this.yearsOfExperience = yearsOfExperience;
        }

        public override string GetPosition() => "Programista";

        public override string GetDepartment() => "IT";

        public override double CalculateBonus()
        {
            double baseBonus = salary * BonusPercentage;
            double experienceBonus = yearsOfExperience * 200;
            return baseBonus + experienceBonus;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Główny język programowania: {programmingLanguage}");
            Console.WriteLine($"Lata doświadczenia: {yearsOfExperience}");
        }

        public string ProgrammingLanguage => programmingLanguage;
        public int YearsOfExperience => yearsOfExperience;
    }
}
