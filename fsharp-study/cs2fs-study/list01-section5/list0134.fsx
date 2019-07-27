// F# for C# Developers.pdf, page 32
// Listing 1-34, The exists and exist2 functions

let mySeq1 = seq { 1..10 }
let mySeq2 = seq { 10..-1..1}

// check if mySeq1 contain 3, which will make "fun n -> n = 3" return TRUE
if mySeq1 |> Seq.exists(fun n -> n = 3) then printfn "mySeq1 contains 3"

// more concise version to check if it contains number 3
if mySeq1 |> Seq.exists((=)3) then printfn "mySeq1 contains 3"

// check if two sequences contain the same element at same location
if Seq.exists2 (fun n1 n2 -> n1 = n2) mySeq1 mySeq2 then
    printfn "two sequences contain same element at same location"