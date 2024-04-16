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


            string date = DateTime.Now.ToString("dd.MM.yyyy");

            Person person1 = new Person("farzad", "Linz");
            Person person2 = new Person("Alex", "Bonn");
            Person person3 = new Person("Max", "Köln");

            NewsTranmitter newsTranmitter = new NewsTranmitter();

            newsTranmitter.AddObserver(person1);
            newsTranmitter.AddObserver(person2);
            newsTranmitter.AddObserver(person3);

            Weather weather1 = new Weather(2, 7, 4.5, "Linz",date);
            Weather weather2 = new Weather(2, 7, 4.5, "Bonn",date);
            Weather weather3 = new Weather(2, 7, 4.5, "Köln",date);

            newsTranmitter.GetNews(weather1);
            newsTranmitter.GetNews(weather2);
            newsTranmitter.GetNews(weather3);

            Console.ReadKey();
        }
    }
}
