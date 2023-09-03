using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherData;
using WeatherApp.Models.Repository;
namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherRepository weatherRepository;

        public WeatherController(IWeatherRepository weatherRepository)
        {
            this.weatherRepository = weatherRepository;
        }
        public IActionResult Search() => View();
        [HttpPost]
        public IActionResult Search(SearchByCity city)
        {
            if (ModelState.IsValid)
                 return RedirectToAction("getdata", new {name=city.cityname });
            else
                 return View(city);
        }
        
        public IActionResult getdata(string name)
        {
            var city = new City();
            WeatherResponse weatherResponse = weatherRepository.Get_data(name);
            if (weatherResponse != null)
            {
                city.Name = name;
                city.temperature = weatherResponse.main.temp;
                city.Humidity = weatherResponse.main.humidity;
                city.pressure = weatherResponse.main.pressure;
                city.weather = weatherResponse.weather[0].main;
                city.wind = weatherResponse.wind.speed;
            }
            return View(city);

        }

    }
}
