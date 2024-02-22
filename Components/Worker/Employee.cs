
namespace ParhamTestBlazor.Components.Worker
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname { get { return $"{Firstname} {Lastname}"; } }

        public Employee(string firstname, string lastname)
        {
            Firstname = firstname ?? "";
            Lastname = lastname ?? "";
        }
    }
}
