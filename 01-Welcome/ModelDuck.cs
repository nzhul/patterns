using _01_Welcome.Behaviors.Implementation;
using System;

namespace _01_Welcome
{
	public class ModelDuck : Duck
	{
		public ModelDuck()
		{
			flyBehavior = new FlyNoWay();
			quackBehavior = new QuackNormal();
		}

		public override void Display()
		{
			Console.WriteLine("I'm a model duck");
		}
	}
}
