using System;

namespace _06_Command.Executors
{
	public class Light
	{
		private string location;

		public Light(string location)
		{
			this.location = location;
		}

		public void On()
		{
			Console.WriteLine(this.location + " light is now On!");
		}

		public void Off()
		{
			Console.WriteLine(this.location + " light is now Off!");
		}
	}
}
