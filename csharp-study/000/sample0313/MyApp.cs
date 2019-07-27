using System.Configuration;

class Program {
	static void Main() {
		MySettings mySettings = new MySettings();
		int myIntUsr = mySettings.MyIntUsr;
		System.Console.WriteLine(myIntUsr);

		myIntUsr *= 10;
		mySettings.MyIntUsr = myIntUsr;
		mySettings.Save();
		System.Console.WriteLine(mySettings.MyIntApp);
	}
}

class MySettings : ApplicationSettingsBase {
	[UserScopedSetting()]
	public int MyIntUsr {
		get { return (int)(this["MyIntUsr"]); }
		set { this["MyIntUsr"] = value; }
	}
	[ApplicationScopedSetting()]
	public int MyIntApp {
		get { return (int)(this["MyIntApp"]); }
	}
}
