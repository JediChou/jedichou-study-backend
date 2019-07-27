// Program: CombinatorialApp.fs
// Program F#

let rec mss x c =
    if List.length x = 0 then 0
    else
        if x.Head > c then mss x.Tail c
        else max (mss x.Tail c) (x.Head+(mss x.Tail (c-x.Head)))

let x = [2; 3; 5; 10; 15; 20; 25]
printfn "%i" (mss x 49)

let y = [11..16]
printfn "%i" (mss y 49)
