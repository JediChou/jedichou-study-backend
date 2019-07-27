// File: Literals.fs

// 字符串
let message = "HelloWorld\r\n\t!"
let dir = @"c:\projects"

// Byte数组
let bytes = "bytesbytesbyte"B

// 数值类型
let xA = 0xFFy      // 16进制
let xB = 0o7777un   // 8进制
let xC = 0b10010UL  // 2进制

// 主程序函数体
let main() =
    printfn "%A" message
    printfn "%A" dir
    printfn "%A" bytes
    printfn "%A" xA
    printfn "%A" xB
    printfn "%A" xC

// 调用主程序
main()