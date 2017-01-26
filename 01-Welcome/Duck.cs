using _01_Welcome.Behaviors.Abstraction;
using System;

namespace _01_Welcome
{
	public abstract class Duck
	{
		public IFlyBehavior flyBehavior { get; protected set; }

		public IQuackBehavior quackBehavior { get; protected set; }

		public abstract void Display();

		public void PerformFly()
		{
			flyBehavior.Fly();
		}

		public void PerformQuack()
		{
			quackBehavior.Quack();
		}

		public void Swim()
		{
			Console.WriteLine("All ducks float, even decoys!");
		}

		public void SetFlyBehavior(IFlyBehavior fb)
		{
			flyBehavior = fb;
		}

		public void SetQuackBehavior(IQuackBehavior qb)
		{
			quackBehavior = qb;
		}
	}
}
