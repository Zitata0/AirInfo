
using AirInfo.Data;
using RestSharp;
using System.Text.Json.Nodes;

namespace ConsoleApp
{
    internal class Parser
    {
        private string APIKey;

        public Parser(string APIKey)
        {
            this.APIKey = APIKey;    
        }
        public Airport[] ParseAirports()
        {
            string url = "https://airlabs.co/api/v9/airports.json?api_key=" + APIKey;
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(url);
            RestResponse response = client.Get(request);

            JsonNode? jsonNode = JsonNode.Parse(response.Content);
            if (jsonNode == null)
            {
                return null;
            }

            JsonArray jsonArray = jsonNode["response"].AsArray();
            Airport[] airports = new Airport[jsonArray.Count];
            for (int i = 0; i < jsonArray.Count; i++)
            {
                airports[i] = new Airport(i,
                    jsonArray[i].AsObject().ContainsKey("name") ? jsonArray[i]["name"].ToString() : "",
                    jsonArray[i].AsObject().ContainsKey("iata_code") ? jsonArray[i]["iata_code"].ToString() : "",
                    jsonArray[i].AsObject().ContainsKey("icao_code") ? jsonArray[i]["icao_code"].ToString() : "",
                    jsonArray[i].AsObject().ContainsKey("lat") ? (float)jsonArray[i]["lat"] : 0f,
                    jsonArray[i].AsObject().ContainsKey("lng") ? (float)jsonArray[i]["lng"] : 0f,
                    jsonArray[i].AsObject().ContainsKey("country_code") ? jsonArray[i]["country_code"].ToString() : ""
                    );
            }
            return airports;
        }
        public City[] ParseCities()
        {
            string url = "https://airlabs.co/api/v9/cities.json?api_key=" + APIKey;
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(url);
            RestResponse response = client.Get(request);

            JsonNode? jsonNode = JsonNode.Parse(response.Content);
            if (jsonNode == null)
            {
                return null;
            }

            JsonArray jsonArray = jsonNode["response"].AsArray();
            City[] cities = new City[jsonArray.Count];
            for (int i = 0; i < jsonArray.Count; i++)
            {
                cities[i] = new City(i,
                    jsonArray[i].AsObject().ContainsKey("name") ? jsonArray[i]["name"].ToString() : "",
                    jsonArray[i].AsObject().ContainsKey("city_code") ? jsonArray[i]["city_code"].ToString() : "",
                    jsonArray[i].AsObject().ContainsKey("lat") ? (float)jsonArray[i]["lat"] : 0f,
                    jsonArray[i].AsObject().ContainsKey("lng") ? (float)jsonArray[i]["lng"] : 0f,
                    jsonArray[i].AsObject().ContainsKey("country_code") ? jsonArray[i]["country_code"].ToString() : ""
                    );
            }
            return cities;
        }
        public Schedules[] ParseSchedules(Airport airport)
        {
            string url = "https://airlabs.co/api/v9/schedules.json?api_key=" + APIKey + (airport.IataCode.Length == 0 ? "&dep_icao=" + airport.IcaoCode : "&dep_iata=" + airport.IataCode);
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(url);
            RestResponse response = client.Get(request);

            JsonNode? jsonNode = JsonNode.Parse(response.Content);
            if (jsonNode == null)
            {
                return null;
            }  

            JsonArray jsonArray = jsonNode["response"].AsArray();
            Schedules[] schedules = new Schedules[jsonArray.Count];
            for (int i = 0; i < jsonArray.Count; i++)
            {
                JsonObject jsonObject = jsonArray[i].AsObject();
                schedules[i] = new Schedules(i,
                    jsonObject.ContainsKey("airline_iata") && jsonObject["airline_iata"] != null ? jsonObject["airline_iata"].ToString() : "",
                    jsonObject.ContainsKey("airline_icao") && jsonObject["airline_icao"] != null ? jsonObject["airline_icao"].ToString() : "",

                    jsonObject.ContainsKey("flight_iata") && jsonObject["flight_iata"] != null ? jsonObject["flight_iata"].ToString() : "",
                    jsonObject.ContainsKey("flight_icao") && jsonObject["flight_icao"] != null ? jsonObject["flight_icao"].ToString() : "",
                    jsonObject.ContainsKey("flight_number") && jsonObject["flight_number"] != null ? jsonObject["flight_number"].ToString() : "",

                    jsonObject.ContainsKey("dep_iata") && jsonObject["dep_iata"] != null ? jsonObject["dep_iata"].ToString() : "",
                    jsonObject.ContainsKey("dep_icao") && jsonObject["dep_icao"] != null ? jsonObject["dep_icao"].ToString() : "",
                    jsonObject.ContainsKey("dep_terminal") && jsonObject["dep_terminal"] != null ? jsonObject["dep_terminal"].ToString() : "",
                    jsonObject.ContainsKey("dep_gate") && jsonObject["dep_gate"] != null ? jsonObject["dep_gate"].ToString() : "",
                    jsonObject.ContainsKey("dep_time") && jsonObject["dep_time"] != null ? jsonObject["dep_time"].ToString() : "",
                    jsonObject.ContainsKey("dep_time_utc") && jsonObject["dep_time_utc"] != null ? jsonObject["dep_time_utc"].ToString() : "",
                    jsonObject.ContainsKey("dep_estimated") && jsonObject["dep_estimated"] != null ? jsonObject["dep_estimated"].ToString() : "",
                    jsonObject.ContainsKey("dep_estimated_utc") && jsonObject["dep_estimated_utc"] != null ? jsonObject["dep_estimated_utc"].ToString() : "",
                    jsonObject.ContainsKey("dep_actual") && jsonObject["dep_actual"] != null ? jsonObject["dep_actual"].ToString() : "",
                    jsonObject.ContainsKey("dep_actual_utc") && jsonObject["dep_actual_utc"] != null ? jsonObject["dep_actual_utc"].ToString() : "",

                    jsonObject.ContainsKey("arr_iata") && jsonObject["arr_iata"] != null ? jsonObject["arr_iata"].ToString() : "",
                    jsonObject.ContainsKey("arr_icao") && jsonObject["arr_icao"] != null ? jsonObject["arr_icao"].ToString() : "",
                    jsonObject.ContainsKey("arr_terminal") && jsonObject["arr_terminal"] != null ? jsonObject["arr_terminal"].ToString() : "",
                    jsonObject.ContainsKey("arr_gate") && jsonObject["arr_gate"] != null ? jsonObject["arr_gate"].ToString() : "",
                    jsonObject.ContainsKey("arr_baggage") && jsonObject["arr_baggage"] != null ? jsonObject["arr_baggage"].ToString() : "",
                    jsonObject.ContainsKey("arr_time") && jsonObject["arr_time"] != null ? jsonObject["arr_time"].ToString() : "",
                    jsonObject.ContainsKey("arr_time_utc") && jsonObject["arr_time_utc"] != null ? jsonObject["arr_time_utc"].ToString() : "",
                    jsonObject.ContainsKey("arr_estimated") && jsonObject["arr_estimated"] != null ? jsonObject["arr_estimated"].ToString() : "",
                    jsonObject.ContainsKey("arr_estimated_utc") && jsonObject["arr_estimated_utc"] != null ? jsonObject["arr_estimated_utc"].ToString() : "",

                    jsonObject.ContainsKey("cs_airline_iata") && jsonObject["cs_airline_iata"] != null ? jsonObject["cs_airline_iata"].ToString() : "",
                    jsonObject.ContainsKey("cs_flight_number") && jsonObject["cs_flight_number"] != null ? jsonObject["cs_flight_number"].ToString() : "",
                    jsonObject.ContainsKey("cs_flight_iata") && jsonObject["cs_flight_iata"] != null ? jsonObject["cs_flight_iata"].ToString() : "",
                    (jsonObject.ContainsKey("aircraft_icao") && jsonObject["aircraft_icao"] != null ? jsonObject["aircraft_icao"] : "").ToString(),

                    jsonObject.ContainsKey("status") && jsonObject["status"] != null ? jsonObject["status"].ToString() : "",

                    (jsonObject.ContainsKey("duration") && jsonObject["duration"] != null ? jsonObject["duration"] : -1).GetValue<int>(),
                    (jsonObject.ContainsKey("delayed") && jsonObject["delayed"] != null ? jsonObject["delayed"] : -1).GetValue<int>(),
                    (jsonObject.ContainsKey("dep_delayed") && jsonObject["dep_delayed"] != null ? jsonObject["dep_delayed"] : -1).GetValue<int>(),
                    (jsonObject.ContainsKey("arr_delayed") && jsonObject["arr_delayed"] != null ? jsonObject["arr_delayed"] : -1).GetValue<int>(),

                    (jsonObject.ContainsKey("arr_time_ts") && jsonObject["arr_time_ts"] != null ? jsonObject["arr_time_ts"] : -1).GetValue<int>(),
                    (jsonObject.ContainsKey("dep_time_ts") && jsonObject["dep_time_ts"] != null ? jsonObject["dep_time_ts"] : -1).GetValue<int>(),
                    (jsonObject.ContainsKey("arr_estimated_ts") && jsonObject["arr_estimated_ts"] != null ? jsonObject["arr_estimated_ts"] : -1).GetValue<int>(),
                    (jsonObject.ContainsKey("dep_estimated_ts") && jsonObject["dep_estimated_ts"] != null ? jsonObject["dep_estimated_ts"] : -1).GetValue<int>(),
                    (jsonObject.ContainsKey("arr_actual_ts") && jsonObject["arr_actual_ts"] != null ? jsonObject["arr_actual_ts"] : -1).GetValue<int>(),
                    (jsonObject.ContainsKey("dep_actual_ts") && jsonObject["dep_actual_ts"] != null ? jsonObject["dep_actual_ts"] : -1).GetValue<int>()
                    );
            }
            return schedules;
        }
    }
}
