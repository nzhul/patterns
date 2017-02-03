using _06_Command.Executors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Command.Commands
{
	public class CeilingFanOnCommand : ICommand
	{
		private CeilingFan ceilingFan;

		public CeilingFanOnCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}

		public void Execute()
		{
			this.ceilingFan.On();
		}

		public void Undo()
		{
			this.ceilingFan.Off();
		}
	}
}
