using System;
using System.Collections.Generic;

namespace _04_PizzaStore_Factory
{
	public abstract class Pizza
	{
		public string Name { get; set; }
		public string Dough { get; set; }
		public string Sauce { get; set; }
		protected List<string> toppings = new List<string>();


		internal virtual void Prepare()
		{
			Console.WriteLine("Preparing " + Name);
			Console.WriteLine("Tossing dough ...");
			Console.WriteLine("Adding sauce ...");
			Console.Write("Adding toppings: ");
			for (int i = 0; i < toppings.Count; i++)
			{
				Console.Write(" " + toppings[i]);
			}
			Console.WriteLine();
		}

		internal virtual void Bake()
		{
			Console.WriteLine("Baking");
		}

		internal virtual void Cut()
		{
			Console.WriteLine("Cutting");
		}

		internal virtual void Box()
		{
			Console.WriteLine("Boxing");
		}
	}
}