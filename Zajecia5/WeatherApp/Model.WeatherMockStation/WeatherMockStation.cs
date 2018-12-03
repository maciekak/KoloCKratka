using System;
using System.Timers;
using Model.Common;

namespace Model.WeatherMockStation
{
    public class WeatherMockStation : IWeatherStation
    {
        private readonly Timer _timer;
        private readonly Random _random;

        public WeatherMockStation()
        {
            _random = new Random();
            _timer = new Timer(1000 * 5);
            _timer.Elapsed += TimerOnElapsed;
            _timer.Enabled = true;
        }

        public void Run()
        {
            OnWeatherChanged(GetRandomWeather());
            _timer.Start();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            OnWeatherChanged(GetRandomWeather());
        }

        private WeatherChangedArgs GetRandomWeather()
        {
            var temperature = _random.Next(-20, 40);
            var pressure = _random.Next(900, 1100);
            var wind = _random.Next(0, 100);

            return new WeatherChangedArgs(temperature, pressure, wind);
        }

        public event EventHandler<WeatherChangedArgs> WeatherChanged;

        protected virtual void OnWeatherChanged(WeatherChangedArgs e)
        {
            WeatherChanged?.Invoke(this, e);
        }
    }
}
