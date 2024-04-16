using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("farzad", "Linz");
            Person person2 = new Person("Alex", "Bonn");
            Person person3 = new Person("Max", "Köln");

            NewsTranmitter newsTranmitter = new NewsTranmitter();

            newsTranmitter.addObserver(person1);
            newsTranmitter.addObserver(person2);
            newsTranmitter.addObserver(person3);

            Weather weather1 = new Weather(2, 7, 4.5, "Linz");
            Weather weather2 = new Weather(2, 7, 4.5, "Bonn");
            Weather weather3 = new Weather(2, 7, 4.5, "Köln");

            newsTranmitter.getNews(weather1);
            newsTranmitter.getNews(weather2);
            newsTranmitter.getNews(weather3);

            Console.ReadKey();
        }
    }
}
