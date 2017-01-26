using System;
using _01_Welcome.Behaviors.Abstraction;

namespace _01_Welcome.Behaviors.Implementation
{
	public class FlyRocketPowered : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("I'm flying with a rocket!");
		}
	}
}
