using System;

namespace Wrox.ProCSharp.Delegates {
	
	public class CarInfoEventArgs : EventArgs {
		public CarInfoEventArgs(string car) {
			this.Car = car;
		}
		public string Car { get; private set; }
	}
	
	public class CarDealer {
		public event EventHandler<CarInfoEventArgs> NewCarInfo;
		
		public void NewCarInfo(string car) {
			Console.WriteLine("CarDealer, new car {0}", car);
			if (NewCarInfo != null)
				NewCarInfo(this, new CarInfoEventArgs(car));
		}
		
		public static void Main() {
			new CarDealer.NewCarInfo("Some thing");
			
			///////////////////////////////////////////////////////////////////
			// TODO
			///////////////////////////////////////////////////////////////////
			// Event-NewCarInfo.cs(15,15): error CS0102: 型別
        	// 'Wrox.ProCSharp.Delegates.CarDealer' 已經包含 'NewCarInfo' 的定義
			// Event-NewCarInfo.cs(13,47): (與之前錯誤相關符號的位置)
			///////////////////////////////////////////////////////////////////
			
		}
	}	
	
}