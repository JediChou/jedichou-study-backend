// How to : Build a Single-File Assembly
//   MSDN Reference Url:
//   http://msdn.microsoft.com/zh-cn/library/z38d5bzk(v=vs.80).aspx
//   http://msdn.microsoft.com/zh-cn/library/z38d5bzk(v=vs.110).aspx

// a. A single-file assembly, which is he simplest type of assembly,
//    contains type information and implementation, as well as the
//    assembly mainifest.
//
// b. note
//    visual studio 2005 for c# and visual basic can be used only to
//    create single-file assemblies. if you want to create multifile
//    assemblies, you must use command-line compliers or visual studio
//    2005 for visual c++
//
// c. to create an assembly with an .exe extension
//    <compiler command> <modulue name>
//    c# command: csc myCode.cs
//    vb.net command: vbc myCode.vb
//
// d. to create an assembly with an .exe extension and specify the output file name
//    <complier command> /out:<file name> <module name>
//    c# command: csc /out:myAssembly.exe myCode.cs
//    vb.net command: vbc /out:myAssembly.exe myCode.vb
//
// e. Creating Library Assemblies
//    <complier command> /t:library <module name>
//    c# command: csc /out:myAssemly.exe myCode.cs
//    vb.net command:
