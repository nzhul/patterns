using System;
using _01_Adventure.Characters.Abstraction;
using _01_Adventure.Behaviors.Implementation;

namespace _01_Adventure.Characters.Implementation
{
	public class Queen : Character
	{
		public Queen()
		{
			weapon = new Bow();
		}

		public override void Display()
		{
			Console.WriteLine("I'm the Queen!");
		}
	}
}
