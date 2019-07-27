// 2014-4-9 14:06 Jedi Zhou
// Memo:
//   The author can not tell path configurate under windows.
//   My action is:
//     1. Set env variable GOPATH = c:\go
//     2. Add project directory to GOPATH, so GOPATH=c:\go;d:\calcproj
//     3. Enter into project directory, cd d:\calcproj\bin
//     4. Execute build command, go build calc
//     So, you can get it.
// Memo: There has two error at eletric book.
//   1. Line 30, [if len(args) != 3] must be [if len(args) != 4]
//   1. Line 45, [if len(args) != 2] must be [if len(args) != 3]
