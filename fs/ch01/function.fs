// File: function.fs

// 定义函数
let add x y = x + y
let sub x y = x - y
let mul x y = x * y
let div x y = x / y

// 主程序函数体
let main() =
    printfn "%A" (add 1 2)
    printfn "%A" (sub 1 2)
    printfn "%A" (mul 1 2)
    printfn "%A" (div 1 2)

// 调用主程序
main()