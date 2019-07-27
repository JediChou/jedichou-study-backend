// event demo
using System;

namespace ProgrammingCSharp4 {

	public class EventSample {
		// define event
		public event EventHandler PrintComplete;

		public void OnPrintComplete() {
			// decide event binding. null means there 
			// has no event process method.
			if( PrintComplete != null) {
				PrintComplete(this, new EventArgs());
			}
		}

		public static void Main() {
			var eventSample = new EventSample();
			var printer = new Printer(eventSample);
			eventSample.OnPrintComplete();
		}
	}

	public class Printer {
		public Printer(EventSample eventSample) {
			// event bind
			eventSample.PrintComplete += ShowMessage;
			eventSample.PrintComplete += SendSmsToMobile;
		}

		public void ShowMessage(object sender, EventArgs e) {
			Console.WriteLine("Print complete...");
		}

		public void SendSmsToMobile(object sender, EventArgs e) {
			Console.WriteLine("SMS-Print complete...");
		}
	}
}
