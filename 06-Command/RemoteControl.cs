using _06_Command.Commands;
using System.Text;

namespace _06_Command
{
	public class RemoteControl
	{
		ICommand[] onCommands;
		ICommand[] offCommands;
		ICommand undoCommand;

		public RemoteControl()
		{
			onCommands = new ICommand[7];
			offCommands = new ICommand[7];

			ICommand noCommand = new NoCommand();
			for (int i = 0; i < 7; i++)
			{
				onCommands[i] = noCommand;
				offCommands[i] = noCommand;
			}

			this.undoCommand = noCommand;
		}

		public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
		{
			onCommands[slot] = onCommand;
			offCommands[slot] = offCommand;
		}

		public void OnButtonWasPressed(int slot)
		{
			onCommands[slot].Execute();
			undoCommand = onCommands[slot];
		}

		public void OffButtonWasPressed(int slot)
		{
			offCommands[slot].Execute();
			undoCommand = offCommands[slot];
		}

		public void UndoButtonWasPressed()
		{
			undoCommand.Undo();
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("------ Remote Control ------");
			for (int i = 0; i < onCommands.Length; i++)
			{
				sb.AppendLine("[slot " + i + "] " + onCommands[i].GetType().Name + "     " + offCommands[i].GetType().Name);
			}

			sb.AppendLine("[undo] " + undoCommand.GetType().Name);

			return sb.ToString();
		}
	}
}
