namespace SeekBooks.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public string[] Categories { get; set; }
        public string Description { get; set; }
        public string ImageLinks { get; set; }
    }
}
