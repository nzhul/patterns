﻿using System;
using _01_Adventure.Behaviors.Abstraction;

namespace _01_Adventure.Behaviors.Implementation
{
	public class Bow : IWeapon
	{
		public void UseWeapon()
		{
			Console.WriteLine("Bow attack!");
		}
	}
}
