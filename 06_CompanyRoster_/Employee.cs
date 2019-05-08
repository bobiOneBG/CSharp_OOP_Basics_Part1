namespace _06_CompanyRoster_
{
    public class Employee
    {
        private string name;
        private double salary;
        private string email;
        private string age;

        public Employee(string name, double salary, 
            string email, string age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Email = email;
            this.Age = age;
        }

        public string Name { get => this.name; set => this.name = value; }
        public double Salary { get => this.salary; set => this.salary = value; }
        public string Email { get => this.email; set => this.email = value; }
        public string Age { get => this.age; set => this.age = value; }
    }
}
