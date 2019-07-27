// F# for C# Developers.pdf, page 29
// Listing 1-28, An array comparison

let l1 = [| 1;2;3 |]
let l2 = [| 2;3;1 |]
printfn "l1 = l2 ? %A" (l1 = l2)
printfn "l1 < l2 ? %A" (l1 < l2)
