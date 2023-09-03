using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherData;
using WeatherApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;



namespace WeatherApp.Models.Repository
{
    public class WeatherRepository : IWeatherRepository
    {
        public WeatherResponse Get_data(string city_name)
        {
            string app_id = Key.API_Key;
            var Clinet = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q={city_name}&appid={app_id}&units=metric");
            var request = new RestRequest(Method.GET);
            IRestResponse restResponse = Clinet.Execute(request);
            if (restResponse.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(restResponse.Content);
                return content.ToObject<WeatherData.WeatherResponse>();
            }
            return null;
        }
    }
}
