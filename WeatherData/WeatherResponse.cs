using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherData
{
 public   class WeatherResponse
    {
        public Clouds cloud { get; set; }
        public Wind wind { get; set; }
        public Sys sys { get; set; }
        public Main main { get; set; }
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }


    }
}
