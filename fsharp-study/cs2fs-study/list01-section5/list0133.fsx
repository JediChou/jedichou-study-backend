// F# for C# Developers.pdf, page 32
// Listing 1-33, The length function

let myList = [1..10]
let myArray = [| 1..10 |]
let mySeq = {1..10}

printfn "myList length: %A" (myList |> List.length)
printfn "myArray length: %A" (myArray |> Array.length)
printfn "mySeq length: %A" (mySeq |> Seq.length)