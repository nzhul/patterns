using System;
using _06_Command.Executors;

namespace _06_Command.Commands
{
	public class GarageDoorDownCommand : ICommand
	{
		private GarageDoor garageDoor;

		public GarageDoorDownCommand(GarageDoor garageDoor)
		{
			this.garageDoor = garageDoor;
		}

		public void Execute()
		{
			this.garageDoor.Down();
		}

		public void Undo()
		{
			this.garageDoor.Up();
		}
	}
}
