using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PizzaStore_Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			PizzaStore nyStore = new NYPizzaStore();
			PizzaStore chicagoStore = new ChicagoPizzaStore();

			Pizza pizza = nyStore.OrderPizza("cheese");
			Console.WriteLine("Ethan ordered a " + pizza.Name);

			pizza = chicagoStore.OrderPizza("cheese");
			Console.WriteLine("Joel ordered a " + pizza.Name);

		}
	}
}
