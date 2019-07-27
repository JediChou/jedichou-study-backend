// F# for C# Developers.pdf, page 34
// Listing 1-37, The forall function

let myEvenNumberSeq = {2..2..10}
printfn "Output: %A" (myEvenNumberSeq |> Seq.forall (fun n -> n % 2 = 0))
