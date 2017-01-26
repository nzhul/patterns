using System;

namespace _06_Command.Executors
{
	public class Stereo
	{
		public void On()
		{
			Console.WriteLine("Stereo On");
		}

		public void SetCD()
		{
			Console.WriteLine("CD Set");
		}

		public void SetVolume(int volume)
		{
			Console.WriteLine("Volume set to: " + volume);
		}

		internal void Off()
		{
			Console.WriteLine("Stereo Off");
		}
	}
}
