namespace ParhamTestBlazor.Components.Worker
{
    public class Boss : Employee
    {
        public double Salary { get; set; }
        public string Department { get; set; }

        public Boss(string firstname, string lastname, double salary, string department) : base(firstname, lastname)
        {
            Salary = salary;
            Department = department;
        }
    }
}
