using _03_StarbuzzCoffee_Decorator.Beverages.Abstraction;

namespace _03_StarbuzzCoffee_Decorator
{
	public abstract class CondimentDecorator : Beverage
	{
		protected Beverage beverage;

		public CondimentDecorator(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string GetDescription()
		{
			// There is no need to do that right now but this is an example for this functionality
			return beverage.GetDescription() + " Condement: ";
		}
	}
}
