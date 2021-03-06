﻿using System;
using _06_Command.Executors;

namespace _06_Command.Commands
{
	public class StereoOffCommand : ICommand
	{
		private Stereo stereo;

		public StereoOffCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}

		public void Execute()
		{
			this.stereo.Off();
		}

		public void Undo()
		{
			this.stereo.On();
			this.stereo.SetCD();
			this.stereo.SetVolume(11);
		}
	}
}
