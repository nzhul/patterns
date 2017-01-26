using _01_Welcome.Behaviors.Abstraction;
using System;

namespace _01_Welcome.Behaviors.Implementation
{
	public class FlyWithWings : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("I'm flying!!!");
		}
	}
}
