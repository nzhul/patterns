using _01_Adventure.Characters.Abstraction;
using _01_Adventure.Characters.Implementation;
using System;

namespace _01_Adventure
{
	class Program
	{
		static void Main(string[] args)
		{
			Character theKing = new King();
			theKing.Display();
			theKing.Fight();

			Console.WriteLine("---------");

			Character theQueen = new Queen();
			theQueen.Display();
			theQueen.Fight();
		}
	}
}
