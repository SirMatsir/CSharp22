namespace HomeworkAss2.Models
{
    public class Contact : IComparable
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int? Id { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
