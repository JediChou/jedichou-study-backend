// F# for C# Developers, page 27
// Listing 1-3, The escape double quote (")

[<EntryPoint>]
let main argv = 
    
    // use backslash (\) to escape double quote
    let a = "this is \"good\"."

    // use two double quote to escape
    let b = @"this is ""good""."

    printfn "%s" a
    printfn "%s" b
    0 // return an integer exit code
