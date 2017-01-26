using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Command.Executors
{
	public class CeilingFan
	{
		private string location;

		public CeilingFan(string location)
		{
			this.location = location;
		}

		public void On()
		{
			Console.WriteLine(this.location + " ceiling fan is On!");
		}

		public void Off()
		{
			Console.WriteLine(this.location + " ceiling fan is Off!");
		}
	}
}
