using System;
using System.Security.Principal;

class CheckAdmin {
	public static void Main(string[] args) {

		// Get current identity, and get windows principal object
		WindowsIdentity identity = WindowsIdentity.GetCurrent();
		WindowsPrincipal principal = new WindowsPrincipal(identity);
		
		// check role and output result
		Console.WriteLine(
			principal.IsInRole(WindowsBuiltInRole.Administrator) ?
			"Current is administrator members" :
			"Current is not administrator, pls try again"
		);
	}
}
