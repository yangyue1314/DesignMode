using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            //weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("CurrentConditionDisplay:" + temperature + "  " + humidity);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;

            Display();
        }
    }
}
