namespace _05_Singleton
{
	// First version - not thread-safe
	// Bad code! Do not use
	public sealed class FirstSingleton
	{
		private static FirstSingleton instance;

		private FirstSingleton()
		{
		}

		public static FirstSingleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new FirstSingleton();
				}

				return instance;
			}
		}
	}
}
