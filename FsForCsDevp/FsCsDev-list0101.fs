// File: FsCsDev-list0101.fs
// Description: 求和示例

module FsCsDev.List0101

let main = 

    let mutable sum = 0
    for i = 0 to 100 do
        if i % 2 <> 0 then sum <- sum + 1
    printfn "The sum: [%A]" sum