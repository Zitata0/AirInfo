
namespace AirInfo.Data
{
    internal class City
    {
        private int id;
        private string name;
        private string cityCode;
        private float lat;
        private float lng;
        private string countryCode;

        public override string ToString()
        {
            return this.name;
        }
        public City(
            int id,
            string name,
            string cityCode,
            float lat,
            float lng,
            string countryCode
            )
        {
            this.id = id;
            this.name = name;
            this.cityCode = cityCode;
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
        public string CityCode
        {
            get { return this.cityCode; }
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
