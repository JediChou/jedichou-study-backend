// File: Scope2.fs
open System

// 創建一個接受輸入整數的函數
let 讀取整數() = int (Console.ReadLine())
let 輸入單參數 str = printfn str

// 生日謎題遊戲源代碼
let 生日謎題() =

    輸入單參數 "輸入你出生的所在的日期數: "
    let 輸入 = 讀取整數()
    let 魔法數 = 輸入 * 4
    let 魔法數 = 魔法數 + 13
    let 魔法數 = 魔法數 * 25
    let 魔法數 = 魔法數 - 200

    printfn "輸入你出生的所在的月數: "
    let 輸入 = 讀取整數()
    let 魔法數 = 魔法數 + 輸入
    let 魔法數 = 魔法數 * 2
    let 魔法數 = 魔法數 - 40
    let 魔法數 = 魔法數 * 50

    printfn "輸入你出生的年份後兩位: "
    let 輸入 = 讀取整數()
    let 魔法數 = 魔法數 + 輸入
    let 魔法數 = 魔法數 - 10500

    printfn "生日是 (ddmmyy): %i" 魔法數

// 開始運行程序
生日謎題()