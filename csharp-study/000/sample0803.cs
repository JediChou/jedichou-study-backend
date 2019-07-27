using System.Runtime.InteropServices;
class program {
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int MessageBox(System.IntPtr hWnd,
					string text, string caption, uint type);

	static void Main() {
		MessageBox(System.IntPtr.Zero, "hello", "caption text", 0);
	}
}
