using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetherStation
{
    interface Iweather
    {
    }

    interface IObserver<T>
    {
         void update(T data);
    }

    interface IObserverable<T,B>
    {
        void addObserver(T data);
        void removeObserver(T data);
        void getNews(B data);
        void notifyObserver(B data);
    }
}
