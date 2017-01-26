using System;
using _03_StarbuzzCoffee_Decorator.Beverages.Abstraction;

namespace _03_StarbuzzCoffee_Decorator.Beverages.Implementation
{
	public class DarkRoast : Beverage
	{
		public DarkRoast()
		{
			Description = "Dark Roast Coffee";
		}

		public override double Cost()
		{
			return .99;
		}
	}
}
