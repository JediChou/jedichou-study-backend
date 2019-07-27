// program: BasicApp.fs
let fangle a b c =
    let l = (a+b+c)/2.0
    let s = sqrt(l*(l-a)*(l-b)*(l-c))
    asin (2.0*s/b/c), asin (2.0*s/a/c), asin (2.0*s/a/b)

let q1 = fangle 3.0 4.0 5.0;;
let q2 = fangle 1.5 1.0 1.5;;
