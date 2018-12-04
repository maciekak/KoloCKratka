using System;
using System.Net;
using System.Timers;
using System.Xml;
using Model.Common;
using System.Globalization;

namespace Model.WheatherLiveStation
{
    public class WeatherLiveStation : IWeatherStation
    {
        private readonly Timer _timer;
        private const string CurrentUrl = "http://api.openweathermap.org/data/2.5/weather?q=London&mode=xml&units=metric&APPID=83b9608e79d65bd5c19678b03317bd45";

        public WeatherLiveStation()
        {
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
            using (var webClient = new WebClient())
            {
                var xmlContent = webClient.DownloadString(CurrentUrl);
                var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlContent);

                if (xmlDocument.DocumentElement == null)
                {
                    return new WeatherChangedArgs(0, 0, 0);
                }

                var nodes = xmlDocument.ChildNodes[1].ChildNodes;
                var temperature =
                    (int) double.Parse(nodes[1].Attributes.GetNamedItem("value").Value, CultureInfo.InvariantCulture);
                var pressure = 
                    (int) double.Parse(nodes[3].Attributes.GetNamedItem("value").Value, CultureInfo.InvariantCulture);
                var wind =
                    (int)double.Parse(nodes[4].FirstChild.Attributes.GetNamedItem("value").Value, CultureInfo.InvariantCulture);

                return new WeatherChangedArgs(temperature, pressure, wind);
            }
        }

        public event EventHandler<WeatherChangedArgs> WeatherChanged;

        protected virtual void OnWeatherChanged(WeatherChangedArgs e)
        {
            WeatherChanged?.Invoke(this, e);
        }
    }
}
