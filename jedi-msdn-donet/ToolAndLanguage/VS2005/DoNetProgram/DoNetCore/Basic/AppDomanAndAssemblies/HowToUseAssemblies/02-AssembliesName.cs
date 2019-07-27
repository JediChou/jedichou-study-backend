// Assemblies Name
// .NET Framework 2.0
// Reference Url:
//   http://msdn.microsoft.com/zh-cn/library/k8xx4k69(v=vs.80).aspx

// a. use x.FullName to get assembliy name
// b. sample for myTypes:
//    myTypes, Version=1.0.1234.0, Culture=en-US, PublicKeyToken=xxx, ProcessArchitecture=msil
// c. Notice, in the .net framework 2.0
//    c.1 create multi version for same assembly, diff at 32bit or 64bit.
//    c.2 more about: System.Reflection.AssemblyName.ProcessorArchitecture
// d. in the b.sample
//    d.1 strong name: public key sign, area is american english, verison is 1.0.1234.0
//    d.2 msil is mean : use jit to complie to 32bit code or 64bit code.
//    d.3 msil: the compile result is decide by your os type.
// e. reference .net framework other assemblies must contain full assembilies name.
//    e.1 Sample:
//      System.data, version=1.0.3300.0, Culture=neutral, PublickKeyToken=xxx
//    e.2 Full Sample in the configuration file
//      <add name="myListener" 
//           type="System.Diagnostics.TextWriteTraceListenner,
//           system version=1.0.3300.0,
//			 Culture=neutral,
//			 PublicKeyToken=xxx
//			 initializeData="c:\myListener.log" />
// f. Named application components
//    f1. stage 1: myAssembly.exe -> myAssembly.dll(contain assemblies information, right)
//    f2. stage 2: Other program -> myAssembly.dll(get a TypeLoadException)
