namespace Routeorama.Models
{
    public class Place
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public Location Location { get; set; }
        public int Id { get; set; }
    }
}