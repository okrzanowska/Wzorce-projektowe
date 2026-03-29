using System;

namespace Zadanie_03
{
    public abstract class Employee
    {
        protected string name;
        protected string id;
        protected double salary;
        protected DateTime hireDate;

        public Employee(string name, string id, double salary, DateTime hireDate)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
            this.hireDate = hireDate;
        }

        public abstract string GetPosition();

        public abstract string GetDepartment();

        public abstract double CalculateBonus();

        public virtual string GetInfo()
        {
            double bonus = CalculateBonus();
            return $"Imię: {name,-20} | ID: {id,-6} | Stanowisko: {GetPosition(),-15} | Dział: {GetDepartment(),-12} | " +
                   $"Pensja: {salary:F2} PLN | Bonus: {bonus:F2} PLN | Data zatrudnienia: {hireDate:yyyy-MM-dd}";
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("SZCZEGÓŁY PRACOWNIKA");
            Console.WriteLine($"Imię:                {name}");
            Console.WriteLine($"ID:                  {id}");
            Console.WriteLine($"Stanowisko:          {GetPosition()}");
            Console.WriteLine($"Dział:               {GetDepartment()}");
            Console.WriteLine($"Pensja:              {salary:F2} PLN");
            Console.WriteLine($"Bonus roczny:        {CalculateBonus():F2} PLN");
            Console.WriteLine($"Data zatrudnienia:   {hireDate:yyyy-MM-dd}");
        }

        public string Name => name;
        public string ID => id;
        public double Salary => salary;
        public DateTime HireDate => hireDate;
    }
}
