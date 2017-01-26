using _03_StarbuzzCoffee_Decorator.Beverages.Abstraction;
using System;

namespace _03_StarbuzzCoffee_Decorator.Condiments.Implementation
{
	public class Whip : CondimentDecorator
	{
		public Whip(Beverage beverage)
			:base(beverage)
		{
			this.beverage = beverage;
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
					cost += .20;
					break;
				default:
					break;
			}

			return cost;
		}

		public override string GetDescription()
		{
			return base.GetDescription() + "Whip";
		}
	}
}
