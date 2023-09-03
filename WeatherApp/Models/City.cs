using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class City
    {
        public string Name { get; set; }
        public double temperature { get; set; }
        public int Humidity { get; set; }
        public int pressure { get; set; }
        public double wind { get; set; }
        public string weather { get; set; }
    }
}
