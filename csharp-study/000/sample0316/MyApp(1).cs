using System;
using System.Reflection;
using System.Deployment.Application;

class Program {
	
	// Program start here
	public static void Main() {
		AppDomain.CurrentDomain.AssemblyResolve += AssemblyResovleHandler;
		Console.WriteLine("Hello from MyApp.");
		Foo.FooFct();
	}

	// Delegate method
	static Assembly AssemblyResovleHandler(object sender, ResolveEventArgs args) {
		if( ApplicationDeployment.IsNetworkDeployed ) {
			ApplicationDeployment currentDeployment =
					ApplicationDeployment.CurrentDeployment;
			currentDeployment.DownloadFileGroup("MyGroup");
			Console.WriteLine("Downloading......");
		}
		return Assembly.Load("MyLib");
	}
}

class Foo {
	public static void FooFct() {
		MyClass a = new MyClass();
		Console.WriteLine(a);
	}
}

/* Compile error message
 * csc MyApp.cs
 *
 * D:\WorkSpaces\MySrc\csharplab\PractialDoNet2AndCsharp2\sample0316>csc MyApp.cs
 * Microsoft (R) Visual C# 2005 Compiler version 8.00.50727.4927
 * for Microsoft (R) Windows (R) 2005 Framework version 2.0.50727
 * Copyright (C) Microsoft Corporation 2001-2005. All rights reserved.
 *
 * MyApp.cs(28,3): error CS0246: 找不到型別或命名空間名稱 'MyClass' (您是否遺漏using 指示詞或組件參考?)
 * MyApp.cs(28,19): error CS0246: 找不到型別或命名空間名稱 'MyClass' (您是否遺漏using 指示詞或組件參考?)
 * MyApp.cs(29,3): error CS1502: 最符合的多載方法 'System.Console.WriteLine(bool)' 有一些無效的引數
 * MyApp.cs(29,21): error CS1503: 引數 '1': 無法從 'MyClass' 轉換為 'bool'
 */
