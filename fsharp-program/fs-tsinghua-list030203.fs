// File name: fs-tsinghua-list030203.fs

let a1 = (+) 2 5
printfn "a1 value: %d" a1

let a2 = (*) 3 4
printfn "a2 value: %d" a2

let muls = (*) 9
let a3 = muls 10
printfn "a3 value: %d" a3

let mmlus x = x |> muls |> muls
let a4 = mmlus 11
printfn "a4 value: %d" a4
