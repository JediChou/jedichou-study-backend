// F# for C# Developers.pdf, page 26
// Listing 1-25, Defining a sequence in F#

// defines a sequence with elements from 1 to 10.
let seq0 = seq { 1.. 10 }

// defines a sequence with elements 0, 1, 4, 9, and 16
let seq1 = seq { for i=0 to 4 do yield i*i }

// defines a sequence using for...in
let seq2 = seq {
    for i in [1..10] do yield i * 2
}

// defines an empty sequence
let emptySeq = Seq.empty

printfn "%A" seq0
printfn "%A" seq1
printfn "%A" seq2
printfn "%A" emptySeq