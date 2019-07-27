// File name: HundredPixelsSquare.cs
using System;
using System.Drawing;
using System.Windows.Forms;

class HundredPixelSquare : Form {
	public new static void Main() {
		Application.Run(new HundredPixelSquare());
	}
	public HundredPixelSquare() {
		Text = "Hundred Pixel Square";
	}
	//protected override void DoPage(Graphics grfx, Color clr, int cx, int cy) {
	//	grfx.FillRectangle(new SolidBrush(clr), 100, 100, 100, 100);
	//}
}
