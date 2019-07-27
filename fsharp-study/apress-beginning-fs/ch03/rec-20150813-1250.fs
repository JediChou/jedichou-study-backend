// File name: rec-20150813-1250.fs
// Description: 
//  Apress Beginning F# - page 26(48/500)
//  Create a Recursion function.

// a function to generate the Fibonacci numbers
let rec fib x =
    match x with
    | 1 -> 1
    | 2 -> 1
    | x -> fib(x-1) + fib(x-2)

// call the function and print the results
printfn "(fib 2) = %i" (fib 2)
printfn "(fib 6) = %i" (fib 6)
printfn "(fib 11) = %i" (fib 11)
