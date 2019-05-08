namespace _06_CompanyRoster_
{
    using System.Collections.Generic;
    using System.Linq;

    public class Department
    {
        private List<Employee> employees;

        public Department(string name)
        {
            this.employees = new List<Employee>();
            this.Name = name;
        }

        public string Name { get; set; }

        public List<Employee> Employees { get => this.employees; set => this.employees = value; }

        public double AverageSalary => this.Employees.Average(e => e.Salary);
    }
}
