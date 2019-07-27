// File name: scope-20150813-1125.fs
// Description: 
//  Apress Beginning F# - page 24(46/500)
//  Function return a function.
//  Use this feature you can create a 
//  dynamic application.

open System

// function that returns a function to
let calculatePrefixFunction prefix =
    // calculate prefix
    let prefix' = Printf.sprintf "[%s]: " prefix
    // define function to perform prefixing
    let prefixFunction appendee =
        Printf.sprintf "%s%s" prefix' appendee
    // return function
    prefixFunction

// create the prefix function
let prefixer = calculatePrefixFunction "DEBUG"

// use the prefix function
printfn "%s" (prefixer "My message")
