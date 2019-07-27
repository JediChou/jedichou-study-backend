// F# for C# developers, page 12
// Listing 1-10, The console output

[<EntryPoint>]
let main argv = 
    let sum = 5050
    printfn "the sum of odd numbers from 0 to 100 is %A" sum
    System.Console.WriteLine("the sum of odd number from 0 to 100 is {0}", sum)
    0 // return an integer exit code
