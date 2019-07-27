using System;
using System.Configuration;

public class Program
{
	public static void Main()
	{
		Configuration appCfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
		AppSettingsSection appSettings = appCfg.AppSettings;
		int myInt;
		
		if(int.TryParse( appSettings.Settings["MyInt"].Value, out myInt) )
		{
			Console.WriteLine(myInt);
			myInt *= 10;
			Console.WriteLine("after myInt *= 10, the myInt value is: " + myInt);

			appSettings.Settings["MyInt"].Value = myInt.ToString();
			appCfg.Save();
		}

	}
}
