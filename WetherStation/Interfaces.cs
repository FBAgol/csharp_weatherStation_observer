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
         void Update(T data);
    }

    interface IObserverable<T,B>
    {
        void AddObserver(T data);
        void RemoveObserver(T data);
        void GetNews(B data);
        void NotifyObserver(B data);
    }
}
