﻿using System;

namespace _06_Command.Commands
{
	public class NoCommand : ICommand
	{
		public void Execute()
		{
			throw new NotImplementedException();
		}

		public void Undo()
		{
			throw new NotImplementedException();
		}
	}
}