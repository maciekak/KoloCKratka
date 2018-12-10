using System;
using System.ComponentModel;
using Model.Common;
using Model.WeatherMockStation;
using Model.WheatherLiveStation;
using ViewModel.WeatherApp.Annotations;

namespace ViewModel.WeatherApp
{
    public class WeatherViewModel : INotifyPropertyChanged
    {
        private readonly IWeatherStation _weatherStation;
        private int _temperature;
        private int _pressure;
        private int _wind;

        #region Properties
        
        public int Temperature
        {
            get => _temperature;
            set
            {
                if (value != _temperature)
                {
                    _temperature = value;
                    OnPropertyChanged(nameof(Temperature));
                }
            }
        }

        public int Pressure
        {
            get => _pressure;
            set
            {
                if (value != _pressure)
                {
                    _pressure = value;
                    OnPropertyChanged(nameof(Pressure));
                }
            }
        }

        public int Wind
        {
            get => _wind;
            set
            {
                if (value != _wind)
                {
                    _wind = value;
                    OnPropertyChanged(nameof(Wind));
                }
            }
        }

        #endregion
        
        public WeatherViewModel()
        {
            _weatherStation = new WeatherLiveStation();
            _weatherStation.WeatherChanged += WeatherStationOnWeatherChanged;
            _weatherStation.Run();
        }

        private void WeatherStationOnWeatherChanged(object sender, WeatherChangedArgs weatherChangedArgs)
        {
            Temperature = weatherChangedArgs.Temperature;
            Pressure = weatherChangedArgs.Pressure;
            Wind = weatherChangedArgs.Wind;
        }

        public event PropertyChangedEventHandler PropertyChanged;


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
