using System;

namespace Zadanie_03
{
    public class Designer : Employee
    {
        private string designSpecialty;
        private int projectsCompleted;
        private const double BonusPercentage = 0.12;

        public Designer(string name, string id, double salary, DateTime hireDate,
                       string designSpecialty, int projectsCompleted)
            : base(name, id, salary, hireDate)
        {
            this.designSpecialty = designSpecialty;
            this.projectsCompleted = projectsCompleted;
        }

        public override string GetPosition() => "Projektant";

        public override string GetDepartment() => "Design";

        public override double CalculateBonus()
        {
            double baseBonus = salary * BonusPercentage;
            double projectBonus = projectsCompleted * 150;
            return baseBonus + projectBonus;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Specjalizacja projektowania: {designSpecialty}");
            Console.WriteLine($"Liczba ukończonych projektów: {projectsCompleted}");
        }

        public string DesignSpecialty => designSpecialty;
        public int ProjectsCompleted => projectsCompleted;
    }
}
