// F# for C# Developers.pdf, page 34
// Listing 1-39, The forall2 function

// use let to define a function
let isDivisibleBy number elem = elem % number = 0

let result = Seq.find (fun n -> isDivisibleBy 5 n)[1 .. 10]
printfn "%A" result