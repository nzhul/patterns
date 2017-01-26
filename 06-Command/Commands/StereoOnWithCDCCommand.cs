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
			stereo.On();
			stereo.SetCD();
			stereo.SetVolume(11);
		}
	}
}
