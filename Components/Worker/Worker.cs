namespace ParhamTestBlazor.Components.Worker
{
    public class Worker
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname { get { return $"{Firstname} {Lastname}"; } }
    }
}
