using _03_StarbuzzCoffee_Decorator.Beverages.Abstraction;
using System;

namespace _03_StarbuzzCoffee_Decorator.Condiments.Implementation
{
	public class Mocha : CondimentDecorator
	{
		public Mocha(Beverage beverage)
			:base(beverage)
		{
			Type = beverage.Type;
		}

		public override double Cost()
		{
			double cost = beverage.Cost();
			switch (Type)
			{
				case BeverageType.Tall:
					cost += .10;
					break;
				case BeverageType.Grande:
					cost += .15;
					break;
				case BeverageType.Venti:
					cost += .80;
					break;
				default:
					break;
			}

			return cost;
		}

		public override string GetDescription()
		{
			return base.GetDescription() + "Mocha";
		}
	}
}
