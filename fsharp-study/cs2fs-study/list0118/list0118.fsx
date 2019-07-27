#if VERSION1
    let f1 x y =
        printfn "x: %d y: %d" x y
        x + y
#else
    let f1 x y =
        printfn "x: %d y: %d" x y
        x - y
#endif

printfn "%A" 123123