namespace dotnet2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property

        internal Task<List<object>> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
