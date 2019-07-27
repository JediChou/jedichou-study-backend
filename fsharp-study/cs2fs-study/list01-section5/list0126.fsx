// F# for C# Developers.pdf, page 29
// Listing 1-26, defining an F# array

let array0 = [| 1..10 |]  // defines an array with elements from 1 to 10.
let array1 = [| 1;2;3 |]  // defines an array with element 1, 2 and 3.
let array2 = [| for i = 0 to 4 do yield i*2 |]  // defines an array with square nums
let emptyArray1 = [| |]   // define empty array
let emptyArray2 = Array.empty  // define empty array

printfn "%A" array0
printfn "%A" array1
printfn "%A" array2
printfn "%A" emptyArray1
printfn "%A" emptyArray2

