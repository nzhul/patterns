﻿using _06_Command.Executors;

namespace _06_Command.Commands
{
	public class GarageDoorUpCommand : ICommand
	{
		GarageDoor garageDoor;

		public GarageDoorUpCommand(GarageDoor garageDoor)
		{
			this.garageDoor = garageDoor;
		}

		public void Execute()
		{
			garageDoor.Up();
		}
	}
}
