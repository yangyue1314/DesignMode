using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class WeatherData:Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public float Temperature { get => temperature; set => temperature = value; }
        public float Humidity { get => humidity; set => humidity = value; }
        public float Pressure { get => pressure; set => pressure = value; }

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void Remove(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Update(Temperature, Humidity, Pressure);
            }
        }

        public void MeasurementChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurement(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            MeasurementChanged();
        }
    }
}
