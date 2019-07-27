// F# for C# Developers, page 31
// listing 1-10, a match and switch sample

[<EntryPoint>]
let main argv = 
    
    // class mode
    let intNumber = 1
    match intNumber with
        | 1 -> printfn "this is one"
        | 2 -> printfn "this is two"
        | 3 -> printfn "this is three"
        | _ -> printfn "this is anything else"

    // jedi demo
    for index in [1..10] do
        match index with
            | 1 -> printfn "this is one"
            | 2 -> printfn "this is two"
            | 3 -> printfn "this is three"
            | _ -> printfn "this is anything else"

    0 // return an integer exit code
