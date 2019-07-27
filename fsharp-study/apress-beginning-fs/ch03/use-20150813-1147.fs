// File name: scope-20150813-1147.fs
// Description: 
//  Apress Beginning F# - page 25(47/500)
//  How to use 'use'~

open System.IO

// function to read first line from a file
let readFirstLine filename =
    // open file using a "use" binding
    use file = File.OpenText filename
    file.ReadLine()

// call function and print the result
printfn "First line was: %s" (readFirstLine @"c:\DCSetup.LOG")

