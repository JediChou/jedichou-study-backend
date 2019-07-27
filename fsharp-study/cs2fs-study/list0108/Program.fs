// F# for C# Developers
// Listing 1-8, An if expression

[<EntryPoint>]
let main argv = 
    if 3%2 <> 0 then printfn """3 mod 2 <> 0"""
    0 // return an integer exit code
