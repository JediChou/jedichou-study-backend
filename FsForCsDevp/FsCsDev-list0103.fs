// 文件: FsCsDev-list0103.fs
// 作用: 转义符的使用

module FsCsDev.List0103

let main =

  let a = "this is \"good\"."   // 使用"\"进行转义
  let b = @"this is ""good""."  // 在使用@的字符串里用""进行转义
  
  // 输出
  printfn "%s" a
  printfn "%s" b