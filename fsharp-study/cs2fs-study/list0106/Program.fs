// F# for C# Developers, page 29
// Listing 1-6 A for loop

[<EntryPoint>]
let main argv = 
    for i in [0 .. 10] do
        printfn "%d" i
    0 // return an integer exit code
