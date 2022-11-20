namespace BusinessModel
{
    public class Shelf
    {
        public string Kind { get; set; }
        public int TotalItems { get; set; }
        public List<Book> Items { get; set; }
    }
}