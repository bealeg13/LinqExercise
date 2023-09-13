using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            //Console.WriteLine(numbers.Sum());

            ////TODO: Print the Average of numbers
            //Console.WriteLine(numbers.Average());

            ////TODO: Order numbers in ascending order and print to the console
            //var ascendingOrder = numbers.OrderBy(x => x);
            //foreach (int num in  ascendingOrder)
            //{
            //    Console.WriteLine(num);
            //}
            ////TODO: Order numbers in descending order and print to the console
            //var decendingOrder = numbers.OrderByDescending(x => x);
            //foreach (int num in decendingOrder)
            //{
            //    Console.WriteLine(num);
            //}
            ////TODO: Print to the console only the numbers greater than 6
            //var numbersGreaterThan6 = numbers.Where(x => x > 6);
            //foreach (int num in numbersGreaterThan6)
            //{
            //    Console.WriteLine(num);
            //}

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            //var print4Numbers = numbers.OrderBy(x => x).Take(4);
            //foreach (int num in print4Numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            //numbers[4] = 28;
            //var changeIndexToAge = numbers.OrderByDescending(x => x);
            //foreach (int num in changeIndexToAge)
            //{
            //    Console.WriteLine(num);
            //}

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();
            var employee1 = new Employee() {Age = 28, FirstName = "Gabriel", LastName = "Bealer", YearsOfExperience = 7 };
           

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            //var nameStartsWithCOrS = employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S'));
            //foreach (var name in nameStartsWithCOrS) 
            //{ 
            //    Console.WriteLine(name.FullName); 
            
            //}



            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var olderThan26 = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var employee in olderThan26)
            {
                Console.WriteLine($"{employee.FullName} {employee.Age}");
            }


            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.


            var averageYearsOfExperience = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            var sumYearsOfExperience = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(averageYearsOfExperience);
            Console.WriteLine(sumYearsOfExperience);
            //TODO: Add an employee to the end of the list without using employees.Add()
            var mylist = employees.Append(employee1);
            foreach (var employee in mylist)
            {
                Console.WriteLine(employee.FullName);
            }

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
