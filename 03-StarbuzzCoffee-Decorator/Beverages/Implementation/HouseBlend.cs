using System;
using _03_StarbuzzCoffee_Decorator.Beverages.Abstraction;

namespace _03_StarbuzzCoffee_Decorator.Beverages.Implementation
{
	public class HouseBlend : Beverage
	{
		public HouseBlend()
		{
			Description = "House Blend Coffee";
		}

		public override double Cost()
		{
			return .89;
		}
	}
}
