// file: cs-regx070.cs
// use regx to check telphone number

using System;
using System.Text;

public class CSRegx070 {

	public static void Main(string[] args) {
		var instance = new CSRegx070();
		var telephones = new [] {
			"123-4567890",
			"027-6767677",
			"3333-testdt"
		};

		foreach (var telephone in telephones) {
			var check = IsTelephone(telephone);
			Console.WriteLine(check);
		}
	}

	private static bool IsTelephone(string strTelephone) {
		return System.Text.RegularExpressions.Regex.IsMatch(strTelephone, @"^(\d{3,4}-)?\d{6,8}$");
	}
}
