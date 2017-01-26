using System;
using _03_StarbuzzCoffee_Decorator.Beverages.Abstraction;

namespace _03_StarbuzzCoffee_Decorator.Beverages.Implementation
{
	public class Decaf : Beverage
	{
		public Decaf()
		{
			Description = "Decaf Coffee";
		}

		public override double Cost()
		{
			return 1.05;
		}
	}
}
