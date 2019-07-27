// File: IdenName.fs
// Description: Identifier Names

// 标识符命名
let x = 42
let x' = 43
let 标识符 = 42
let ``more? `` = true   // 这段定义很有意思
let ``class`` = "style" // 这个特性太酷了

// 主程序函数体
let main() =
    printfn "%A" x
    printfn "%A" x'
    printfn "%A" 标识符
    printfn "%A" ``more? ``
    printfn "%A" ``class``

// 调用主程序
main()