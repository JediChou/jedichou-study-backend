// File: Scope.fs

// 定义一个取中间值过程
let 折半取值 数值1 数值2 =
    let 差异 = 数值2 - 数值1
    let 間距 = 差异 / 2
    間距 + 数值1 


// 主程序函数体
let 主程序() =
    printfn "(halfway 5 11) = %A" (折半取值 5 11)
    printfn "(halfway 11 5) = %A" (折半取值 11 5)

// 调用主程序
主程序()