using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetherStation
{
    class Weather : Iweather
    {
        private double min_temp;
        private double max_temp;
        private double avg_temp;
        private string city;
        private string currentDate;

        public double Min_temp { get => min_temp; set => min_temp = value; }
        public double Max_temp { get => max_temp; set => max_temp = value; }
        public double Avg_temp { get => avg_temp; set => avg_temp = value; }
        public string City { get => city; set => city = value; }
        public string CurrentDate { get => currentDate; set => currentDate = value; }

        public Weather(double min_t, double max_t, double avg_t, string cityName, string date)
        {
            Min_temp = min_t;
            Max_temp = max_t;
            Avg_temp = avg_t;
            City = cityName;
            currentDate = date;
        }
    }
}
