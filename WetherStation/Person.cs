using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetherStation
{
    class Person :IObserver<Weather>
    {
        private string name;
        private string city;

        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }

        public Person(string personName, string cityName )
        {
            Name = personName;
            City = cityName;
        }

        public void Update(Weather data)
            
        {
            if (data.City == City)
            {
                Console.WriteLine($"Hi {Name}! die maximale Tepm: {data.Max_temp} und die minimale Temp : {data.Min_temp} in der Stadt '{data.City}' am : {data.CurrentDate} ist ");
            }
           
        }
    }
}
