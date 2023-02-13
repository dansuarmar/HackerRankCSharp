using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class CSharpEmployeesManagement
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            return employees.OrderBy(m => m.Company).GroupBy(m => m.Company)
                .ToDictionary(g => g.Key, g => Convert.ToInt32(g.Average(v => v.Age)));
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            return employees.OrderBy(m => m.Company).GroupBy(m => m.Company)
                .ToDictionary(g => g.Key, g => g.Count());
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            return employees.OrderBy(m => m.Company).GroupBy(m => m.Company)
                .ToDictionary(g => g.Key, g => g.OrderByDescending(m => m.Age).FirstOrDefault());
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}
