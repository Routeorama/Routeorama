
namespace Routeorama.Models
{
    public class Place
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int userId { get; set; }
        public int followCount { get; set; }
        public Location location { get; set; }
        
        
        public override string ToString()
        {
            return name + description + userId + location + id + followCount;
        }
    }
}