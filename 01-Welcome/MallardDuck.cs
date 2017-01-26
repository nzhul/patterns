using _01_Welcome.Behaviors.Implementation;
using System;

namespace _01_Welcome
{
	public class MallardDuck : Duck
	{
		public MallardDuck()
		{
			quackBehavior = new QuackNormal();
			flyBehavior = new FlyWithWings();
		}

		public override void Display()
		{
			Console.WriteLine("I'm a real Mallard duck");
		}
	}
}