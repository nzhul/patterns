using System;

namespace _03_Library_Decorator
{
	class Program
	{
		static void Main()
		{
			Book book = new Book("Worley", "Inside ASP.NET", 10);
			book.Display();

			Video video = new Video("Spielberg", "Jaws", 23, 92);
			video.Display();

			Console.WriteLine("Making video borrowable: ");

			Borrowable borrowvideo = new Borrowable(video);
			borrowvideo.BorrowItem("Customer #1");
			borrowvideo.BorrowItem("Customer #2");

			borrowvideo.Display();
		}
	}
}
