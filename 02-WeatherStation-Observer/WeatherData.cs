using System;
using System.Collections.Generic;

namespace _02_WeatherStation_Observer
{
	public class WeatherData : ISubject
	{
		public float Temperature { get; set; }
		public float Humidity { get; set; }
		public float Pressure { get; set; }
		private List<IObserver> Observers { get; set; }
		private bool IsChanged;

		public WeatherData()
		{
			Observers = new List<IObserver>();
		}

		public void SetMeasurements(float temperature, float humidity, float pressure)
		{
			this.Temperature = temperature;
			this.Humidity = humidity;
			this.Pressure = pressure;
			MeasurementsChanged();
		}

		public void MeasurementsChanged()
		{
			// IsChanged may not be triggered every time the data changes.
			// but only when when significant change is made! 
			// Eg: This way - we can ignore small changes
			IsChanged = true;
			NotifyObservers();
		}

		public void NotifyObservers()
		{
			if (IsChanged)
			{
				foreach (IObserver observer in Observers)
				{
					observer.Update(Temperature, Humidity, Pressure);
				}
			}

			IsChanged = false;
		}

		public void RegisterObserver(IObserver observer)
		{
			Observers.Add(observer);
		}

		public void RemoveObserver(IObserver observer)
		{
			Observers.Remove(observer);
		}

		private void SetChanged()
		{
			IsChanged = true;
		}
	}
}
