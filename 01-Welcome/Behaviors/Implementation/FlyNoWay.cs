using _01_Welcome.Behaviors.Abstraction;
using System;

namespace _01_Welcome.Behaviors.Implementation
{
	public class FlyNoWay : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("I can't fly");
		}
	}
}
