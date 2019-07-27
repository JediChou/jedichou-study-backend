let x = 5
let x' = x
let f = fun x -> (x-1) * x * (x+1)
let f' = f
let y = f' x'
printfn "%d" y
