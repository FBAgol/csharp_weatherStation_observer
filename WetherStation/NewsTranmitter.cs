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
        public void addObserver(Person observer)
        {
            persons.Add(observer);
        }

        public void removeObserver(Person observer)
        {
            persons.Remove(observer);

        }

        public void getNews(Weather data)
        {
            notifyObserver(data);
        }

        public void notifyObserver(Weather data)
        {
            foreach(Person person in persons)
            {
                person.update(data);
            }
        }
    }
}
