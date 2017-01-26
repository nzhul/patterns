﻿using _06_Command.Commands;

namespace _06_Command
{
	public class SimpleRemoteControl
	{
		ICommand slot;

		public SimpleRemoteControl()
		{
		}

		public void SetCommand(ICommand command)
		{
			slot = command;
		}

		public void ButtonWasPressed()
		{
			slot.Execute();
		}
	}
}
