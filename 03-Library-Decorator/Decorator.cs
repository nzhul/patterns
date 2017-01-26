namespace _03_Library_Decorator
{
	public abstract class Decorator : LibraryItem
	{
		protected LibraryItem libraryItem;

		public Decorator(LibraryItem libraryItem)
		{
			this.libraryItem = libraryItem;
		}

		public override void Display()
		{
			libraryItem.Display();
		}
	}
}
