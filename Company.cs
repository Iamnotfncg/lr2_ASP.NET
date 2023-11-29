namespace pr2
{
    internal class Company
    {
        public string? Title { get; set; }
        public string? Location { get; set; }
        public int Employees { get; set; }

        public override string ToString() => $"Title: {Title}\n" +
                                             $"Location: {Location}\n" +
                                             $"Employees: {Employees}\n";
    }
}