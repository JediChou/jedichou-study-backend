#light
// function to calculate a midpoint
let halfWay a b =
    let dif = b - a
    let mid = dif/2
    mid + a

// call the function and print the resutls
printfn "(halfWay 5 11) = %i" (halfWay 5 11)
printfn "(halfWay 11 5) = %i" (halfWay 11 5)
