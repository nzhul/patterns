using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Singleton
{
	// Second version - simple thread-safety
	public class SecondSingleton
	{
		private static SecondSingleton instance = null;
		private static readonly object padlock = new object();

		private SecondSingleton()
		{
		}

		public static SecondSingleton Instance
		{
			get
			{
				lock (padlock)
				{
					if (instance == null)
					{
						instance = new SecondSingleton();
					}

					return instance;
				}
			}
		}
	}
}
