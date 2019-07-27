// Date: 2015-1-15 12:53
// Reference URL:
//   http://msdn.microsoft.com/zh-cn/library/b0b8dk77(v=vs.80).aspx

// Create assemblies
// .NET Framework 2.0

// a. use vs2005 or .net framework sdk to create assemblies
// b. can create one or more assemblies
// c. simple way: load a single appdomain config file
// d. if you want to unload assemblies, you can unload config file
// e. split source and multi-config files! because:
//   e.1 version control: set version for modules
//   e.2 deploy: support codes for deploy modle, resouce groups
//   e.3 reuse: module split at logics
//   e.4 security: support multi-security permissions
//   e.5 ­­©w½d³ò
// f. special: if program call a COM component, pls reference:
//    http://msdn.microsoft.com/zh-cn/library/zsfww439(v=vs.80).aspx
