using System; using System.Text;
class CSRegex_Sample009 { static void Main() {
	StringBuilder sb = new StringBuilder("This is my string.");
	string s1 = sb.ToString();
	string s2 = sb.ToString(5,5);
	Console.WriteLine("{0}\n{1}", s1, s2);
}}
