using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    public class Weather
    {

        public decimal Temperature { get; set; }
        public DateTime Day { get; set; }
        public Precipitation Precipitation { get; set; }
        public Weather(decimal temperature, DateTime day, Precipitation precipitation)
        {
            Temperature = temperature;
            Day = day;
            Precipitation = precipitation;
        }
    }
}
