namespace _04_PizzaStore_Factory
{
	public class PizzaStoreSimpleFactory
	{
		SimplePizzaFactory factory;

		public PizzaStoreSimpleFactory(SimplePizzaFactory factory)
		{
			this.factory = factory;
		}

		public Pizza OrderPizza(string type)
		{
			Pizza pizza;

			pizza = factory.CreatePizza(type);

			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();
			return pizza;
		}
	}
}