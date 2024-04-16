using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetherStation
{
    class NewsTranmitter :IObserverable<Person,Weather>
    {
        List<Person> persons = new List<Person>();
        public void AddObserver(Person observer)
        {
            persons.Add(observer);
        }

        public void RemoveObserver(Person observer)
        {
            persons.Remove(observer);

        }

        public void GetNews(Weather data)
        {
            NotifyObserver(data);
        }

        public void NotifyObserver(Weather data)
        {
            foreach(Person person in persons)
            {
                person.Update(data);
            }
        }
    }
}
