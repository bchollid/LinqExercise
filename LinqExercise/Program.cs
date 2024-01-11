using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {

            Console.WriteLine($"Sum: {numbers.Sum()}");

            Console.WriteLine($"Average: {numbers.Average()}");

            Console.WriteLine("-------------");
            Console.WriteLine("Numbers ordered in ascending order:");

            var orderedNumbersAscending = numbers.OrderBy(number => number);
            foreach(var number in orderedNumbersAscending)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-------------");
            Console.WriteLine("Numbers ordered in descending order:");

            var orderedNumbersDescending = numbers.OrderByDescending(number => number);
            foreach(var number in orderedNumbersDescending)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-------------");
            Console.WriteLine("Only numbers greater than six:");

            var onlyNumbersGreaterThanSix = numbers.Where(number => number > 6);
            foreach (var number in onlyNumbersGreaterThanSix)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-------------");
            Console.WriteLine("Only 4 numbers from ascending list:");
            var onlyFourNumbers = orderedNumbersAscending.Take(4);
            foreach (var number in onlyFourNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-------------");
            Console.WriteLine("New descending list with my age replacing the number at index position 4:");
            numbers[4] = 30;
            var includingMyAge = numbers.OrderByDescending(number => number);
            foreach(var number in includingMyAge)
            {
                Console.WriteLine(number);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            Console.WriteLine("-------");
            Console.WriteLine("Employees full names only if first name starts with a C or S, and ordered in ascending order.");
            var sortedCOrSFirstNames = employees.Where(employee => employee.FirstName.StartsWith('C') || employee.FirstName.StartsWith('S')).OrderBy(person => person.FirstName);
            foreach(var person in sortedCOrSFirstNames)
            {
                Console.WriteLine(person.FullName);
            }

            Console.WriteLine("-------");
            Console.WriteLine("employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.");
            var sortedByAge = employees.Where(employee => employee.Age > 26).OrderBy(employee => employee.Age).OrderBy(employee => employee.FirstName);
            foreach(var person in sortedByAge)
            {
                Console.WriteLine(person.FullName);
            }

            Console.WriteLine("-------");
            Console.WriteLine("Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.");

            var filteredByYOE = employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35);
            var sumOfYOE = employees.Sum(employee => employee.YearsOfExperience);
            Console.WriteLine(sumOfYOE);

            Console.WriteLine("-------");
            Console.WriteLine("print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35");

            var averageOfYOE = employees.Average(employee => employee.YearsOfExperience);
            Console.WriteLine(averageOfYOE);

            employees.Append(new Employee("Brandon", "Holliday", 30, 2)).ToList();

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
