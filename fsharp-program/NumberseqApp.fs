// Program: NumberseqApp.fs
// Program F#

let rec fib n =
    if n <= 2 then 1
    else fib(n-1) + fib(n-2)

// Output 10th element of fib seq
printfn "%i" (fib 10);

// Calculate 15th-20th elements of fib seq
let x = [|15 .. 20|];
let y = Array.map fib x;
printfn "%O" y  // TODO: 如何不用迭代就輸出