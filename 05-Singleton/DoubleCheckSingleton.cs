using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Singleton
{
	public sealed class DoubleCheckSingleton
	{
		private static DoubleCheckSingleton instance = null;
		private static readonly object padlock = new object();

		private DoubleCheckSingleton()
		{
		}

		public static DoubleCheckSingleton Instance
		{
			get
			{
				if (instance == null)
				{
					lock (padlock)
					{
						if (instance == null)
						{
							instance = new DoubleCheckSingleton();
						}
					}
				}

				return instance;
			}
		}
	}
}
