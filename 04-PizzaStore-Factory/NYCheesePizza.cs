namespace _04_PizzaStore_Factory
{
	public class NYCheesePizza : Pizza
	{
		public NYCheesePizza()
		{
			Name = "NY Pizza";
			Dough = "Thin Crust";
			Sauce = "Marina Sauce";

			toppings.Add("Grated Regiano Cheese");
		}
	}
}
