// F# for C# Developer, Page 28
// listing 1-5, Defining a variable

[<EntryPoint>]
let main argv = 
    
    // variable with a space 
    let ``my variable`` = 4

    // variable using a keyword
    let ``let`` = 4

    // apostrophe(') in a variable name
    let mySon's = "Feb 1, 2010"
    let x' = 3

    // include # in the variable name
    let ``F#`` = "this is an F# program."

    // TODO How to output ?
    // printfn "%s" ``my variable``
    // printfn "%s" ``let``
    // printfn "%s" ``x'``

    printfn "%s" ``mySon's``
    printfn "%s" ``F#``

    0 // return an integer exit code
