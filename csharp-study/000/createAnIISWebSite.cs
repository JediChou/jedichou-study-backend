using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Administration;

namespace MSWebAdmin_Application
{
	class Program
	{
		static void Main(string[] args)
		{
			ServerManager serverManager = new ServerManager();
			serverManager.Sites.Add(
				"MyNewSite", "http", ":80:",
				"c:\\inetpub\\MyNewSite"
			);
			serverManager.Sites["My New Site"].ServerAutoStart = true;
			serverManager.Update();
		}
	}
}
