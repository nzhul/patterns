using _06_Command.Commands;
using _06_Command.Executors;
using System;

namespace _06_Command
{
	class Program
	{
		static void Main(string[] args)
		{
			RemoteControl remote = new RemoteControl();

			Light livingRoomLight = new Light("Living Room");
			Light kitchenRoomLight = new Light("Kitchen");
			CeilingFan ceilingFan = new CeilingFan("Living Room");
			GarageDoor garageDoor = new GarageDoor();
			Stereo stereo = new Stereo();


			LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
			LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

			LightOnCommand kitchenRoomLightOn = new LightOnCommand(kitchenRoomLight);
			LightOffCommand kitchenRoomLightOff = new LightOffCommand(kitchenRoomLight);

			CeilingFanOnCommand ceilingFanOnCommand = new CeilingFanOnCommand(ceilingFan);
			CeilingFanOffCommand ceilingFanOffcommand = new CeilingFanOffCommand(ceilingFan);

			GarageDoorUpCommand garageDoorUpCommand = new GarageDoorUpCommand(garageDoor);
			GarageDoorDownCommand garageDoorDownCommand = new GarageDoorDownCommand(garageDoor);

			StereoOnWithCDCCommand stereoOnWithCD = new StereoOnWithCDCCommand(stereo);
			StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);

			remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
			remote.SetCommand(1, kitchenRoomLightOn, kitchenRoomLightOff);
			remote.SetCommand(2, ceilingFanOnCommand, ceilingFanOffcommand);
			remote.SetCommand(3, stereoOnWithCD, stereoOffCommand);

			remote.OnButtonWasPressed(0);
			remote.OffButtonWasPressed(0);
			remote.OnButtonWasPressed(1);
			remote.OffButtonWasPressed(1);
			remote.OnButtonWasPressed(2);
			remote.OffButtonWasPressed(2);
			remote.OnButtonWasPressed(3);
			remote.OffButtonWasPressed(3);

			Console.WriteLine("\n---- Undo the last action ----\n");
			remote.UndoButtonWasPressed();

			Console.WriteLine();
			System.Console.WriteLine(remote);
		}
	}
}
