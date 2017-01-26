using _01_Adventure.Behaviors.Abstraction;
using System;

namespace _01_Adventure.Behaviors.Implementation
{
	public class Knife : IWeapon
	{
		public void UseWeapon()
		{
			Console.WriteLine("Knife attack!");
		}
	}
}
