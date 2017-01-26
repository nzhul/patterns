using _01_Welcome.Behaviors.Abstraction;
using System;

namespace _01_Welcome.Behaviors.Implementation
{
	public class Squeak : IQuackBehavior
	{
		public void Quack()
		{
			Console.WriteLine("Squeak");
		}
	}
}
