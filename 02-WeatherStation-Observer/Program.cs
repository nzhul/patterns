using _02_WeatherStation_Observer.Displays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WeatherStation_Observer
{
	public class Program
	{
		public static void Main(string[] args)
		{
			WeatherData weatherData = new WeatherData();

			CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
			HeatIndexDisplay heatDisplay = new HeatIndexDisplay(weatherData);

			weatherData.SetMeasurements(80,65,30.4f);
			weatherData.SetMeasurements(82,70,29.2f);
			weatherData.SetMeasurements(78,90,29.2f);
		}
	}
}
