// F# for C# Developers.pdf, page 30
// Listing 1-29, Slicing an F# array

// define an array with element 1-10
let array0 = [| 1..10 |]

printfn "%A" array0.[2..6]  // get slice from element 2 through 6
printfn "%A" array0.[4..]   // get slice from element 4 to end
printfn "%A" array0.[..6]   // get slice from start to element 6
printfn "%A" array0.[*]     // get all the elements (copy the whole array)