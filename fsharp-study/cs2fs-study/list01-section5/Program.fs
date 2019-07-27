// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    let l1 : int list = [1;2;3]
    let l2 : int list = [2;3;1]
    printfn "l1 = l2 ? %A" (l1 = l2)
    printfn "l1 < l2 ? %A" (l1 < l2)
    0 // return an integer exit code
