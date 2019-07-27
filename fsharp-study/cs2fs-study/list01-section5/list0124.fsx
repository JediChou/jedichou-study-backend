// F# for C# Developers.pdf, page 26
// Listing 1-24, An example of how elements in a list cannot be compared

// the following code compiles
open Microsoft.FSharp.Core;
open System.Windows.Forms
open System.Windows.Forms.ComponentModel;

let l1 = [ new TextBox(); ]
let l2 = [ new TextBox(); ]

// the following code does not compile
// printfn "%A" (l1 < l2) // not compile
