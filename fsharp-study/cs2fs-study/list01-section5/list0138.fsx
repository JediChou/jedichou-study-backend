// F# for C# Developers.pdf, page 34
// Listing 1-38, The forall2 function

let myEvenNumSeq1 = { 2..2..10}
let myEvenNumSeq2 = {12..2..20}

if Seq.forall2 (fun n n2 -> n+10 = n2) myEvenNumSeq1 myEvenNumSeq2 then
    printfn "forall2 will returns TRUE"
