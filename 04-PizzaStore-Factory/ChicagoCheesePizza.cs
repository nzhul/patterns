using System;

namespace _04_PizzaStore_Factory
{
	public class ChicagoCheesePizza : Pizza
	{
		public ChicagoCheesePizza()
		{
			Name = "Chicago Pizza";
			Dough = "Extra Thick";
			Sauce = "Tomato Sauce";

			toppings.Add("Shredded Mozzarella Cheese");
		}

		internal override void Cut()
		{
			Console.WriteLine("Cutting: Overrided to make cutting in squares");
		}
	}
}
