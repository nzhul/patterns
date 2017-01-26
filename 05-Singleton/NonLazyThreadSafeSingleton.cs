using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Singleton
{
	public sealed class NonLazyThreadSafeSingleton
	{
		private static readonly NonLazyThreadSafeSingleton instance = new NonLazyThreadSafeSingleton();

		static NonLazyThreadSafeSingleton()
		{
		}

		private NonLazyThreadSafeSingleton()
		{
		}

		public static NonLazyThreadSafeSingleton Instance
		{
			get
			{
				return instance;
			}
		}
	}
}
