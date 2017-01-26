using _03_StarbuzzCoffee_Decorator.Beverages.Abstraction;
using _03_StarbuzzCoffee_Decorator.Beverages.Implementation;
using _03_StarbuzzCoffee_Decorator.Condiments.Implementation;
using System;

namespace _03_StarbuzzCoffee_Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			Beverage beverage = new Espresso();
			beverage = new Mocha(beverage);
			PrintBeverage(beverage);

			Beverage beverage2 = new DarkRoast();
			beverage2 = new Mocha(beverage2);
			beverage2 = new Soy(beverage2);
			beverage2 = new Whip(beverage2);
			PrintBeverage(beverage2);

			Beverage beverage3 = new HouseBlend();
			beverage3.SetSize(BeverageType.Venti);
			beverage3 = new Soy(beverage3);
			beverage3 = new Mocha(beverage3);
			beverage3 = new Whip(beverage3);
			PrintBeverage(beverage3);
		}

		private static void PrintBeverage(Beverage beverage)
		{
			Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());
		}
	}
}
