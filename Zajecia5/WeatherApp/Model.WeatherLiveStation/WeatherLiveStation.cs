using System;
using System.Timers;
using Model.Common;

namespace Model.WheatherLiveStation
{
    public class WeatherLiveStation : IWeatherStation
    {
        private readonly Timer _timer;
        private readonly Random _random;
        private const string CurrentUrl = "http://api.openweathermap.org/data/2.5/weather?q=London&mode=xml&units=metric&APPID=API_KEY";

        public WeatherLiveStation()
        {
            _random = new Random();
            _timer = new Timer(1000*60*10);
            _timer.Elapsed += TimerOnElapsed;
            _timer.Enabled = true;
        }

        public void Run()
        {
            OnWeatherChanged(GetWeather());
            _timer.Start();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            OnWeatherChanged(GetWeather());
        }

        private WeatherChangedArgs GetWeather()
        {
//            using (var webClient = new WebClient())
//            {
//                var xmlContent = webClient.DownloadString(CurrentUrl);
//                var xmlDocument = new XmlDocument();
//                xmlDocument.LoadXml(xmlContent);
//
//                if (xmlDocument.DocumentElement == null)
//                {
//                    return new WeatherChangedArgs(0, 0, 0);
//                }
//
//                var temperature =
//                    (int) double.Parse(xmlDocument.DocumentElement.Attributes.GetNamedItem("temperature").Value);
//                var pressure = 
//                    (int) double.Parse(xmlDocument.DocumentElement.Attributes.GetNamedItem("pressure").Value);
//                var wind =
//                    (int)double.Parse(xmlDocument.DocumentElement.Attributes.GetNamedItem("speed").Value);
//
//                return new WeatherChangedArgs(temperature, pressure, wind);
//            }

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
