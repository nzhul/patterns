using System;

namespace _04_PizzaStore_Factory
{
	internal class NYPizzaStore : PizzaStore
	{
		public override Pizza CreatePizza(string type)
		{
			switch (type)
			{
				case "cheese":
					return new NYCheesePizza();
				case "veggie":
					return new NYVeggiePizza();
				default:
					break;
			}

			return null;
		}
	}

	internal class NYVeggiePizza : Pizza
	{
	}
}