// File name: fs-tsinghua-list030202.fs
// Description: from page 35-36

let f1 = fun a b -> a*a + b*b
printfn "f1 result: %d" (f1 3 4)

let f2 = fun(a, b) -> a*a + b*b
printfn "f2 result: %d" (f2(3, 4))

let c1 = f1 3 4
printfn "c1 result: %d" c1

let c2 = f2(3, 4)
printfn "c2 result: %d" c2

let g1 x = x * (x-1)
let y1 = (3, 4) |> f2 |> g1
printfn "y1 value: %d" y1

let f3 = f1 3
printfn "f3 result: %d" (f3 4) // Curring

let c3 = f3 4
printfn "c3 result: %d" c3
