using System;
using System.Net.NetworkInformation;
using System.Collections.Generic;

public class MyClass
{
	public static void RunSnippet()
	{
		// Use .NET api to simulate a ping program.
		
		Ping p = new Ping();
		PingReply reply = p.Send("10.130.14.81", 100);
		
		if (reply.Status == IPStatus.Success)
			Console.WriteLine("is alive");
		else
			Console.WriteLine("is shutdown");		
	}
	
	#region Helper methods
	
	public static void Main()
	{
		try
		{
			RunSnippet();
		}
		catch (Exception e)
		{
			string error = string.Format("---\nThe following error occurred while executing the snippet:\n{0}\n---", e.ToString());
			Console.WriteLine(error);
		}
		finally
		{
			Console.Write("Press any key to continue...");
			Console.ReadKey();
		}
	}

	private static void WL(object text, params object[] args)
	{
		Console.WriteLine(text.ToString(), args);	
	}
	
	private static void RL()
	{
		Console.ReadLine();	
	}
	
	private static void Break() 
	{
		System.Diagnostics.Debugger.Break();
	}

	#endregion
}