using System;
using System.Diagnostics;
using System.Threading;

class MySample {
	
	public static void Main() {
		
		// create the source, if it does not already exist.
		if(!EventLog.SourceExists("MySource")) {
			EventLog.CreateEventSource("MySource", "MyNewLog");
			Console.WriteLine("CreatingEventSource");
		}
		
		// Create an EventLog instance and assign its source.
		EventLog mylog = new EventLog();
		myLog.Source = "MySource";
		
		// Write an informational entry to the event log.
		myLog.WriteEntry("Writing to event log.");
	}
	
}