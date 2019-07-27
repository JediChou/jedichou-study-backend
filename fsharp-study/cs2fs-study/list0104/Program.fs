// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    
    // define
    let tripQuotedString = """this is "good"."""
    let a = """"good" dog"""       // quote in the string can be at the beginning of the string
    let b = """this is "good" """  // quote in the string can not be at the end of the string

    // output
    printfn "%s" tripQuotedString
    printfn "%s" a
    printfn "%s" b
    
    0 // return an integer exit code
