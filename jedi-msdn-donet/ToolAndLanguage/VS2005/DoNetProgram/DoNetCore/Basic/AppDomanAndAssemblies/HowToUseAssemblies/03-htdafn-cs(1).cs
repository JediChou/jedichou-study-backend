using System; using System.Reflection;
class asmname {	public static void Main() {
	Type t = typeof( System.Data.DataSet);
	string s = t.Assembly.FullName.ToString();
	Console.WriteLine("Fully qualified assembly anme [{0}]", s);
}}
