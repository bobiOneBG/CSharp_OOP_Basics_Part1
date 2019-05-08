namespace _06_CompanyRoster_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            HashSet<Department> departments = new HashSet<Department>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var empData = Console.ReadLine().Split();
                Employee employee = CreateEmployee(empData);
                AddEmployeeToDepartment(departments, empData, employee);
            }

            
            var maxAverageSalaryDepartment = departments.OrderByDescending(d => d.AverageSalary).First();

            Console.WriteLine($"Highest Average Salary: {maxAverageSalaryDepartment.Name}");

            foreach (var employee in maxAverageSalaryDepartment.Employees.
                OrderByDescending(e => e.Salary))
            {
                Console.WriteLine(EmployeeToString(employee));
            }
        }

        private static string EmployeeToString(Employee employee)
        {
            return $"{employee.Name} {employee.Salary} {employee.Email} {employee.Age}";
        }

        private static void AddEmployeeToDepartment(HashSet<Department> departments, string[] empData, Employee employee)
        {
            var department = empData[3];

            if (!departments.Any(d => d.Name == department))
            {
                Department departmnt = new Department(department);
                departments.Add(departmnt);
            }

            departments.First(d => d.Name == department).Employees.Add(employee);
        }

        private static Employee CreateEmployee(string[] empData)
        {
            var name = empData[0];
            var salary = double.Parse(empData[1]);
            var email = "n/a";
            var age = "-1";

            if (empData.Length == 5)
            {
                if (empData[4].Contains("@"))
                {
                    email = empData[4];
                }

                else
                {
                    age = empData[4];
                }
            }

            else if (empData.Length == 6)
            {
                email = empData[4];
                age = empData[5];
            }

            Employee employee = new Employee(name, salary, email, age);
            return employee;
        }
    }
}
