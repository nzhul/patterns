using _06_Command.Executors;
using System;

namespace _06_Command.Commands
{
	public class LightOnCommand : ICommand
	{
		Light light;

		public LightOnCommand(Light light)
		{
			this.light = light;
		}

		public void Execute()
		{
			light.On();
		}
	}
}
