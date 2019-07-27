[System.Flags]
public enum MouseButtons { Left=1, Right=2, Middle=3 }

class Program {
	public static void Main() {
		MouseButtons m = MouseButtons.Left | MouseButtons.Right | MouseButtons.Middle;
		System.Console.WriteLine(m);

		if ( (m & MouseButtons.Left) == MouseButtons.Left)
			System.Console.WriteLine("Press left key");
	}
}
