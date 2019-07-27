// F# for C# Developers, page 29
// Listing 1-7, A while loop

[<EntryPoint>]
let main argv = 
    let mutable i = 0
    while i <= 100 do
        printfn "%d" i
        i <- i + 1
    0 // return an integer exit code