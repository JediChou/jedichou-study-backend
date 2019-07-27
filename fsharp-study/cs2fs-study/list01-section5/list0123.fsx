// F# for C# Developers.pdf, page 26
// Listing 1-23, A list comparison

let l1 : int list = [1;2;3]
let l2 : int list = [2;3;1]
printfn "l1 = l2 ? %A" (l1 = l2)
printfn "l1 < l2 ? %A" (l1 < l2)