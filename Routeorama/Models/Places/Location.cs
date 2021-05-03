namespace Routeorama.Models
{
    public class Location
    {
        public string country { get; set; }
        public string city { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }

        public override string ToString()
        {
            return country + city + lat + lng;
        }
    }
}