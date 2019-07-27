// File: IdenLet.fs
// Description: Identifiers and let Bindings

// 标识符和绑定
let x = 42
let myAdd = fun x y -> x + y
let raisePowerTwo x = x ** 2.0

// 极其简单的一个逻辑
let n = 10
let add a b = a + b
let result = add n 4

// 主程序函数体
let main() =
    printfn "x: %A" x
    printfn "(myAdd 2 3): %A" (myAdd 2 3)
    printfn "(raisePowerTwo 3.0): %A" (raisePowerTwo 3.0)
    printfn "result: %A" result

// 调用主程序
main()