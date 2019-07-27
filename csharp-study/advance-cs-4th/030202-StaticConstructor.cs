// File name: 030202-StaticConstructor.cs
// Create by Jedi at 2013.5.22 11:33 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 85
// Compile:
//   1. csc 030202-StaticConstructor.cs
//   2. csc /target:exe /out:a.exe 030202-StaticConstructor.cs

namespace Wrox.ProfessionalCSharp.StaticConstructor
{
	// Why use static constructor method ?
	// Some fields or property must be initilized when instance created.

	using System;
	
	// This is a help class.
	public class ServerInfo {
		public static string address = "10.148.8.204";
		public static string port = "8080";
	}
	
	// ConstructStaticType contain a static constructor method.
	public class ConstructStaticType {
		
		// Fields define.
		public static readonly string ServerAddress;
		public static readonly string ServerPort;
		
		// Static constructor
		static ConstructStaticType() { 
			ServerAddress = ServerInfo.address;
			ServerPort = ServerInfo.port;
		}
		
		public string getServerHead() {
			return (ServerAddress + ":" + ServerPort);
		}
	}
	
	// Execute from this line.
	public class CallConstructProtectedType {
		public static void Main(string[] args) {
			ConstructStaticType cst = new ConstructStaticType();
			Console.WriteLine(cst.getServerHead());
		}
	}
}
