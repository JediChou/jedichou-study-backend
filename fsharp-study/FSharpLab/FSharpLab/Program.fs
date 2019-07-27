// File: Scope4.fs

//// function that returns a function to
//let calculatePrefixFunction prefix =
//
//    // calculate prefix
//    let prefix' = Printf.sprintf "[%s]: " prefix
//
//    // define function to perform prefixing
//    let prefixFunction appendee =
//        Printf.sprintf "%s%s" prefix' appendee
//        
//    // return function
//    prefixFunction
//
//// create the prefix function
//let prefixer = calculatePrefixFunction "DEBUG"
//
//// use the prefix function
//printfn "%s" (prefixer "My message")
//
//printfn "%s" (Printf.sprintf "%s" "jedi")


open Module1

let t = Module1.Calulate.getOne()
let m = Module1.Calulate.getTwo()
let x = t + m

printfn "%d" x