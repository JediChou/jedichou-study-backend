using System;
using System.Text;

class CSRegx_Sample008 { static void Main() {
	var sb = new StringBuilder();
	Console.WriteLine(sb.Capacity + "\t" + sb.Length);

	sb.Append('a', 17);
	Console.WriteLine(sb.Capacity + "\t" + sb.Length);

	sb.Append('b', 16);
	Console.WriteLine(sb.Capacity + "\t" + sb.Length);

	sb.Append('c', 32);
	Console.WriteLine(sb.Capacity + "\t" + sb.Length);

	sb.Append('d', 64);
	Console.WriteLine(sb.Capacity + "\t" + sb.Length);
}}
