// F# for C# Developers.pdf, page 33
// Listing 1-35, An equal function definition

// 重新定义操作符
let f = (=)
printfn "1 eq 2: %A" (f 1 2)
printfn "2 eq 2: %A" (f 2 2)

// 使用中文重新定义操作符
let 相等 = (=)
let 换行打印 = (printfn)
换行打印 "1 eq 2: %A" (相等 1 2)