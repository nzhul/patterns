using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Singleton
{
	public class LazySingleton
	{
		private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(() => new LazySingleton());

		public static LazySingleton Instance { get { return lazy.Value; } }

		private LazySingleton()
		{
		}
	}
}
