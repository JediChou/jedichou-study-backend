let num = 10
let str = "F#"

let squareIt = fun n -> n * n
let doubleIt = fun n -> 2 * n
let squareIt2 n = n * n

let integerList = [ 1; 2; 3; 4; 5; 6; 7 ]
let stringList = [ "one"; "two"; "three" ]
let funList = [ squareIt; doubleIt ]

let BMICalculator = fun ht wt -> 
                    (float wt / float (squareIt ht)) * 703.0

let integerTuple = ( 1, -7 )
let stringTuple = ( "one", "two", "three" )

let mixedTuple = ( 1, "two", 3.3 )
let funTuple = ( squareIt, BMICalculator )
let moreMixedTuple = ( num, "two", 3.3, squareIt )

let funAndArgTuple = (squareIt, num)
System.Console.WriteLine((fst funAndArgTuple).GetType())
System.Console.WriteLine((snd funAndArgTuple).GetType())

ignore(System.Console.ReadLine())
