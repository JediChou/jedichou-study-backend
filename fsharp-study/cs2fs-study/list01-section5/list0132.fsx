// F# for C# Developers.pdf, page 31
// Listing 1-32, Using the pipe-forward operator

let mySeq = {0..100}

printfn "Use |> operator to ouput: %A" (mySeq |> Seq.length)
printfn "Use Seq.length to output: %A" (Seq.length mySeq)