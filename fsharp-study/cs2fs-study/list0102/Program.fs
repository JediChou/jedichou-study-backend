// F# for C# Developers, page 27
// Listing 1-2 Normal and verbatim strings

[<EntryPoint>]
let main argv = 
    let a = "the last character is tab\t"
    let b = @"the last character is tab\t"
    printfn "%s" a
    printfn "%s" b
    0 // return an integer exit code
