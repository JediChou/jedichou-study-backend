// F# for C# developers, page 12
// Listing 1-12, The printfn function and data types

[<EntryPoint>]
let main argv = 
    
    let int = 42
    let string = "This is a string"
    let char = 'c'
    let bool = true
    let bytearray = "This is a byte string"B

    let hexint = 0x34
    let octalint = 0o42
    let binaryinteger = 0b101010
    let signedbyte = 68y
    let unsignedbyte = 102uy

    let smallint = 16s
    let smalluint = 16us
    let integer = 345l
    let unsignedint = 345ul
    let nativeint = 765n

    let unsignednativeint = 765un
    let long = 123456789123456789L
    let unsignedlong = 12345678912345UL
    let float32 = 42.8F
    let float = 42.8

    printfn "int = %d or %A" int int
    printfn "string = %s or %A" string string
    printfn "char = %c or %A" char char
    printfn "bool = %b or %A" bool bool
    printfn "bytearray = %A" bytearray

    printfn "hex int = %x or %A" hexint hexint
    printfn "HEX INT = %X or %A" hexint hexint
    printfn "oct int = %o or %A" octalint octalint
    printfn "bin int = %d or %A" binaryinteger binaryinteger
    printfn "signed byte = %A" signedbyte

    printfn "small int = %A" smallint
    printfn "small uint = %A" smalluint
    printfn "int = %i or %A" integer integer
    printfn "uint = %i or %A" unsignedint unsignedint
    printfn "native int = %A" nativeint

    printfn "unsigned native int = %A" unsignednativeint
    printfn "long = %d or %A" long long
    printfn "unsigned long = %A" unsignedlong
    printfn "float = %f or %A" float32 float32
    printfn "double = %f or %A" float float

    0 // return an integer exit code
