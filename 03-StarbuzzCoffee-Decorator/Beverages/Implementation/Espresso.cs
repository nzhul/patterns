using System;
using _03_StarbuzzCoffee_Decorator.Beverages.Abstraction;

namespace _03_StarbuzzCoffee_Decorator.Beverages.Implementation
{
	public class Espresso : Beverage
	{
		public Espresso()
		{
			Description = "Espresso";
		}

		public override double Cost()
		{
			return 1.99;
		}
	}
}
