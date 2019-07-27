// F# for C# Developers.pdf, page 31
// Listing 1-31, A functional approach to solve the odd-number summary problem

// 典型的函数式编程
seq { 0..100 }
|> Seq.filter(fun n -> n%2<>0)
|> Seq.sum
|> printfn "the sum of odd number from 0 to 100 is %A"
