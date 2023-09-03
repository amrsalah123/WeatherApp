using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherData;

namespace WeatherApp.Models.Repository
{
  public  interface IWeatherRepository
    {
        WeatherResponse Get_data(string city_name);
    }
}
