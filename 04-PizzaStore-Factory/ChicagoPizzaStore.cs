namespace _04_PizzaStore_Factory
{
	internal class ChicagoPizzaStore : PizzaStore
	{
		public override Pizza CreatePizza(string type)
		{
			switch (type)
			{
				case "cheese":
					return new ChicagoCheesePizza();
				default:
					break;
			}
			return null;
		}
	}
}