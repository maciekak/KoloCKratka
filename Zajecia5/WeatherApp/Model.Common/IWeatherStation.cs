using System;

namespace Model.Common
{
    public interface IWeatherStation
    {
        event EventHandler<WeatherChangedArgs> WeatherChanged;
        void Run();
    }
}
