// F# for C# Developers.pdf, page 35
// Listing 1-40, The map function

let mySeq = seq { 1..10 }
let result = mySeq |> Seq.map (fun n -> n*2)

printfn "Check result is : %A" (Seq.forall2 (=) result (seq {2..2..20}))
printfn "%A" result
