using _06_Command.Executors;

namespace _06_Command.Commands
{
	public class StereoOnWithCDCCommand : ICommand
	{
		private Stereo stereo;

		public StereoOnWithCDCCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}

		public void Execute()
		{
			this.stereo.On();
			this.stereo.SetCD();
			this.stereo.SetVolume(11);
		}

		public void Undo()
		{
			this.stereo.Off();
		}
	}
}
