using System;

namespace Model.Common
{
    public class WeatherChangedArgs : EventArgs
    {
        public WeatherChangedArgs(int temperature, int pressure, int wind)
        {
            Temperature = temperature;
            Pressure = pressure;
            Wind = wind;
        }

        public int Temperature { get; }
        public int Pressure { get; }
        public int Wind { get; }
    }
}
