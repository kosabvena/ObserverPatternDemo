using System;
using System.Collections.Generic;

namespace ObserverPatternDemo
{
    public interface IObserver
    {
        void Update(double temperature);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public class WeatherStation : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private double _temperature;

        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
                observer.Update(_temperature);
        }

        public void SetTemperature(double temperature)
        {
            _temperature = temperature;
            Notify(); 
        }
    }
}