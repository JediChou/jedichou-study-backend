using System;
using System.IO;
using System.Text;

class CSRegx_Sample004 {
	static void Main(string[] args) {
		var fs = new FileStream("text.bin", FileMode.OpenOrCreate);
		var t = new StreamWriter(fs, Encoding.UTF8);
		t.Write("This is in UTF8");
		t.Flush();

		var t2 = new StreamWriter(fs, Encoding.Unicode);
		t2.Write("This is in Unicode (UTF16)");
		t2.Flush();

		var t3 = new StreamWriter(fs, Encoding.ASCII);
		t3.Write("This is in ASCII");
		t3.Flush();

		fs.Close();
	}
}
