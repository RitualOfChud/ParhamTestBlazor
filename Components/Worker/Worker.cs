namespace ParhamTestBlazor.Components.Worker
{
    public class Worker : Employee
    {
        public double Wage { get; set; }

        public Worker(string firstname, string lastname, double wage) : base(firstname, lastname)
        {
            Wage = wage;
        }
    }
}
