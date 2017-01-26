namespace _02_WeatherStation_Observer
{
	public interface IObserver
	{
		void Update(float temperature, float humidity, float pressure);
	}
}
