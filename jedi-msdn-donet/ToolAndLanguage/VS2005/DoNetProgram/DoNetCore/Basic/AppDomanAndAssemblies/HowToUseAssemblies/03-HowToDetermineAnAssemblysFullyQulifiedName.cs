// How to determine an assembly's full quanlified name
//   reference url:
//   http://msdn.microsoft.com/zh-cn/library/2exyydhb(v=vs.80).aspx

// a. method
//    a.1 msorcfg.msc (.net framework configuration tools)
//    a.2 view cache directory
//    a.3 use gacutil.exe
// b. a.2 detail steps
//      step1, [star]-[management]-[Microsoft .NET Framework config]
//      step2, single click [assemblies cache manage], and view list
//    a.2 reference:
//      http://msdn.microsoft.com/zh-cn/library/9x295t9k(v=vs.80).aspx
// c. use programming method
//    c.1 03-htdafn-cs.cs, c# demo
//    c.2 03-htdafn-vb.vb, vb.net demo
// d. use ildasm.exe to check meta data
//    http://msdn.microsoft.com/zh-cn/library/f7dy01k1(v=vs.80).aspx
// e. more about pls check:
//    http://msdn.microsoft.com/zh-cn/library/4w8c1y2s(v=vs.80).aspx
//    http://msdn.microsoft.com/zh-cn/library/xwb8f617(v=vs.80).aspx
