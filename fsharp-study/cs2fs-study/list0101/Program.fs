// F# for C# developers.pdf
// Listing 1-1, A C# snippet that adds odd numbers from 0 to 100

[<EntryPoint>]
let main argv = 
    let mutable sum = 0
    for i = 0 to 100 do
        if i % 2 <> 0 then sum <- sum + 1
    printfn "The sum of odd numbers from 0 to 100 is %d" sum
    0 // return an integer exit code