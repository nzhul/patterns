using _03_StarbuzzCoffee_Decorator.Beverages.Abstraction;
using System;

namespace _03_StarbuzzCoffee_Decorator.Condiments.Implementation
{
	public class SteamedMilk : CondimentDecorator
	{
		public SteamedMilk(Beverage beverage)
			:base(beverage)
		{
			Type = beverage.Type;
		}

		public override double Cost()
		{
			double cost = beverage.Cost();
			switch (this.GetSize())
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
			return base.GetDescription() + "Steamed Milk";
		}
	}
}
