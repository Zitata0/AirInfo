
namespace AirInfo.Data
{
    internal class Airport
    {
        private int id;
        private string name;
        private string iataCode;
        private string icaoCode;
        private float lat;
        private float lng;
        private string countryCode;

        public override string ToString()
        {
            return this.name;
        }
        public Airport(
            int id,
            string name,
            string iataCode,
            string icaoCode,
            float lat,
            float lng,
            string countryCode
            )
        {
            this.id = id;
            this.name = name;
            this.iataCode = iataCode;
            this.icaoCode = icaoCode;
            this.lat = lat;
            this.lng = lng;
            this.countryCode = countryCode;
        }
        public int Id
        {
            get { return this.id; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public string IataCode
        {
            get { return this.iataCode; }
        }
        public string IcaoCode
        {
            get { return this.icaoCode; }
        }
        public double Lat
        {
            get { return this.lat; }
        }
        public double Lng
        {
            get { return this.lng; }
        }
        public string CountryCode
        {
            get { return this.countryCode; }
        }
    }
}
