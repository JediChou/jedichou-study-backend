// File name: DecoratorPattern.cs
// Description: TODO

namespace libraryItem
{
	using System;
	using System.Collections;
	
	// Define abstract class LibraryItem
	abstract class LibraryItem
	{
		private int numCopies;
		
		// Proerty
		public int NumCopies
		{
			get {return numCopies;}
			set {numCopies = values;}
		}
		
		public abstract void Display();
	}
	
	// Define a book class
	class Book : LibraryItem
	{
		private string author;
		private string title;
		
		public Book(string author, string title, int numCopies)
		{
			this.author = author;
			this.title = title;
			this.numCopies = numCopies;
		}
		
		public override void display()
		{
			Console.WriteLine("\n 書 -------- ");
			Console.WriteLine(" 作者: {0}", author);
			Console.WriteLine(" 書名: {0}", title);
			Console.WriteLine(" # 數量: {0}", NumCopies);
		}
	}
	
	// Define a Video class
	class Video : LibraryItem
	{
		private string director;
		private string title;
		private int playTime;
		
		public Video (string director, string title, int numCopies, int playTime)
		{
			this.director = director;
			this.title = title;
			this.numCopies = numCopies;
			this.playTime = playTime;
		}
		
		public override void Display()
		{
			Console.WriteLine("\n 影像 ----- ");
			Console.WriteLine(" 導演: {0}", director);
			Console.WriteLine(" 片名: {0}", title);
			Console.WriteLine(" # 數量: {0}", numCopies);
			Console.WriteLine(" 播放時間: {0}", playTime);
		}
	}
	
	// Define a abstract decorator class
	// 定义抽象装饰类
	abstract class Decorator : LibraryItem
	{
		protected LibraryItem libraryItem;
		
		public Decorator (LibraryItem libraryItem)
		{
			this.libraryItem = libraryItem;
		}
		
		public override void Display()
		{
			libraryItem.Display();
		}
	}
	
	// Define a decorator class
	// 定义具体装饰类
	class Borrowable : Decorator
	{
		protected ArraryList borrowers = new ArrayList();
		
		// Call supper constrct method.
		public Borrowable(LibraryItem libraryItem) : base(libraryItem)	{}
		
		public void BorrowItem(string name)
		{
			borrowers.Add(name);
			libraryItem.NumCopies--;
		}
		
		public void ReturnItem(string name)
		{
			borrowers.Remove(name);
			libraryItem.NumCopiess++;
		}
		
		public override void Display()
		{
			base.Display();
			foreach (string borrower in borrowers)
				Console.WriteLine(" 借出人: {0}", borrower);
		}
	}
	
	/// <summary>
	/// 装饰模式应用测试
	/// </summary>
	public class DecoratorApp
	{
		public static void Main(string[] args)
		{
			// create Book and Video instances, and call display method.
			Book book = new Book("Schell", "My Home", 10);
			Video video = new Video("Spielberg", "Schinldler's list", 23, 60);
			book.Display();
			video.Display();
			
			// Add property of book and video, then lend it.
			Console.WriteLine("\n Video can add lend/borrow property:");
			Borrowable borrowvideo = new Borrowable(video);
			borrowvideo.BorrowItem("zhang San");
			borrowvideo.BorrowItem("LiSi");
			borrowvideo.Display();
			Console.Readkey();
		}
	}
}
