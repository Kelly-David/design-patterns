using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherStation : IObservable
    {
        List<IObserver> observer = new List<IObserver>();

        public void Add(IObserver obj)
        {
            this.observer.Add(obj);
        }

        public void Remove(IObserver obj)
        {
            this.observer.Remove(obj);
        }

        public void Notify()
        {
            foreach(IObserver o in observer) {
                o.Update();
            }

        }

        public WeatherStation()
        {
            
        }
    }
}
