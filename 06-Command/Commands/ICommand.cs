namespace _06_Command.Commands
{
	public interface ICommand
	{
		void Execute();

		void Undo();
	}
}
