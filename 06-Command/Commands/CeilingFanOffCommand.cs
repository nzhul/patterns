using _06_Command.Executors;
using System;

namespace _06_Command.Commands
{
	public class CeilingFanOffCommand : ICommand
	{
		private CeilingFan ceilingFan;

		public CeilingFanOffCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}

		public void Execute()
		{
			this.ceilingFan.Off();
		}

		public void Undo()
		{
			this.ceilingFan.On();
		}
	}
}
