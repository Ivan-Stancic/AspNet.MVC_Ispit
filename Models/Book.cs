namespace AspNet.MVC.Models
{
    public class Book : Author
    {
        public int id { get; set; }
        public string Naslov { get; set; }
        public string Zanr { get; set; }
        public Author Pisac { get; set; }
    }
}
