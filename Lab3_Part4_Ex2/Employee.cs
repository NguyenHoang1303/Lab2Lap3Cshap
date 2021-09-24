namespace Lab3_Part4_Ex2
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Sin { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, Address: {Address}, Sin: {Sin}, Salary: {Salary}";
        }

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Sin = sin;
            Salary = salary;
        }

        public double Bonus(double percentage)
        {
            return Salary * percentage;
        }
    }
}