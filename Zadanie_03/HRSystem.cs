using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie_03
{
    public class HRSystem
    {
        private List<Employee> employees;

        public HRSystem()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine($"Pracownik {employee.Name} został dodany do systemu.");
        }

        public bool RemoveEmployee(string id)
        {
            var employee = employees.FirstOrDefault(e => e.ID == id);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine($"Pracownik {employee.Name} został usunięty z systemu.");
                return true;
            }
            Console.WriteLine("Nie znaleziono pracownika o podanym ID.");
            return false;
        }

        public void DisplayAllEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("Brak pracowników w systemie.");
                return;
            }

            Console.WriteLine("LISTA WSZYSTKICH PRACOWNIKÓW");

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.GetInfo());
            }
        }

        public void DisplayEmployeeDetails(string id)
        {
            var employee = employees.FirstOrDefault(e => e.ID == id);
            if (employee != null)
            {
                employee.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Nie znaleziono pracownika o podanym ID.");
            }
        }

        public void CalculateTotalCosts()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("Brak pracowników w systemie.");
                return;
            }

            double totalSalaries = 0;
            double totalBonuses = 0;

            foreach (var employee in employees)
            {
                totalSalaries += employee.Salary;
                totalBonuses += employee.CalculateBonus();
            }

            Console.WriteLine("KALKULACJA KOSZTÓW WYNAGRODZEŃ");
            Console.WriteLine($"Liczba pracowników: {employees.Count}");
            Console.WriteLine($"Łączne pensje:      {totalSalaries:F2} PLN");
            Console.WriteLine($"Łączne bonusy:      {totalBonuses:F2} PLN");
            double total = totalSalaries + totalBonuses;
            Console.WriteLine($"Razem:              {total:F2} PLN");
        }

        public void DisplayStatisticsByDepartment()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("Brak pracowników w systemie.");
                return;
            }

            var departmentStats = employees
                .GroupBy(e => e.GetDepartment())
                .OrderBy(g => g.Key);

            Console.WriteLine("STATYSTYKI PRACOWNIKÓW PO DZIAŁACH");

            foreach (var group in departmentStats)
            {
                double avgSalary = group.Average(e => e.Salary);
                Console.WriteLine($"{group.Key,-20} | Liczba: {group.Count(),-2} | Śr. pensja: {avgSalary:F2} PLN");
            }
        }

        public Employee FindEmployee(string id)
        {
            return employees.FirstOrDefault(e => e.ID == id);
        }

        public int EmployeeCount => employees.Count;
    }
}
