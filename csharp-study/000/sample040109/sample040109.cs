// Share infomations between diff AppDomain at same process.
// EBook page 92
using System;
using System.Reflection;

public class Program {

	public static void Main() {
		AppDomain newDomain = AppDomain.CreateDomain("NewDomain");
		CrossAppDomainDelegate deleg = new CrossAppDomainDelegate(Fct);
		newDomain.DoCallBack(deleg);

		// Fetch from the new appdomain the data named 'AnInteger'.
		int anInteger = (int) newDomain.GetData("AnInteger");
		Console.WriteLine(anInteger);
		AppDomain.Unload(newDomain);
	}

	public static void Fct() {
		// This method is ran inside the appdomain 'NewDomain'. It creates
		// an appdomain data named "AnInteger' which has the value '691'.
		AppDomain.CurrentDomain.SetData("AnInteger", 691);
	}
}
