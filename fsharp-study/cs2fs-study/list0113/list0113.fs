// F# for C# developers, page 12
// Listing 1-13, The C# and F# versions of adding odd numbers from 0 to 100

[<EntryPoint>]
let main argv = 
    let mutable sum = 0
    for i = 0 to 100 do
        if i%2 <> 0 then sum <- sum + i
    printfn "the sum of odd numbers from 0 to 100 is %A" sum
    0 // return an integer exit code
