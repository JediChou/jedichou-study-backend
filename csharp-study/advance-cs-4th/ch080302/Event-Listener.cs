using System;

namespace Wrox.ProCSharp.Delegates
{
	public class CarInfoEventArgs: EventArgs
	{
		public CarInfoEventArgs(string car)
		{
			this.Car = car;
		}
		
		public string Car { get; private set; }
	}
	
	public class CarDealer
	{
		public event EventHandler<CarInfoEventArgs> NewCarInfo;
		public void NewCar(string car)
		{
			Console.WriteLine("CarDealer, new car {0}", car);
			if (NewCarInfo != null)
			{
				NewCarInfo(this, new CarInfoEventArgs(car));
			}
		}
	}
	
	public class Consumer
	{
		private string name;
		
		public Consumer(string name)
		{
			this.name = name;	
		}
		
		public void NewCarIsHere(object sender, CarInfoEventArgs e)
		{
			Console.WriteLine("{0}: car {1} is new", name, e.Car);
		}
	}
	
	class Program
	{
		static void Main()
		{
			var dealer = new CarDealer();
			
			var michael = new Consumer("Michael");
			dealer.NewCarInfo += michael.NewCarIsHere;
			
			dealer.NewCar("Mercedes");
			
			var nick = new Consumer("Nick");
			dealer.NewCarInfo += nick.NewCarIsHere;
			
			dealer.NewCar("Ferrari");
			dealer.NewCarInfo += michael.NewCarIsHere;
			dealer.NewCar("Tokota");
		}
	}
	
	// TODO: 不是很理解这里的机制
}