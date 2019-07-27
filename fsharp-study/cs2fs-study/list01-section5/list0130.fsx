// F# for C# Developers.pdf, page 30
// Listing 1-30, An F# pipe-forward operator

let mutable x = 3
let g x = x * x
let f x = x + x
printfn "%A" (x |> g |> f)
