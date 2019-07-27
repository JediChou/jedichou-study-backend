// csc /out:program.exe /t:exe /r:MSCorLib.dll via-pe50.cs
// csc /out:program.exe /t:exe via-pe50.cs
public sealed class Program {
	public static void Main() {
		System.Console.WriteLine("Hi");
	}
}
