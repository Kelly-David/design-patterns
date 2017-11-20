using System;
namespace ObserverPattern
{
    public class PhoneDisplay : IObserver
    {
        IObservable weatherStation = new WeatherStation();

        public void Update()
        {
            
        }

        public PhoneDisplay(IObservable station)
        {
            this.weatherStation = station;
        }
    }
}
