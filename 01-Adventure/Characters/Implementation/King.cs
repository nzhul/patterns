using System;
using _01_Adventure.Characters.Abstraction;
using _01_Adventure.Behaviors.Implementation;

namespace _01_Adventure.Characters.Implementation
{
	public class King : Character
	{
		public King()
		{
			weapon = new Axe();
		}

		public override void Display()
		{
			Console.WriteLine("I am the king");
		}
	}
}
