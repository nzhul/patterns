using System;

namespace _06_Command.Executors
{
	public class GarageDoor
	{
		public void Up()
		{
			Console.WriteLine("Garage door was opened!");
		}

		public void Down()
		{
			Console.WriteLine("Garage door was closed!");
		}
	}
}
